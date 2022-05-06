// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


namespace DFeBR.EmissorNFe.Servicos.Interfaces
{
    public interface IRetBasico
    {
        #region Propriedades

        /// <summary>
        ///     String Xml contendo dados de retorno
        /// </summary>
        string XmlRecebido { get; set; }

        /// <summary>
        ///     Quantidade de solicitações processadas
        /// </summary>
        int Processadas { get; set; }

        /// <summary>
        ///     Quantidade de solicitações rejeitadas ou denegadas
        /// </summary>
        int Rejeitadas { get; set; }

        /// <summary>
        ///     String XML contendo dados enviados
        /// </summary>
        string XmlEnviado { get; set; }

        /// <summary>
        ///     Url do serviço
        /// </summary>
        string UrlServico { get; set; }

        /// <summary>
        ///     WSDL
        /// </summary>
        string Wsdl { get; set; }

        /// <summary>
        ///     Nome do serviço
        /// </summary>
        string Servico { get; set; }

        #endregion
    }
}