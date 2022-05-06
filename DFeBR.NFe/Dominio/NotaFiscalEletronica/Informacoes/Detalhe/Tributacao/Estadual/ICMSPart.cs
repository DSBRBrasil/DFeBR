﻿// ===================================================================
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
    public class ICMSPart : ICMSBasico
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
        public DeterminacaoBaseIcms modBC { get; set; }

        /// <summary>
        ///     N15 - Valor da BC do ICMS
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal vBC
        {
            get => _vBc;
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     N14 - Percentual de redução da BC
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal? pRedBC
        {
            get => _pRedBc.Arredondar(4);
            set => _pRedBc = value.Arredondar(4);
        }

        /// <summary>
        ///     N16 - Alíquota do imposto
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal pICMS
        {
            get => _pIcms;
            set => _pIcms = value.Arredondar(4);
        }

        /// <summary>
        ///     N17 - Valor do ICMS
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal vICMS
        {
            get => _vIcms;
            set => _vIcms = value.Arredondar(2);
        }

        /// <summary>
        ///     N18 - Modalidade de determinação da BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 8)]
        public DeterminacaoBaseIcmsSt modBCST { get; set; }

        /// <summary>
        ///     N19 - Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? pMVAST
        {
            get => _pMvast.Arredondar(4);
            set => _pMvast = value.Arredondar(4);
        }

        /// <summary>
        ///     N20 - Percentual da Redução de BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? pRedBCST
        {
            get => _pRedBcst.Arredondar(4);
            set => _pRedBcst = value.Arredondar(4);
        }

        /// <summary>
        ///     N21 - Valor da BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal vBCST
        {
            get => _vBcst;
            set => _vBcst = value.Arredondar(2);
        }

        /// <summary>
        ///     N22 - Alíquota do imposto do ICMS ST
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal pICMSST
        {
            get => _pIcmsst;
            set => _pIcmsst = value.Arredondar(4);
        }

        /// <summary>
        ///     N23 - Valor do ICMS ST
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal vICMSST
        {
            get => _vIcmsst;
            set => _vIcmsst = value.Arredondar(2);
        }

        /// <summary>
        ///     N25 - Percentual da BC operação própria
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal pBCOp
        {
            get => _pBcOp;
            set => _pBcOp = value.Arredondar(4);
        }

        /// <summary>
        ///     N24 - UF para qual é devido o ICMS ST
        /// </summary>
        [XmlElement(Order = 15)]
        public string UFST { get; set; }

        #endregion

        public bool ShouldSerializepRedBC()
        {
            return pRedBC.HasValue;
        }

        public bool ShouldSerializepMVAST()
        {
            return pMVAST.HasValue;
        }

        public bool ShouldSerializepRedBCST()
        {
            return pRedBCST.HasValue;
        }

        private decimal _pBcOp;
        private decimal _pIcms;
        private decimal _pIcmsst;
        private decimal? _pMvast;
        private decimal? _pRedBc;
        private decimal? _pRedBcst;
        private decimal _vBc;
        private decimal _vBcst;
        private decimal _vIcms;
        private decimal _vIcmsst;
    }
}