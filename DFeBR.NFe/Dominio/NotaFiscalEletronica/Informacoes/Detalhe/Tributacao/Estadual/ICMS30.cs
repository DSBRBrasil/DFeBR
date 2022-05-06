// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System.Xml.Serialization;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMS30 : ICMSBasico
    {
        #region Propriedades

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        [XmlElement(Order = 1)]
        public OrigemMercadoria orig { get; set; }

        /// <summary>
        ///     N12- Situação Tributária
        /// </summary>
        [XmlElement(Order = 2)]
        public Csticms CST { get; set; }

        /// <summary>
        ///     N18 - Modalidade de determinação da BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 3)]
        public DeterminacaoBaseIcmsSt modBCST { get; set; }

        /// <summary>
        ///     N19 - Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal? pMVAST
        {
            get => _pMvast.Arredondar(4);
            set => _pMvast = value.Arredondar(4);
        }

        /// <summary>
        ///     N20 - Percentual da Redução de BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? pRedBCST
        {
            get => _pRedBcst.Arredondar(4);
            set => _pRedBcst = value.Arredondar(4);
        }

        /// <summary>
        ///     N21 - Valor da BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal vBCST
        {
            get => _vBcst.Arredondar(2);
            set => _vBcst = value.Arredondar(2);
        }

        /// <summary>
        ///     N22 - Alíquota do imposto do ICMS ST
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal pICMSST
        {
            get => _pIcmsst.Arredondar(4);
            set => _pIcmsst = value.Arredondar(4);
        }

        /// <summary>
        ///     N23 - Valor do ICMS ST
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal vICMSST
        {
            get => _vIcmsst.Arredondar(2);
            set => _vIcmsst = value.Arredondar(2);
        }

        /// <summary>
        ///     N23a - Valor da Base de Cálculo do FCP retido por Substituição Tributária
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? vBCFCPST
        {
            get => _vBcfcpst.Arredondar(2);
            set => _vBcfcpst = value.Arredondar(2);
        }

        public bool vBCFCPSTSpecified => vBCFCPST.HasValue;

        /// <summary>
        ///     N23b - Percentual do FCP retido por Substituição Tributária
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? pFCPST
        {
            get => _pFcpst.Arredondar(4);
            set => _pFcpst = value.Arredondar(4);
        }

        public bool pFCPSTSpecified => pFCPST.HasValue;

        /// <summary>
        ///     N23d - Valor do FCP retido por Substituição Tributária
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? vFCPST { get; set; }

        public bool vFCPSTSpecified => vFCPST.HasValue;

        /// <summary>
        ///     N27a - Valor do ICMS desonerado
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal? vICMSDeson
        {
            get => _vIcmsDeson.Arredondar(2);
            set => _vIcmsDeson = value.Arredondar(2);
        }

        /// <summary>
        ///     N28 - Motivo da desoneração do ICMS
        /// </summary>
        [XmlElement(Order = 13)]
        public MotivoDesoneracaoIcms? motDesICMS { get; set; }

        #endregion

        public bool ShouldSerializepMVAST()
        {
            return pMVAST.HasValue;
        }

        public bool ShouldSerializepRedBCST()
        {
            return pRedBCST.HasValue;
        }

        public bool ShouldSerializevICMSDeson()
        {
            return vICMSDeson.HasValue;
        }

        public bool ShouldSerializemotDesICMS()
        {
            return motDesICMS.HasValue;
        }

        private decimal? _pFcpst;
        private decimal _pIcmsst;
        private decimal? _pMvast;
        private decimal? _pRedBcst;
        private decimal? _vBcfcpst;
        private decimal _vBcst;
        private decimal? _vIcmsDeson;
        private decimal _vIcmsst;
    }
}