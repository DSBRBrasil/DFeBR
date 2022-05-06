// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Identificacao
{
    public class refECF
    {
        #region Propriedades

        /// <summary>
        ///     BA21 - Modelo do Documento Fiscal
        /// </summary>
        public string mod { get; set; }

        /// <summary>
        ///     BA22 - Número de ordem sequencial do ECF
        /// </summary>
        public int nECF { get; set; }

        /// <summary>
        ///     BA23 - Número do Contador de Ordem de Operação - COO
        /// </summary>
        public int nCOO { get; set; }

        #endregion
    }
}