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

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.ProdEspecifico
{
    public class comb : ProdutoEspecifico
    {
        #region Propriedades

        /// <summary>
        ///     LA02 - Código de produto da ANP
        ///     Versão 3.00
        ///     Versão 4.00
        /// </summary>
        public string cProdANP { get; set; }

        /// <summary>
        ///     LA03 - Percentual de Gás Natural para o produto GLP (cProdANP=210203001)
        ///     Versão 3.00
        /// </summary>
        public decimal? pMixGN
        {
            get => _pMixGn.Arredondar(4);
            set => _pMixGn = value.Arredondar(4);
        }

        public bool pMixGNSpecified => pMixGN.HasValue;

        /// <summary>
        ///     LA03 - Descrição do produto conforme ANP
        ///     Versão 4.00
        /// </summary>
        public string descANP { get; set; }

        /// <summary>
        ///     LA03a - Percentual do GLP derivado do petróleo no produto GLP (cProdANP=210203001)
        ///     Versão 4.00
        /// </summary>
        public decimal? pGLP
        {
            get => _pGlp.Arredondar(4);
            set => _pGlp = value.Arredondar(4);
        }

        public bool pGLPSpecified => pGLP.HasValue;

        /// <summary>
        ///     LA03b - Percentual de Gás Natural Nacional – GLGNn para o produto GLP (cProdANP= 210203001)
        ///     Versão 4.00
        /// </summary>
        public decimal? pGNn
        {
            get => _pGNn.Arredondar(4);
            set => _pGNn = value.Arredondar(4);
        }

        public bool pGNnSpecified => pGNn.HasValue;

        /// <summary>
        ///     LA03c - Percentual de Gás Natural Importado – GLGNi para o produto GLP (cProdANP= 210203001)
        ///     Versão 4.00
        /// </summary>
        public decimal? pGNi
        {
            get => _pGNi.Arredondar(4);
            set => _pGNi = value.Arredondar(4);
        }

        public bool pGNiSpecified => pGNi.HasValue;

        /// <summary>
        ///     LA03d - Valor de partida (cProdANP=210203001)
        ///     Versão 4.00
        /// </summary>
        public decimal? vPart
        {
            get => _vPart.Arredondar(2);
            set => _vPart = value.Arredondar(2);
        }

        public bool vPartSpecified => vPart.HasValue;

        /// <summary>
        ///     LA04 - Código de autorização / registro do CODIF
        /// </summary>
        public string CODIF { get; set; }

        /// <summary>
        ///     LA05 - Quantidade de combustível faturada à temperatura ambiente
        /// </summary>
        public decimal? qTemp
        {
            get => _qTemp.Arredondar(4);
            set => _qTemp = value.Arredondar(4);
        }

        public bool qTempSpecified => qTemp.HasValue;

        /// <summary>
        ///     LA06 - Sigla da UF de consumo
        /// </summary>
        public string UFCons { get; set; }

        /// <summary>
        ///     LA07 - Informações da CIDE
        /// </summary>
        public CIDE CIDE { get; set; }

        /// <summary>
        ///     LA11 - Informações do grupo de “encerrante”
        /// </summary>
        public encerrante encerrante { get; set; }

        #endregion

        public bool ShouldSerializepMixGN()
        {
            return pMixGN.HasValue;
        }

        public bool ShouldSerializeqTemp()
        {
            return qTemp.HasValue;
        }

        private decimal? _pGlp;
        private decimal? _pGNi;
        private decimal? _pGNn;
        private decimal? _pMixGn;
        private decimal? _qTemp;
        private decimal? _vPart;
    }
}