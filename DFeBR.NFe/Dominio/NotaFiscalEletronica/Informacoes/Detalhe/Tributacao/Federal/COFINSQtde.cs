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
    public class COFINSQtde : COFINSBasico
    {
        #region Propriedades

        /// <summary>
        ///     S06 - Código de Situação Tributária da COFINS
        /// </summary>
        public CSTCOFINS CST { get; set; }

        /// <summary>
        ///     S09 - Quantidade Vendida
        /// </summary>
        public decimal qBCProd
        {
            get => _qBcProd;
            set => _qBcProd = value.Arredondar(4);
        }

        /// <summary>
        ///     S10 - Alíquota da COFINS (em reais)
        /// </summary>
        public decimal vAliqProd
        {
            get => _vAliqProd;
            set => _vAliqProd = value.Arredondar(4);
        }

        /// <summary>
        ///     S11 - Valor da COFINS
        /// </summary>
        public decimal vCOFINS
        {
            get => _vCofins;
            set => _vCofins = value.Arredondar(2);
        }

        #endregion

        private decimal _qBcProd;
        private decimal _vAliqProd;
        private decimal _vCofins;
    }
}