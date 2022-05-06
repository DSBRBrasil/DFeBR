// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Recepcao.Retorno;
using DFeBR.EmissorNFe.Servicos.Interfaces;

#endregion

namespace DFeBR.EmissorNFe.Servicos.Retornos
{
    public class RetConsRec : IRetConsRec
    {
        #region Propriedades

        public retConsReciNFe Retorno { get; set; }

        /// <summary>
        ///     Url do serviço
        /// </summary>
        public string UrlServico { get; set; }

        /// <summary>
        ///     WSDL
        /// </summary>
        public string Wsdl { get; set; }

        /// <summary>
        ///     Nome do serviço
        /// </summary>
        public string Servico { get; set; }

        /// <summary>
        ///     String Xml contendo dados de retorno
        /// </summary>
        public string XmlRecebido { get; set; }

        /// <summary>
        ///     Quantidade de solicitações processadas
        /// </summary>
        public int Processadas { get; set; }

        /// <summary>
        ///     Quantidade de solicitações rejeitadas ou denegadas
        /// </summary>
        public int Rejeitadas { get; set; }

        /// <summary>
        ///     String XML contendo dados enviados
        /// </summary>
        public string XmlEnviado { get; set; }

        #endregion

        #region Construtor

        public RetConsRec()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public RetConsRec(retConsReciNFe retorno, string xmlRecebido, int processadas, int rejeitadas, string xmlEnviado, string urlServico,
                string wsdl, string servico)
        {
            Retorno = retorno;
            XmlRecebido = xmlRecebido;
            Processadas = processadas;
            Rejeitadas = rejeitadas;
            XmlEnviado = xmlEnviado;
            UrlServico = urlServico;
            Wsdl = wsdl;
            Servico = servico;
        }

        #endregion
    }
}