// ===================================================================
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
    public class COFINSST : COFINSBasico
    {
        #region Propriedades

        /// <summary>
        ///     T02 - Valor da Base de Cálculo da COFINS
        /// </summary>
        public decimal? vBC
        {
            get => _vBc.Arredondar(2);
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     T03 - Alíquota da COFINS (em percentual)
        /// </summary>
        public decimal? pCOFINS
        {
            get => _pCofins.Arredondar(4);
            set => _pCofins = value.Arredondar(4);
        }

        /// <summary>
        ///     T04 - Quantidade Vendida
        /// </summary>
        public decimal? qBCProd
        {
            get => _qBcProd.Arredondar(4);
            set => _qBcProd = value.Arredondar(4);
        }

        /// <summary>
        ///     T05 - Alíquota da COFINS (em reais)
        /// </summary>
        public decimal? vAliqProd
        {
            get => _vAliqProd.Arredondar(4);
            set => _vAliqProd = value.Arredondar(4);
        }

        /// <summary>
        ///     T06 - Valor da COFINS
        /// </summary>
        public decimal? vCOFINS
        {
            get => _vCofins.Arredondar(2);
            set => _vCofins = value.Arredondar(2);
        }

        #endregion

        public bool ShouldSerializevBC()
        {
            return vBC.HasValue;
        }

        public bool ShouldSerializepCOFINS()
        {
            return pCOFINS.HasValue;
        }

        public bool ShouldSerializeqBCProd()
        {
            return qBCProd.HasValue;
        }

        public bool ShouldSerializevAliqProd()
        {
            return vAliqProd.HasValue;
        }

        public bool ShouldSerializevCOFINS()
        {
            return vCOFINS.HasValue;
        }

        private decimal? _pCofins;
        private decimal? _qBcProd;
        private decimal? _vAliqProd;
        private decimal? _vBc;
        private decimal? _vCofins;
    }
}