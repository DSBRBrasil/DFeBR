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
    public class exporta
    {
        #region Propriedades

        /// <summary>
        ///     ZA02 - Sigla da UF de Embarque ou de transposição de fronteira
        /// </summary>
        public string UFSaidaPais { get; set; }

        /// <summary>
        ///     ZA03 - Descrição do Local de Embarque ou de transposição de fronteira
        /// </summary>
        public string xLocExporta { get; set; }

        /// <summary>
        ///     ZA04 - Descrição do local de despacho
        /// </summary>
        public string xLocDespacho { get; set; }

        #endregion
    }
}