﻿// ==================================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.Domain
// Autores: 
// Valnei Filho  e-mail: vmarinpietri@yahoo.com.br por DSBR Brasil Tecnologia www.DSBRBRASIL.com.br;
// Marco Polo  e-mail: marcopoloviana@hotmail.com
// Marcos Vinicius e-mail: marcos8154@gmail.com 
// Data Criação:07/05/2019
// Todos os direitos reservados
// ===================================================================


#region

using System.Collections.Generic;
using System.Xml.Serialization;
using DFeBR.EmissorNFe.Utilidade.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Evento
{
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class retEnvEvento
    {
        #region Propriedades

        /// <summary>
        ///     HR02 - Versão do leiaute
        /// </summary>
        [XmlAttribute]
        public string versao { get; set; }

        /// <summary>
        ///     HR03 - Identificador de controle do Lote de envio do Evento, conforme informado na mensagem de entrada.
        /// </summary>
        public int idLote { get; set; }

        /// <summary>
        ///     HR04 - Identificação do Ambiente: 1=Produção /2=Homologação
        /// </summary>
        public TipoAmbiente tpAmb { get; set; }

        /// <summary>
        ///     HR05 - Versão da aplicação que processou o evento.
        /// </summary>
        public string verAplic { get; set; }

        /// <summary>
        ///     HR06 - Código da UF que registrou o Evento. Utilizar 91 para o Ambiente Nacional.
        /// </summary>
        public Estado cOrgao { get; set; }

        /// <summary>
        ///     HR07 - Código do status da resposta
        /// </summary>
        public int cStat { get; set; }

        /// <summary>
        ///     HR08 - Descrição do status da resposta
        /// </summary>
        public string xMotivo { get; set; }

        /// <summary>
        ///     HR09 - TAG de grupo do resultado do processamento do Evento
        /// </summary>
        [XmlElement("retEvento")]
        public List<retEvento> retEvento { get; set; }

        #endregion
    }
}