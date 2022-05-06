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
    public class COFINSAliq : COFINSBasico
    {
        #region Propriedades

        /// <summary>
        ///     S06 - Código de Situação Tributária da COFINS
        /// </summary>
        public CSTCOFINS CST { get; set; }

        /// <summary>
        ///     S07 - Valor da Base de Cálculo da COFINS
        /// </summary>
        public decimal vBC
        {
            get => _vBc;
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     S08 - Alíquota da COFINS (em percentual)
        /// </summary>
        public decimal pCOFINS
        {
            get => _pCofins;
            set => _pCofins = value.Arredondar(4);
        }

        /// <summary>
        ///     S09 - Valor da COFINS
        /// </summary>
        public decimal vCOFINS
        {
            get => _vCofins;
            set => _vCofins = value.Arredondar(2);
        }

        #endregion

        private decimal _pCofins;
        private decimal _vBc;
        private decimal _vCofins;
    }
}