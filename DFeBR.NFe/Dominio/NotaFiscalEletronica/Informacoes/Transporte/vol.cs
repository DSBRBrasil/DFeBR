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
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Transporte
{
    public class vol
    {
        #region Propriedades

        /// <summary>
        ///     X27 - Quantidade de volumes transportados
        /// </summary>
        public int? qVol { get; set; }

        /// <summary>
        ///     X28 - Espécie dos volumes transportados
        /// </summary>
        public string esp { get; set; }

        /// <summary>
        ///     X29 - Marca dos volumes transportados
        /// </summary>
        public string marca { get; set; }

        /// <summary>
        ///     X30 - Numeração dos volumes transportados
        /// </summary>
        public string nVol { get; set; }

        /// <summary>
        ///     X31 - Peso Líquido (em kg)
        /// </summary>
        public decimal? pesoL
        {
            get => _pesoL.Arredondar(3);
            set => _pesoL = value.Arredondar(3);
        }

        /// <summary>
        ///     X32 - Peso Bruto (em kg)
        /// </summary>
        public decimal? pesoB
        {
            get => _pesoB.Arredondar(3);
            set => _pesoB = value.Arredondar(3);
        }

        /// <summary>
        ///     X33 - Grupo Lacres
        ///     <para>Ocorrência: 0-5000</para>
        /// </summary>
        [XmlElement("lacres")]
        public List<lacres> lacres { get; set; }

        #endregion

        public bool ShouldSerializeqVol()
        {
            return qVol.HasValue;
        }

        public bool ShouldSerializepesoL()
        {
            return pesoL.HasValue;
        }

        public bool ShouldSerializepesoB()
        {
            return pesoB.HasValue;
        }

        private decimal? _pesoB;
        private decimal? _pesoL;
    }
}