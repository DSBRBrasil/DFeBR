// ===================================================================
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

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Pagamento
{
    public class pag
    {
        #region Propriedades

        /// <summary>
        ///     YA01a - Grupo Detalhamento da Forma de Pagamento
        ///     VERSÃO 4.00
        /// </summary>
        [XmlElement("detPag")]
        public List<detPag> detPag { get; set; }

        /// <summary>
        ///     YA09 - Valor do troco
        ///     Versão 4.00
        /// </summary>
        public decimal? vTroco
        {
            get => _vTroco.Arredondar(2);
            set => _vTroco = value.Arredondar(2);
        }

        public bool vTrocoSpecified => _vTroco.HasValue;

        /// <summary>
        ///     YA02 - Forma de pagamento
        ///     Versão 3.00
        /// </summary>
        public FormaPagamento? tPag { get; set; }

        public bool tPagSpecified => tPag.HasValue;

        /// <summary>
        ///     YA03 - Valor do Pagamento
        ///     Versão 3.00
        /// </summary>
        public decimal? vPag
        {
            get => _vPag.Arredondar(2);
            set => _vPag = value.Arredondar(2);
        }

        public bool vPagSpecified => vPag.HasValue;

        /// <summary>
        ///     YA04 - Grupo de Cartões
        ///     Versão 3.00
        /// </summary>
        public card card { get; set; }

        #endregion

        private decimal? _vPag;
        private decimal? _vTroco;
    }
}