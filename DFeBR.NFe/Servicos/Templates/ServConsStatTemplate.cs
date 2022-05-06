// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Configurar;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Status;
using DFeBR.EmissorNFe.Servicos.Interfaces;
using DFeBR.EmissorNFe.Servicos.Retornos;
using DFeBR.EmissorNFe.Utilidade;
using DFeBR.EmissorNFe.Utilidade.Entidades;
using DFeBR.EmissorNFe.Utilidade.Exceptions;
using DFeBR.EmissorNFe.Utilidade.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Servicos.Templates
{
    /// <summary>
    /// Template de Consultar Status de NFe
    /// </summary>
    public abstract class ServConsStatTemplate : IServConsStatTemplate
    {
        #region Variaveis Globais

        /// <summary>
        ///     Quantidade de solicitações
        /// </summary>
        private static int _processadas;

        /// <summary>
        ///     Quantidade de solicitações rejeitadas ou denegadas
        /// </summary>
        private static int _rejeitadas;

        #endregion

        #region Propriedades

        /// <summary>
        ///     Tipo do serviço: Consultar Status do Serviço
        /// </summary>
        public string NomeServico => "Status do Serviço NFe";

        #endregion

        #region Construtor

        /// <summary>
        ///     Inicializa objeto
        /// </summary>
        /// <param name="emissorServicoConfig">Configuração do Emissor</param>
        /// <param name="certificado">Certificado Digital</param>
        /// <param name="versao">Versao do Serviço</param>
        /// <param name="modelo"></param>
        protected ServConsStatTemplate(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, VersaoServico versao,
                ModeloDocumento modelo = ModeloDocumento.NFe)
        {
            if (certificado == null) throw new ArgumentNullException(nameof(certificado));
            _emisorEmissorServicoConfig = emissorServicoConfig ?? throw new ArgumentNullException(nameof(emissorServicoConfig));
            _servicoBase = new ServHttpSoapBase(emissorServicoConfig, certificado, NomeServico);
            _versao = versao;
            _modelo = modelo;
        }

        #endregion

        /// <summary>
        ///     Obter mensagem Soap em formato Xml
        ///     <para>Corpo da mensagem compativel com a especificação SOAP e requisitos Sefaz</para>
        /// </summary>
        /// <param name="urlWsdl">Endereço WSDL do serviço</param>
        /// <param name="entity"></param>
        /// <example></example>
        /// <returns></returns>
        protected virtual string ObterCorpoMensagemSoap(string urlWsdl, consStatServ entity)
        {
            var xmlCorpo = Utils.ClasseParaXmlString(entity);
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?>");
            stringBuilder.Append(
                    "<soap:Envelope xmlns:soap=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">");
            stringBuilder.Append("<soap:Body>");
            stringBuilder.Append("<nfeDadosMsg xmlns=\"" + urlWsdl + "\">" + xmlCorpo + "</nfeDadosMsg>");
            stringBuilder.Append("</soap:Body>");
            stringBuilder.Append("</soap:Envelope>");
            var msg = stringBuilder.ToString();
            return msg;
        }

        /// <summary>
        ///     Dados de configuração do emissor
        /// </summary>
        private readonly EmissorServicoConfig _emisorEmissorServicoConfig;

        /// <summary>
        ///     Serviço Base
        /// </summary>
        private readonly IServHttpSoapBase _servicoBase;

        /// <summary>
        ///     Url do serviço
        /// </summary>
        private string _urlServico;

        /// <summary>
        ///     Versao do serviço
        /// </summary>
        private readonly VersaoServico _versao;

        /// <summary>
        ///     Modelo do documento
        /// </summary>
        private readonly ModeloDocumento _modelo;

        /// <summary>
        ///     Url WSDL do serviço
        /// </summary>
        private string _urlWsdlServico;

        /// <summary>
        ///     Salvar arquivo Xml
        /// </summary>
        private void SalvarArquivo(RetConsStat entity)
        {
            if (!_emisorEmissorServicoConfig.SalvarArquivoRetorno) return;
            //SalvarArquivo 
            if (string.IsNullOrWhiteSpace(_emisorEmissorServicoConfig.DiretorioArquivoRetornoXml))
                throw new InvalidOperationException("Informe um diretório válido.");
            var nomeArq = $"{Utils.ObterDataBrasil().ParaDataHoraString()}-ped-sta.xml";
            var caminho = Path.Combine(_emisorEmissorServicoConfig.DiretorioArquivoRetornoXml, "Status", "Recebidos");
            Utils.EscreverArquivo(caminho, nomeArq, entity.XmlRecebido);
        }

        /// <summary>
        ///     Endereço serviço
        /// </summary>
        /// <returns></returns>
        private string ObterUrlServico()
        {
            switch (_modelo)
            {
                case ModeloDocumento.NFe:
                    var url = _emisorEmissorServicoConfig.Ambiente == TipoAmbiente.Homologacao
                            ? _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsNFe.Homologacao.StatusServico
                            : _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsNFe.Producao.StatusServico;
                    return url;
                case ModeloDocumento.NfCe:
                    var url1 = _emisorEmissorServicoConfig.Ambiente == TipoAmbiente.Homologacao
                            ? _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsNFce.Homologacao.StatusServico
                            : _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsNFce.Producao.StatusServico;
                    return url1;
                default:
                    throw new ArgumentOutOfRangeException("Modelo de documento não suportado para o serviço");
            }
        }

        private string ObterWsdlServico()
        {
            return _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsWsdl.StatusServico;
        }

        /// <summary>
        ///     Obter Dados
        /// </summary>
        /// <returns></returns>
        private consStatServ ObterDados()
        {
            var pedStatus = new consStatServ
            {
                    cUF = _emisorEmissorServicoConfig.Estado,
                    tpAmb = _emisorEmissorServicoConfig.Ambiente,
                    versao = _versao.ObterVersaoServico()
            };
            return pedStatus;
        }

        /// <param name="entity"></param>
        /// ///
        /// <summary>
        ///     Lista de schemas relativos ao serviço
        /// </summary>
        /// <returns></returns>
        private ICollection<string> ObterListaNomeSchemas()
        {
            var list = new List<string>();
            var arqs = _emisorEmissorServicoConfig.ConfigEnderecoServico.Schemas.StatusServico.ToList();
            arqs.ForEach(n => { list.Add(n); });
            return arqs;
        }

        private void ValidarSchema(consStatServ entity)
        {
            var caminhoSchema = _emisorEmissorServicoConfig.DiretorioSchemaXsd;
            if (!Directory.Exists(caminhoSchema))
                throw new Exception("Diretório de Schemas não encontrado: \n" + caminhoSchema);
            // Define o tipo de validação
            var cfg = new XmlReaderSettings {ValidationType = ValidationType.Schema};
            //Listar arquivos XSD e inclui-las na validação
            var list = ObterListaNomeSchemas().ToList();
            list.ForEach(n => { cfg.Schemas.Add(null, Path.Combine(caminhoSchema, n)); });
            cfg.ValidationEventHandler += ValidationEventHandler;
            var xml = Utils.ClasseParaXmlString(entity);
            var reader = XmlReader.Create(new StringReader(xml), cfg);
            var document = new XmlDocument();
            document.Load(reader);

            //Valida xml
            document.Validate(ValidationEventHandler);
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            var msg = $"Erro ao validar xml contra Schema Xsd.\n{args.Message}";
            throw new FalhaValidacaoSchemaException(msg);
        }

        #region Implementacoes

        public IRetConsStat Executar()
        {
            if (_servicoBase == null) throw new InvalidOperationException("Uma instância do serviço base é requerido");
            if (_emisorEmissorServicoConfig == null)
                throw new InvalidOperationException("Uma instância de configuração do emissor é requerido");
            //Obter endereços
            _urlServico = ObterUrlServico();
            _urlWsdlServico = ObterWsdlServico();
            //Obter dados
            var d1 = ObterDados();
            //Validar xml
            if (_emisorEmissorServicoConfig.ValidarSchema)
                ValidarSchema(d1);
            //Criar corpo SOAP
            var soapXml = ObterCorpoMensagemSoap(_urlWsdlServico, d1);
            var ws = _servicoBase.TransmitirMensagem(_urlServico, soapXml);
            ws.Wait();
            var resposta = ws.Result;

            //Obter Node
            var node = Utils.ObterNodeDeStringXml("retConsStatServ", resposta);
            var retorno1 = Utils.XmlStringParaClasse<retConsStatServ>(node);
            var xmlEnviado = Utils.ClasseParaXmlString(d1);
            _processadas++;
            if (StatusSefaz.ListarCodigo.All(n => n.Key != retorno1.cStat)) _rejeitadas++;
            var retorno2 = new RetConsStat(retorno1, node, _processadas, _rejeitadas, xmlEnviado, _urlServico, _urlWsdlServico,
                    NomeServico);
            //Salvar arquivo
            SalvarArquivo(retorno2);
            return retorno2;
        }

        #endregion
    }
}