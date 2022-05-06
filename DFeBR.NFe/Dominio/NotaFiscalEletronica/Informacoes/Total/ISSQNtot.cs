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

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Total
{
    public class ISSQNtot
    {
        #region Propriedades

        /// <summary>
        ///     W18 - Valor total dos Serviços sob não-incidência ou não tributados pelo ICMS
        /// </summary>
        public decimal? vServ
        {
            get => _vServ.Arredondar(2);
            set => _vServ = value.Arredondar(2);
        }

        /// <summary>
        ///     W19 - Valor total Base de Cálculo do ISS
        /// </summary>
        public decimal? vBC
        {
            get => _vBc.Arredondar(2);
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     W20 - Valor total do ISS
        /// </summary>
        public decimal? vISS
        {
            get => _vIss.Arredondar(2);
            set => _vIss = value.Arredondar(2);
        }

        /// <summary>
        ///     W21 - Valor total do PIS sobre serviços
        /// </summary>
        public decimal? vPIS
        {
            get => _vPis.Arredondar(2);
            set => _vPis = value.Arredondar(2);
        }

        /// <summary>
        ///     W22 - Valor total da COFINS sobre serviços
        /// </summary>
        public decimal? vCOFINS
        {
            get => _vCofins.Arredondar(2);
            set => _vCofins = value.Arredondar(2);
        }

        /// <summary>
        ///     W22a - Data da prestação do serviço
        /// </summary>
        public string dCompet { get; set; }

        /// <summary>
        ///     W22b - Valor total dedução para redução da Base de Cálculo
        /// </summary>
        public decimal? vDeducao
        {
            get => _vDeducao.Arredondar(2);
            set => _vDeducao = value.Arredondar(2);
        }

        /// <summary>
        ///     W22c - Valor total outras retenções
        /// </summary>
        public decimal? vOutro
        {
            get => _vOutro.Arredondar(2);
            set => _vOutro = value.Arredondar(2);
        }

        /// <summary>
        ///     W22d - Valor total desconto incondicionado
        /// </summary>
        public decimal? vDescIncond
        {
            get => _vDescIncond.Arredondar(2);
            set => _vDescIncond = value.Arredondar(2);
        }

        /// <summary>
        ///     W22e - Valor total desconto condicionado
        /// </summary>
        public decimal? vDescCond
        {
            get => _vDescCond.Arredondar(2);
            set => _vDescCond = value.Arredondar(2);
        }

        /// <summary>
        ///     W22f - Valor total retenção ISS
        /// </summary>
        public decimal? vISSRet
        {
            get => _vIssRet.Arredondar(2);
            set => _vIssRet = value.Arredondar(2);
        }

        /// <summary>
        ///     W22g - Código do Regime Especial de Tributação
        /// </summary>
        public RegTribISSQN? cRegTrib { get; set; }

        #endregion

        public bool ShouldSerializevServ()
        {
            return vServ.HasValue;
        }

        public bool ShouldSerializevBC()
        {
            return vBC.HasValue;
        }

        public bool ShouldSerializevISS()
        {
            return vISS.HasValue;
        }

        public bool ShouldSerializevPIS()
        {
            return vPIS.HasValue;
        }

        public bool ShouldSerializevCOFINS()
        {
            return vCOFINS.HasValue;
        }

        public bool ShouldSerializevDeducao()
        {
            return vDeducao.HasValue;
        }

        public bool ShouldSerializevOutro()
        {
            return vOutro.HasValue;
        }

        public bool ShouldSerializevDescIncond()
        {
            return vDescIncond.HasValue;
        }

        public bool ShouldSerializevDescCond()
        {
            return vDescCond.HasValue;
        }

        public bool ShouldSerializevISSRet()
        {
            return vISSRet.HasValue;
        }

        public bool ShouldSerializecRegTrib()
        {
            return cRegTrib.HasValue;
        }

        private decimal? _vBc;
        private decimal? _vCofins;
        private decimal? _vDeducao;
        private decimal? _vDescCond;
        private decimal? _vDescIncond;
        private decimal? _vIss;
        private decimal? _vIssRet;
        private decimal? _vOutro;
        private decimal? _vPis;
        private decimal? _vServ;
    }
}