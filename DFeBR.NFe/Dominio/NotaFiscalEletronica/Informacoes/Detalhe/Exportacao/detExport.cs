// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Exportacao
{
    public class detExport
    {
        #region Propriedades

        /// <summary>
        ///     I51 - Número do ato concessório de Drawback
        /// </summary>
        public string nDraw { get; set; }

        /// <summary>
        ///     I52 - Grupo sobre exportação indireta
        /// </summary>
        public exportInd exportInd { get; set; }

        #endregion
    }
}