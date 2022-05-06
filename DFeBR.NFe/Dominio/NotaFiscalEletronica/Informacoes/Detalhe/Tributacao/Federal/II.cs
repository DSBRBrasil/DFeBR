// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

#endregion

#region

using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal
{
    public class II
    {
        #region Propriedades

        /// <summary>
        ///     P02 - Valor BC do Imposto de Importação
        /// </summary>
        public decimal vBC
        {
            get => _vBc;
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     P03 - Valor despesas aduaneiras
        /// </summary>
        public decimal vDespAdu
        {
            get => _vDespAdu;
            set => _vDespAdu = value.Arredondar(2);
        }

        /// <summary>
        ///     P04 - Valor Imposto de Importação
        /// </summary>
        public decimal vII
        {
            get => _vIi;
            set => _vIi = value.Arredondar(2);
        }

        /// <summary>
        ///     P05 - Valor Imposto sobre Operações Financeiras
        /// </summary>
        public decimal vIOF
        {
            get => _vIof;
            set => _vIof = value.Arredondar(2);
        }

        #endregion

        private decimal _vBc;
        private decimal _vDespAdu;
        private decimal _vIi;
        private decimal _vIof;
    }
}