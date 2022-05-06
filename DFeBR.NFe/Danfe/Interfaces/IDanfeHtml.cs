// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using DFeBR.EmissorNFe.Danfe.Entidades;

#endregion

namespace DFeBR.EmissorNFe.Danfe.Interfaces
{
    public interface IDanfeHtml
    {
        #region Propriedades

        /// <summary>
        ///     Tipo da DANFE
        /// </summary>
        string TipoDanfe { get; }

        #endregion

        /// <summary>
        ///     Obter Danfe
        /// </summary>
        /// <returns></returns>
        Documento ObterDocHtml();
    }
}