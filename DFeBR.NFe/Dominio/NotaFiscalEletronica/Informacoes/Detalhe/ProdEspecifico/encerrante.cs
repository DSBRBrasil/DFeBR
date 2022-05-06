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
    public class encerrante
    {
        #region Propriedades

        /// <summary>
        ///     LA12 - Número de identificação do bico utilizado no abastecimento
        /// </summary>
        public int nBico { get; set; }

        /// <summary>
        ///     LA13 - Número de identificação da bomba ao qual o bico está interligado
        /// </summary>
        public int? nBomba { get; set; }

        /// <summary>
        ///     LA14 - Número de identificação do tanque ao qual o bico está interligado
        /// </summary>
        public int nTanque { get; set; }

        /// <summary>
        ///     LA15 - Valor do Encerrante no início do abastecimento
        /// </summary>
        public decimal vEncIni
        {
            get => _vEncIni;
            set => _vEncIni = value.Arredondar(3);
        }

        /// <summary>
        ///     LA16 - Valor do Encerrante no final do abastecimento
        /// </summary>
        public decimal vEncFin
        {
            get => _vEncFin;
            set => _vEncFin = value.Arredondar(3);
        }

        #endregion

        public bool ShouldSerializenBomba()
        {
            return nBomba.HasValue;
        }

        private decimal _vEncFin;
        private decimal _vEncIni;
    }
}