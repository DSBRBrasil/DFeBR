// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal
{
    public class IPITrib : IPIBasico
    {
        #region Propriedades

        /// <summary>
        ///     O09 - Código da Situação Tributária do IPI:
        /// </summary>
        public CSTIPI CST { get; set; }

        /// <summary>
        ///     O10 - Valor da BC do IPI
        /// </summary>
        public decimal? vBC
        {
            get => _vBc.Arredondar(2);
            set => _vBc = value.Arredondar(2);
        }

        /// <summary>
        ///     O13 - Alíquota do IPI
        /// </summary>
        public decimal? pIPI
        {
            get => _pIpi.Arredondar(4);
            set => _pIpi = value.Arredondar(4);
        }

        /// <summary>
        ///     O11 - Quantidade total na unidade padrão para tributação (somente para os produtos tributados por unidade)
        /// </summary>
        public decimal? qUnid
        {
            get => _qUnid.Arredondar(4);
            set => _qUnid = value.Arredondar(4);
        }

        /// <summary>
        ///     O12 - Valor por Unidade Tributável
        /// </summary>
        public decimal? vUnid
        {
            get => _vUnid.Arredondar(4);
            set => _vUnid = value.Arredondar(4);
        }

        /// <summary>
        ///     O14 - Valor do IPI
        /// </summary>
        public decimal? vIPI
        {
            get => _vIpi.Arredondar(2);
            set => _vIpi = value.Arredondar(2);
        }

        #endregion

        public bool ShouldSerializevBC()
        {
            return vBC.HasValue;
        }

        public bool ShouldSerializepIPI()
        {
            return pIPI.HasValue;
        }

        public bool ShouldSerializeqUnid()
        {
            return qUnid.HasValue;
        }

        public bool ShouldSerializevUnid()
        {
            return vUnid.HasValue;
        }

        public bool ShouldSerializevIPI()
        {
            return vIPI.HasValue;
        }

        private decimal? _pIpi;
        private decimal? _qUnid;
        private decimal? _vBc;
        private decimal? _vIpi;
        private decimal? _vUnid;
    }
}