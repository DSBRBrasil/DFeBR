// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Autorizacao;

#endregion

namespace DFeBR.EmissorNFe.Servicos.Interfaces
{
    public interface IRetAutorz : IRetBasico
    {
        #region Propriedades

        /// <summary>
        ///     Emissor em ambiente de contigência
        /// </summary>
        bool Contigencia { get; }

        /// <summary>
        ///     Retorno
        /// </summary>
        retEnviNFe Retorno { get; set; }

        #endregion
    }
}