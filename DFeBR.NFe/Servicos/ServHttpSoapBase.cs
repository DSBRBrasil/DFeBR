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
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Configurar;
using DFeBR.EmissorNFe.Servicos.Interfaces;
using DFeBR.EmissorNFe.Utilidade;
using DFeBR.EmissorNFe.Utilidade.Exceptions;

#endregion

namespace DFeBR.EmissorNFe.Servicos
{
    /// <summary>
    ///     Disponibiliza uma Base para chamada aos serviços Web Soap
    /// </summary>
    internal class ServHttpSoapBase : IServHttpSoapBase
    {
        #region Construtor

        /// <summary>
        /// </summary>
        /// <param name="emissorServicoConfig">Configuração do emissor</param>
        /// <param name="certificado">Certificado Digital</param>
        /// <param name="nomeServivo">Nome do serviço</param>
        public ServHttpSoapBase(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, string nomeServivo)
        {
            _emissorServicoConfig = emissorServicoConfig ?? throw new ArgumentNullException(nameof(emissorServicoConfig));
            _certificado = certificado ?? throw new ArgumentNullException(nameof(certificado));
            _nomeServico = nomeServivo;
        }

        #endregion


        private HttpResponseMessage _response;
        private HttpClient _client;
        private readonly string _nomeServico;
        private readonly EmissorServicoConfig _emissorServicoConfig;
        private readonly X509Certificate2 _certificado;


        /// <summary>
        ///     Determina o alvo da requisição
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string ObterServicoAlvo(string url)
        {
            var reg1 = "[^/]+(?=(?:\\.[^.]+)?$)";
            var regex = new Regex(reg1);
            var nomeComExtensao = regex.Match(url);
            var t1 = "([^\\.]*)";
            var regex2 = new Regex(t1);
            var nome = regex2.Match(nomeComExtensao.Value);
            return nome.Value;
        }

        #region Implementacoes

        /// <summary>
        ///     Obter instancia do serviço web
        /// </summary>
        /// <param name="url">Endereco Url do serviço</param>
        /// <param name="soapXml">Mensagem body padrão SOAP e especificação SEFAZ</param>
        /// <returns></returns>
        //public async Task<string> TransmitirMensagem(string url, string soapXml)
        public async Task<string> TransmitirMensagem(string url, string soapXml)
        {
            string msgRetorno;
            var timeout = _emissorServicoConfig.TimeOut;
            var handler = _emissorServicoConfig.HttpClientHandler ?? new HttpClientHandler();
            var cts = new CancellationTokenSource();
            try
            {
                foreach (var clientCertificate in handler.ClientCertificates)
                    handler.ClientCertificates.Remove(clientCertificate);
                //Adicionar certificado digital
                handler.ClientCertificates.Add(_certificado);
                handler.ServerCertificateCustomValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                using (_client = new HttpClient(handler))
                {
                    _client.Timeout = new TimeSpan(0, 0, 0, 0, timeout);
                    var uri = new Uri(url);
                    var request = new HttpRequestMessage(HttpMethod.Post, uri);
                    request.Content = new StringContent(soapXml, Encoding.UTF8, "application/soap+xml");
                    request.Headers.Clear();
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/soap+xml");
                    request.Headers.Host = uri.Host;
                    var servico = ObterServicoAlvo(url); //Obter nome do serviço
                    request.Headers.Add("SOAPAction", $"{servico}");
                    _response = _client.SendAsync(request, cts.Token).Result;
                    if (!_response.IsSuccessStatusCode)
                        throw new FalhaConexaoException($"Não foi possível estabelecer uma conexão com o host {_response.StatusCode}");
                    var streamTask = _response.Content.ReadAsStreamAsync();
                    var stream = await streamTask;
                    var sr = new StreamReader(stream);
                    msgRetorno = sr.ReadToEnd();
                }

                return msgRetorno;
            }
            catch (Exception ex)
            {
                string msg;
                ex.Data["xml"] = soapXml;
                if (_response == null)
                {
                    msg = $"Falha de comunicação ao executar o serviço {_nomeServico}";
                    //Utils.TraceException(ex, msg);
                    throw new FalhaComunicacaoException(msg, ex);
                }

                if (_response.StatusCode == HttpStatusCode.RequestTimeout)
                {
                    msg = $"Falha de comunicação ao executar o serviço {_nomeServico}";
                    //Utils.TraceException(ex, msg);
                    throw new FalhaComunicacaoException(msg, ex);
                }

                msg = $"Falha ao executar o serviço {_nomeServico}";
                //Utils.TraceException(ex, msg);
                throw new FalhaCriacaoServicoWebException(msg, ex);
            }
        }

        

        #endregion
         
    }
}