// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes
{
    public class compra
    {
        #region Propriedades

        /// <summary>
        ///     ZB02 - Nota de Empenho
        /// </summary>
        public string xNEmp { get; set; }

        /// <summary>
        ///     ZB03 - Pedido
        /// </summary>
        public string xPed { get; set; }

        /// <summary>
        ///     ZB04 - Contrato
        /// </summary>
        public string xCont { get; set; }

        #endregion
    }
}