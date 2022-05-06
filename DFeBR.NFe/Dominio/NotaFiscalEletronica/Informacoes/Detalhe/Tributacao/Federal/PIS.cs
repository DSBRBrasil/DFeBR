﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System.Xml.Serialization;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal
{
    public class PIS
    {
        #region Propriedades

        /// <summary>
        ///     <para>Q02 (PISAliq) - Grupo PIS tributado pela alíquota</para>
        ///     <para>Q03 (PISQtde) - Grupo PIS tributado por Qtde</para>
        ///     <para>Q04 (PISNT) - Grupo PIS não tributado</para>
        ///     <para>Q05 (PISOutr) - Grupo PIS Outras Operações</para>
        /// </summary>
        [XmlElement("PISAliq", typeof(PISAliq))]
        [XmlElement("PISQtde", typeof(PISQtde))]
        [XmlElement("PISNT", typeof(PISNT))]
        [XmlElement("PISOutr", typeof(PISOutr))]
        public PISBasico TipoPIS { get; set; }

        #endregion
    }
}