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
    ///     Utilize essa classe para determinar se houve erros de validação de schema XSD
    ///     Na biblioteca, são realizadas validações de schema XSD
    ///     <para>
    ///         1 - No consumo de qualquer serviço, o pacote a ser enviado para a SEFAZ é validado, para garantir que está de
    ///         acordo com a estrutura esperada
    ///     </para>
    ///     <para>
    ///         2 - No método de extensão <see cref="ExtNFe.Valida" />, responsável por validar, contra o schema, um objeto
    ///         NFe
    ///     </para>
    /// </summary>
    public class FalhaValidacaoSchemaException : Exception
    {
        #region Construtor

        /// <summary>
        ///     Houve erros de validação de schema XSD
        /// </summary>
        /// <param name="message"></param>
        public FalhaValidacaoSchemaException(string message) : base(string.Format("Erros na validação:\n {0}", message))
        {
        }

        #endregion
    }
}