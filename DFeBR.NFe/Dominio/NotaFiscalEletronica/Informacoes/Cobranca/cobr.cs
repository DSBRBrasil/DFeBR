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

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Cobranca
{
    public class cobr
    {
        #region Propriedades

        /// <summary>
        ///     Y02 - Grupo Fatura
        /// </summary>
        public fat fat { get; set; }

        /// <summary>
        ///     Y07 - Grupo Duplicata
        ///     <para>Ocorrência: 0-120</para>
        /// </summary>
        [XmlElement("dup")]
        public List<dup> dup { get; set; }

        #endregion
    }
}