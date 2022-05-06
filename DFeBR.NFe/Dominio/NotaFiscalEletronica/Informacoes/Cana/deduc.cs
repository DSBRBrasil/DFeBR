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

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Cana
{
    public class deduc
    {
        #region Propriedades

        /// <summary>
        ///     ZC11 - Descrição da Dedução
        /// </summary>
        public string xDed { get; set; }

        /// <summary>
        ///     ZC12 - Valor da Dedução
        /// </summary>
        public decimal vDed
        {
            get => _vDed;
            set => _vDed = value.Arredondar(2);
        }

        /// <summary>
        ///     ZC13 - Valor dos Fornecimentos
        /// </summary>
        public decimal vFor
        {
            get => _vFor;
            set => _vFor = value.Arredondar(2);
        }

        /// <summary>
        ///     ZC14 - Valor Total da Dedução
        /// </summary>
        public decimal vTotDed
        {
            get => _vTotDed;
            set => _vTotDed = value.Arredondar(2);
        }

        /// <summary>
        ///     ZC15 - Valor Líquido dos Fornecimentos
        /// </summary>
        public decimal vLiqFor
        {
            get => _vLiqFor;
            set => _vLiqFor = value.Arredondar(2);
        }

        #endregion

        private decimal _vDed;
        private decimal _vFor;
        private decimal _vLiqFor;
        private decimal _vTotDed;
    }
}