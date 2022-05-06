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
    public class ICMS51 : ICMSBasico
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
        ///     N13 - Modalidade de determinação da BC do ICMS
        /// </summary>
        [XmlElement(Order = 3)]
        public DeterminacaoBaseIcms? modBC { get; set; }

        /// <summary>
        ///     N14 - Percentual de redução da BC
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal? pRedBC
        {
            get => _pRedBc.Arredondar(4);
            set => _pRedBc = value.Arredondar(4);
        }

        /// <summary>
        ///     N15 - Valor da BC do ICMS
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? vBC
        {
            get => _vBc.Arredondar(2);
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     N16 - Alíquota do imposto
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal? pICMS
        {
            get => _pIcms.Arredondar(4);
            set => _pIcms = value.Arredondar(4);
        }

        /// <summary>
        ///     N16a - Valor do ICMS da Operação
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? vICMSOp
        {
            get => _vIcmsOp.Arredondar(2);
            set => _vIcmsOp = value.Arredondar(2);
        }

        /// <summary>
        ///     N16b - Percentual do diferimento
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? pDif
        {
            get => _pDif.Arredondar(2);
            set => _pDif = value.Arredondar(2);
        }

        /// <summary>
        ///     N16c - Valor do ICMS diferido
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? vICMSDif
        {
            get => _vIcmsDif.Arredondar(2);
            set => _vIcmsDif = value.Arredondar(2);
        }

        /// <summary>
        ///     N17 - Valor do ICMS
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? vICMS
        {
            get => _vIcms.Arredondar(2);
            set => _vIcms = value.Arredondar(2);
        }

        /// <summary>
        ///     N17a - Valor da Base de Cálculo do FCP
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? vBCFCP
        {
            get => _vBcfcp.Arredondar(2);
            set => _vBcfcp = value.Arredondar(2);
        }

        public bool vBCFCPSpecified => vBCFCP.HasValue;

        /// <summary>
        ///     N17b - Percentual do Fundo de Combate à Pobreza (FCP)
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal? pFCP
        {
            get => _pFcp.Arredondar(4);
            set => _pFcp = value.Arredondar(4);
        }

        public bool pFCPSpecified => pFCP.HasValue;

        /// <summary>
        ///     N17c - Valor do Fundo de Combate à Pobreza (FCP)
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal? vFCP
        {
            get => _vFcp.Arredondar(2);
            set => _vFcp = value.Arredondar(2);
        }

        public bool vFCPSpecified => vFCP.HasValue;

        #endregion

        public bool ShouldSerializemodBC()
        {
            return modBC.HasValue;
        }

        public bool ShouldSerializepRedBC()
        {
            return pRedBC.HasValue;
        }

        public bool ShouldSerializevBC()
        {
            return vBC.HasValue;
        }

        public bool ShouldSerializepICMS()
        {
            return pICMS.HasValue;
        }

        public bool ShouldSerializevICMSOp()
        {
            return vICMSOp.HasValue;
        }

        public bool ShouldSerializepDif()
        {
            return pDif.HasValue;
        }

        public bool ShouldSerializevICMSDif()
        {
            return vICMSDif.HasValue;
        }

        public bool ShouldSerializevICMS()
        {
            return vICMS.HasValue;
        }

        private decimal? _pDif;
        private decimal? _pFcp;
        private decimal? _pIcms;
        private decimal? _pRedBc;
        private decimal? _vBc;
        private decimal? _vBcfcp;
        private decimal? _vFcp;
        private decimal? _vIcms;
        private decimal? _vIcmsDif;
        private decimal? _vIcmsOp;
    }
}