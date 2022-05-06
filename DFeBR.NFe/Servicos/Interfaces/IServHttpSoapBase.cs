// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System.Threading.Tasks;

#endregion

namespace DFeBR.EmissorNFe.Servicos.Interfaces
{
    public interface IServHttpSoapBase
    {
        /// <summary>
        ///     Obter instancia do serviço web
        /// </summary>
        /// <param name="url">Endereco Url do serviço</param>
        /// <param name="soapXml">Mensagem body padrão SOAP e especificação SEFAZ</param>
        /// <returns></returns>
        //Task<string> TransmitirMensagem(string url, string soapXml);
        Task<string> TransmitirMensagem(string url, string soapXml);

         
    }
}