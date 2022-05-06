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
using DFeBR.EmissorNFe.Utilidade.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Pagamento
{
    public class detPag
    {
        #region Propriedades

        public IndicadorPagamentoDetalhePagamento? indPag { get; set; }

        public bool indPagSpecified => indPag.HasValue;

        /// <summary>
        ///     YA02 - Forma de pagamento
        /// </summary>
        public FormaPagamento tPag { get; set; }

        public decimal vPag
        {
            get => _vPag.Arredondar(2);
            set => _vPag = value.Arredondar(2);
        }

        public card card { get; set; }

        #endregion

        private decimal _vPag;
    }
}