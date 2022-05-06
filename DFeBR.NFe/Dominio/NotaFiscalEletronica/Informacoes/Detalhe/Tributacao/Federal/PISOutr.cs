﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal
{
    public class PISOutr : PISBasico
    {
        #region Propriedades

        /// <summary>
        ///     Q06 - Código de Situação Tributária do PIS
        /// </summary>
        public CSTPIS CST { get; set; }

        /// <summary>
        ///     Q07 - Valor da Base de Cálculo do PIS
        /// </summary>
        public decimal? vBC
        {
            get => _vBc.Arredondar(2);
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     Q08 - Alíquota do PIS (em percentual)
        /// </summary>
        public decimal? pPIS
        {
            get => _pPis.Arredondar(4);
            set => _pPis = value.Arredondar(4);
        }

        /// <summary>
        ///     Q10 - Quantidade Vendida
        /// </summary>
        public decimal? qBCProd
        {
            get => _qBcProd.Arredondar(4);
            set => _qBcProd = value.Arredondar(4);
        }

        /// <summary>
        ///     Q11 - Alíquota do PIS (em reais)
        /// </summary>
        public decimal? vAliqProd
        {
            get => _vAliqProd.Arredondar(4);
            set => _vAliqProd = value.Arredondar(4);
        }

        /// <summary>
        ///     Q09 - Valor do PIS
        /// </summary>
        public decimal? vPIS
        {
            get => _vPis.Arredondar(2);
            set => _vPis = value.Arredondar(2);
        }

        #endregion

        public bool ShouldSerializevBC()
        {
            return vBC.HasValue;
        }

        public bool ShouldSerializepPIS()
        {
            return pPIS.HasValue;
        }

        public bool ShouldSerializeqBCProd()
        {
            return qBCProd.HasValue;
        }

        public bool ShouldSerializevAliqProd()
        {
            return vAliqProd.HasValue;
        }

        public bool ShouldSerializevPIS()
        {
            return vPIS.HasValue;
        }

        private decimal? _pPis;
        private decimal? _qBcProd;
        private decimal? _vAliqProd;
        private decimal? _vBc;
        private decimal? _vPis;
    }
}