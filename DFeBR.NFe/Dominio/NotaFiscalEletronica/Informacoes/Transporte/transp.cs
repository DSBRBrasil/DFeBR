﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Transporte
{
    public class transp
    {
        #region Propriedades

        /// <summary>
        ///     X02 - Modalidade do frete
        ///     Versão 3.10
        ///     Versão 4.00
        /// </summary>
        public ModalidadeFrete? modFrete { get; set; }

        public bool modFreteSpecified => modFrete.HasValue;

        /// <summary>
        ///     X03 - Grupo Transportador
        /// </summary>
        public transporta transporta { get; set; }

        /// <summary>
        ///     X11 - Grupo Retenção ICMS transporte
        /// </summary>
        public retTransp retTransp { get; set; }

        /// <summary>
        ///     X18 - Grupo Veículo Transporte
        /// </summary>
        public veicTransp veicTransp { get; set; }

        /// <summary>
        ///     X22 - Grupo Reboque
        ///     <para>Ocorrência: 0-5</para>
        /// </summary>
        [XmlElement("reboque")]
        public List<reboque> reboque { get; set; }

        /// <summary>
        ///     X26 - Grupo Volumes
        ///     <para>Ocorrência: 0-5000</para>
        /// </summary>
        [XmlElement("vol")]
        public List<vol> vol { get; set; }

        /// <summary>
        ///     X25a - Identificação do vagão
        /// </summary>
        public string vagao { get; set; }

        /// <summary>
        ///     X25b - Identificação da balsa
        /// </summary>
        public string balsa { get; set; }

        #endregion
    }
}