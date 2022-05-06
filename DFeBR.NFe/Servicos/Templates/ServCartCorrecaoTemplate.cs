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
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Evento;
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
    /// Template de Carta de Correção de NFe
    /// </summary>
    public abstract class ServCartCorrecaoTemplate : IServCartaCorrecaoTemplate
    {
        #region Variaveis Globais

        /// <summary>
        ///     Quantidade de solicitações processadas
        /// </summary>
        private static int _processadas;

        /// <summary>
        ///     Quantidade de solicitações rejeitadas ou denegadas
        /// </summary>
        private static int _rejeitadas;

        #endregion

        #region Propriedades

        /// <summary>
        ///     Nome do serviço
        /// </summary>
        public string NomeServico => "Carta de Correção NFe";

        #endregion

        #region Construtor

        protected ServCartCorrecaoTemplate(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, int idlote,
                ICollection<EventoBuilder> eventoBuilder, VersaoServico versao, ModeloDocumento modelo = ModeloDocumento.NFe)
        {
            _certificadoDigital = certificado ?? throw new ArgumentNullException(nameof(certificado));
            _emisorEmissorServicoConfig = emissorServicoConfig ?? throw new ArgumentNullException(nameof(emissorServicoConfig));
            _servicoBase = new ServHttpSoapBase(emissorServicoConfig, certificado, NomeServico);
            _versao = versao;
            _modelo = modelo;
            _idlote = idlote;
            _eventosBuilder = eventoBuilder;
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
        protected virtual string ObterCorpoMensagemSoap(string urlWsdl, envEvento entity)
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
        ///     Certificado Digital
        /// </summary>
        private readonly X509Certificate2 _certificadoDigital;

        private readonly ICollection<EventoBuilder> _eventosBuilder;

        /// <summary>
        ///     Serviço Base
        /// </summary>
        private readonly IServHttpSoapBase _servicoBase;

        /// <summary>
        ///     Url do serviço
        /// </summary>
        private string _urlServico;

        /// <summary>
        ///     Url WSDL do serviço
        /// </summary>
        private string _urlWsdlServico;

        /// <summary>
        ///     Dados de configuração do emissor
        /// </summary>
        private readonly EmissorServicoConfig _emisorEmissorServicoConfig;

        /// <summary>
        ///     Número do Lote
        /// </summary>
        private readonly int _idlote;


        /// <summary>
        ///     Modelo do documento
        /// </summary>
        private readonly ModeloDocumento _modelo;

        /// <summary>
        ///     Versão da NFe
        /// </summary>
        private readonly VersaoServico _versao;

        /// <summary>
        ///     Salvar arquivo Xml
        /// </summary>
        private void SalvarResposta(IRetRecepEvento entity)
        {
          
            if (!_emisorEmissorServicoConfig.SalvarArquivoRetorno) return;
            //SalvarArquivo 
            if (string.IsNullOrWhiteSpace(_emisorEmissorServicoConfig.DiretorioArquivoRetornoXml))
                throw new InvalidOperationException("Informe um diretório válido.");
            var nomeArq = $"{_idlote}--eve.xml";
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
                            ? _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsNFe.Homologacao.RecebeEvento
                            : _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsNFe.Producao.RecebeEvento;
                    return url;
                case ModeloDocumento.NfCe:
                    var url1 = _emisorEmissorServicoConfig.Ambiente == TipoAmbiente.Homologacao
                            ? _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsNFce.Homologacao.RecebeEvento
                            : _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsNFce.Producao.RecebeEvento;
                    return url1;
                default:
                    throw new ArgumentOutOfRangeException("Modelo de documento não suportado para o serviço");
            }
        }

        private string ObterWsdlServico()
        {
            return _emisorEmissorServicoConfig.ConfigEnderecoServico.UrlsWsdl.RecebeEvento;
        }

        /// <summary>
        ///     Obter Dados
        /// </summary>
        /// <returns></returns>
        private envEvento ObterDados()
        {
            var lstEventos = new List<evento>();
            int numeroEvento = 110110;

            foreach (var item in _eventosBuilder)
                lstEventos.Add(new evento
                {
                        versao = _versao.ObterVersaoServico(),
                        infEvento = new infEventoEnv
                        {
                                CPF = item.Cpfcnpj.Length == 11 ? item.Cpfcnpj : null,
                                CNPJ = item.Cpfcnpj.Length == 14 ? item.Cpfcnpj : null,
                                cOrgao = _emisorEmissorServicoConfig.Estado,
                                tpAmb = _emisorEmissorServicoConfig.Ambiente,
                                chNFe = item.ChaveNFe,
                                dhEvento =  DateTime.UtcNow, 
                                tpEvento = numeroEvento, //Codigo do evento de carta de correção
                                nSeqEvento = item.SeqEvento,
                                verEvento = _versao.ObterVersaoServico(),
                               
                                
                                detEvento = new detEvento
                                {
                                        versao = _versao.ObterVersaoServico(),
                                        xCorrecao = item.Justificativa, 
                                        xJust = null,
                                        descEvento = "Carta de Correção",
                                        xCondUso = "A Carta de Correção é disciplinada pelo § 1º-A do art. 7º do Convênio S/N, de 15 de dezembro de 1970 e pode ser utilizada para regularização de erro ocorrido na emissão de documento fiscal, desde que o erro não esteja relacionado com: I - as variáveis que determinam o valor do imposto tais como: base de cálculo, alíquota, diferença de preço, quantidade, valor da operação ou da prestação; II - a correção de dados cadastrais que implique mudança do remetente ou do destinatário; III - a data de emissão ou de saída."
                                       
                                        
                                },
                                Id = "ID" + numeroEvento + item.ChaveNFe + item.SeqEvento.ToString().PadLeft(2, '0')
                                
                        }
                });
            var eventos = new envEvento {versao = _versao.ObterVersaoServico(), evento = lstEventos, idLote = _idlote};
            return eventos;
        }


        /// <summary>
        ///     Lista de schemas relativos ao serviço
        /// </summary>
        /// <returns></returns>
        private ICollection<string> ObterListaNomeSchemas()
        {
            var list = new List<string>();
            var arqs = _emisorEmissorServicoConfig.ConfigEnderecoServico.Schemas.CartaCorrecao.ToList();  
            arqs.ForEach(n => { list.Add(n); });
            return arqs;
        }

        private void ValidarSchema(envEvento entity)
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

        /// <summary>
        ///     Assinar
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private void Assinar(evento entity)
        {
            try
            {
                if (entity.infEvento.Id == null)
                    throw new Exception("Não é possível assinar um objeto evento sem sua respectiva Id!");
                var assinatura = AssinaturaDigital.AssinarNFe(entity, entity.infEvento.Id, _certificadoDigital);
                entity.Signature = assinatura;
            }
            catch (Exception ex)
            {
                Utils.TraceException(ex, "Erro ao assinar arquivo Xml");
                throw new FalhaAssinaturaException("Erro ao assinar arquivo Xml", ex);
            }
        }

        /// <summary>
        ///     Salvar arquivo Xml
        /// </summary>
        private void SalvarPedido(envEvento entity)
        {
            if (!_emisorEmissorServicoConfig.SalvarArquivoRetorno) return;
            //SalvarArquivo 
            if (string.IsNullOrWhiteSpace(_emisorEmissorServicoConfig.DiretorioArquivoRetornoXml))
                throw new InvalidOperationException("Informe um diretório válido.");
            var nomeArq = $"{_idlote}-ped-eve.xml";
            var caminho = Path.Combine(_emisorEmissorServicoConfig.DiretorioArquivoRetornoXml, "Carta de Correcao", "Enviados");
            var xml = Utils.ClasseParaXmlString(entity);
            Utils.EscreverArquivo(caminho, nomeArq, xml);
        }

        #region Implementacoes

        /// <summary>
        ///     Executar
        /// </summary>
        /// <returns></returns>
        public IRetRecepEvento Executar()
        {
             
            var d1 = ProcessarXml();

            SalvarPedido(d1);
            var soapXml = ObterCorpoMensagemSoap(_urlWsdlServico, d1);
            var ws = _servicoBase.TransmitirMensagem(_urlServico, soapXml);
            ws.Wait();
            var resposta = ws.Result;

            //Obter Node
            var node = Utils.ObterNodeDeStringXml("retEnvEvento", resposta);
            var retorno1 = Utils.XmlStringParaClasse<retEnvEvento>(node);
            var xmlEnviado = Utils.ClasseParaXmlString(d1);
            _processadas++;
            if (retorno1.retEvento.Any(n => n.infEvento == null)) _rejeitadas++;
            if (retorno1.retEvento.Any(n => n.infEvento != null))
                if (StatusSefaz.ListarCodigo.All(n => retorno1.retEvento.All(k => k.infEvento.cStat != n.Key)))
                    _rejeitadas++;
            var retorno2 = new RetRecepEvento(retorno1, node, _processadas, _rejeitadas, xmlEnviado, _urlServico, _urlWsdlServico,
                    NomeServico);

            //Salvar arquivo
            SalvarResposta(retorno2);
            return retorno2;
            
        }

        /// <summary>
        ///     Obtem o XML Completo
        /// </summary>
        /// <returns></returns>
        private envEvento ProcessarXml()
        {
            if (_servicoBase == null) throw new InvalidOperationException("Uma instância do serviço base é requerido");
            if (_emisorEmissorServicoConfig == null)
                throw new InvalidOperationException("Uma instância de configuração do emissor é requerido");
            _urlServico = ObterUrlServico();
            _urlWsdlServico = ObterWsdlServico();
            var d1 = ObterDados();
            //Assinar
            d1.evento.ForEach(Assinar);

            if (_emisorEmissorServicoConfig.ValidarSchema)
                ValidarSchema(d1);

            return d1;

        }

        /// <summary>
            ///     Obter XML processado
            /// </summary>
            /// <returns></returns>
            public string ObterXmlFormatado()
        {
            var n1 = ProcessarXml();
            var str = Utils.ClasseParaXmlString(n1);
            return str;
        }

        #endregion
    }
}