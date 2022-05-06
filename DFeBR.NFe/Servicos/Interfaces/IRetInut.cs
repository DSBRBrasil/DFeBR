// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Inutilizacao;

#endregion

namespace DFeBR.EmissorNFe.Servicos.Interfaces
{
    public interface IRetInut : IRetBasico
    {
        #region Propriedades

        /// <summary>
        ///     Retorno
        /// </summary>
        retInutNFe Retorno { get; set; }

        #endregion
    }
}