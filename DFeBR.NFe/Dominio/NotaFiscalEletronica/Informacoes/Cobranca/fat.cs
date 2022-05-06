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

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Cobranca
{
    public class fat
    {
        #region Propriedades

        /// <summary>
        ///     Y03 - Número da Fatura
        /// </summary>
        public string nFat { get; set; }

        /// <summary>
        ///     Y04 - Valor Original da Fatura
        /// </summary>
        public decimal? vOrig
        {
            get => _vOrig.Arredondar(2);
            set => _vOrig = value.Arredondar(2);
        }

        /// <summary>
        ///     Y05 - Valor do desconto
        /// </summary>
        public decimal? vDesc
        {
            get => _vDesc.Arredondar(2);
            set => _vDesc = value.Arredondar(2);
        }

        /// <summary>
        ///     Y06 - Valor Líquido da Fatura
        /// </summary>
        public decimal? vLiq
        {
            get => _vLiq.Arredondar(2);
            set => _vLiq = value.Arredondar(2);
        }

        #endregion

        public bool ShouldSerializevOrig()
        {
            return vOrig.HasValue;
        }

        public bool ShouldSerializevDesc()
        {
            return vDesc.HasValue;
        }

        public bool ShouldSerializevLiq()
        {
            return vLiq.HasValue;
        }

        private decimal? _vDesc;
        private decimal? _vLiq;
        private decimal? _vOrig;
    }
}