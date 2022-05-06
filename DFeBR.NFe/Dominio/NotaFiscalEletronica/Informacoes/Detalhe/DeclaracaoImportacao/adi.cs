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

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.DeclaracaoImportacao
{
    public class adi
    {
        #region Propriedades

        /// <summary>
        ///     I26 - Numero da Adição
        /// </summary>
        public int nAdicao { get; set; }

        /// <summary>
        ///     I27 - Numero sequencial do item dentro da Adição
        /// </summary>
        public int nSeqAdic { get; set; }

        /// <summary>
        ///     I28 - Código do fabricante estrangeiro
        /// </summary>
        public string cFabricante { get; set; }

        /// <summary>
        ///     I29 - Valor do desconto do item da DI – Adição
        /// </summary>
        public decimal? vDescDI
        {
            get => _vDescDi.Arredondar(2);
            set => _vDescDi = value.Arredondar(2);
        }

        /// <summary>
        ///     I29a - Número do ato concessório de Drawback
        /// </summary>
        public string nDraw { get; set; }

        #endregion

        public bool ShouldSerializevDescDI()
        {
            return vDescDI.HasValue;
        }

        private decimal? _vDescDi;
    }
}