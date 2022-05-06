// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System.Xml.Serialization;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Observacoes
{
    /// <summary>
    ///     <para>0=SEFAZ;</para>
    ///     <para>1=Justiça Federal;</para>
    ///     <para>2=Justiça Estadual;</para>
    ///     <para>3=Secex/RFB;</para>
    ///     <para>9=Outros</para>
    /// </summary>
    public enum IndicadorProcesso
    {
        [XmlEnum("0")] ipSEFAZ = 0,
        [XmlEnum("1")] ipJusticaFederal = 1,
        [XmlEnum("2")] ipJusticaEstadual = 2,
        [XmlEnum("3")] ipSecexRFB = 3,
        [XmlEnum("9")] ipOutros = 9
    }
}