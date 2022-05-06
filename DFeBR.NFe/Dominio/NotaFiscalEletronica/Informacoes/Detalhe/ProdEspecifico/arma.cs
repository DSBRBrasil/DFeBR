// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.ProdEspecifico
{
    public class arma : ProdutoEspecifico
    {
        #region Propriedades

        /// <summary>
        ///     L02 - Indicador do tipo de arma de fogo
        /// </summary>
        public TipoArma tpArma { get; set; }

        /// <summary>
        ///     L03 - Número de série da arma
        /// </summary>
        public string nSerie { get; set; }

        /// <summary>
        ///     L04 - Número de série do cano
        /// </summary>
        public string nCano { get; set; }

        /// <summary>
        ///     L05 - Descrição completa da arma, compreendendo: calibre, marca, capacidade, tipo de funcionamento, comprimento e
        ///     demais elementos que permitam a sua perfeita identificação.
        /// </summary>
        public string descr { get; set; }

        #endregion
    }
}