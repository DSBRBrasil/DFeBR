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

#endregion

namespace DFeBR.EmissorNFe.Utilidade.Exceptions
{
    #region

    #endregion

    /// <summary>
    ///     Utilize essa classe para determinar se houve problemas com a internet, durante o envio dos dados para um webservice
    ///     da NFe
    /// </summary>
    public class FalhaComunicacaoException : Exception
    {
        #region Construtor

        /// <summary>
        ///     Houve problemas com a internet, durante o envio dos dados para um webservice da NFe
        /// </summary>
        /// <param name="servico">Serviço que gerou o erro</param>
        /// <param name="ex">Exception</param>
        public FalhaComunicacaoException(string servico, Exception ex) : base($"Sem comunicação com o serviço {servico} Razão:{ex.Message}",
                ex)
        {
        }

        #endregion
    }
}