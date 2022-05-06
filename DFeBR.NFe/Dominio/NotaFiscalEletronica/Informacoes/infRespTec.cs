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

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes
{
    public class infRespTec
    {
        #region Propriedades

        /// <summary>
        ///     ZD02 - CNPJ responsável pelo sistema emissor
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        ///     ZD04 - Nome da pessoa a ser contatada
        /// </summary>
        public string xContato { get; set; }

        /// <summary>
        ///     ZD05 - Email da pessoa jurídica a ser contatada
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     ZD06 - Telefone da pessoa física/jurídica a ser contatada
        /// </summary>
        public string fone { get; set; }

        /// <summary>
        ///     ZD08 - Identificador do CSRT
        /// </summary>
        [XmlIgnore]
        public int? idCSRT { get; set; }


        [XmlElement(ElementName = "idCSRT")]
        public string ProxyidCSRT
        {
            get
            {
                if (idCSRT == null) return null;
                return idCSRT.Value.ToString("D2");
            }
            set
            {
                if (value == null)
                {
                    idCSRT = null;
                    return;
                }

                idCSRT = int.Parse(value);
            }
        }

        /// <summary>
        ///     ZD09 - Hash do CSRT
        /// </summary>
        public string hashCSRT { get; set; }

        #endregion
    }
}