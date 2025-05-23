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
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.DeclaracaoImportacao;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Exportacao;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.ProdEspecifico;
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe
{
    public class prod
    {
        #region Propriedades

        /// <summary>
        ///     I02 - Código do produto ou serviço
        /// </summary>
        public string cProd { get; set; }

        /// <summary>
        ///     I03 - GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
        /// </summary>
        public string cEAN
        {
            get => _cEan ?? string.Empty;
//Sempre serializar o campo cEAN, mesmo que não tenha valor 
            set => _cEan = value ?? string.Empty;
        }

        /// <summary>
        ///     I04 - Descrição do produto ou serviço
        /// </summary>
        public string xProd { get; set; }

        /// <summary>
        ///     I05 - Código NCM (8 posições). Em caso de item de serviço ou item que não tenham produto (Ex. transferência de
        ///     crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0)
        /// </summary>
        public string NCM { get; set; }

        /// <summary>
        ///     105a - Nomenclatura de Valor aduaneio e Estatístico
        ///     <para>Ocorrência: 0-8</para>
        /// </summary>
        [XmlElement("NVE")]
        public List<string> NVE { get; set; }

        /// <summary>
        ///     I05c - Código CEST
        /// </summary>
        public string CEST { get; set; }

        /// <summary>
        ///     Versão 4.00
        ///     Indicador de Produção em escala relevante, conforme Cláusula 23 do Convenio ICMS 52/2017 ||||
        ///     Nota: preenchimento obrigatório para produtos com NCM
        ///     relacionado no Anexo XXVII do Convenio 52/2017
        /// </summary>
        public indEscala? indEscala { get; set; }

        public bool indEscalaSpecified => indEscala.HasValue;

        /// <summary>
        ///     Versão 4.00
        ///     CNPJ do Fabricante da Mercadoria, obrigatório para produto em escala NÃO relevante.
        /// </summary>
        public string CNPJFab { get; set; }

        /// <summary>
        ///     Versão 4.00
        ///     Código de Benefício fiscal utilizado pela UF, aplicado ao item. Obs: Deve ser utilizado o mesmo código adotado na
        ///     EFD e outras
        ///     declarações, nas UF que o exigem.
        /// </summary>
        public string cBenef { get; set; }

        /// <summary>
        ///     I06 - Código EX TIPI (3 posições)
        /// </summary>
        public string EXTIPI { get; set; }

        /// <summary>
        ///     I08 - Código Fiscal de Operações e Prestações
        /// </summary>
        public int CFOP { get; set; }

        /// <summary>
        ///     I09 - Unidade comercial
        /// </summary>
        public string uCom { get; set; }

        /// <summary>
        ///     I10 - Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.
        /// </summary>
        public decimal qCom
        {
            get => _qcom;
            set => _qcom = value.Arredondar(4);
        }

        /// <summary>
        ///     I10a - Valor Unitário de Comercialização
        /// </summary>
        public decimal vUnCom
        {
            get => _vUnCom;
            set => _vUnCom = value.Arredondar(10);
        }

        /// <summary>
        ///     I11 - Valor Total Bruto dos Produtos ou Serviços
        /// </summary>
        public decimal vProd
        {
            get => _vprod;
            set => _vprod = value.Arredondar(2);
        }

        /// <summary>
        ///     I12 - GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
        /// </summary>
        public string cEANTrib
        {
            get => _cEanTrib ?? string.Empty;
//Sempre serializar o campo cEANTrib, mesmo que não tenha valor 
            set => _cEanTrib = value ?? string.Empty;
        }

        /// <summary>
        ///     I13 - Unidade Tributável
        /// </summary>
        public string uTrib { get; set; }

        /// <summary>
        ///     I14 - Quantidade Tributável
        /// </summary>
        public decimal qTrib
        {
            get => _qtrib;
            set => _qtrib = value.Arredondar(4);
        }

        /// <summary>
        ///     I14a - Valor Unitário de tributação
        /// </summary>
        public decimal vUnTrib
        {
            get => _vUnTrib;
            set => _vUnTrib = value.Arredondar(10);
        }

        /// <summary>
        ///     I15 - Valor Total do Frete
        /// </summary>
        public decimal? vFrete
        {
            get => _vFrete.Arredondar(2);
            set => _vFrete = value.Arredondar(2);
        }

        /// <summary>
        ///     I16 - Valor Total do Seguro
        /// </summary>
        public decimal? vSeg
        {
            get => _vSeg.Arredondar(2);
            set => _vSeg = value.Arredondar(2);
        }

        /// <summary>
        ///     I17 - Valor do Desconto
        /// </summary>
        public decimal? vDesc
        {
            get => _vDesc.Arredondar(2);
            set => _vDesc = value.Arredondar(2);
        }

        /// <summary>
        ///     I17a - Outras despesas acessórias
        /// </summary>
        public decimal? vOutro
        {
            get => _vOutro.Arredondar(2);
            set => _vOutro = value.Arredondar(2);
        }

        /// <summary>
        ///     I17b - Indica se valor do Item (vProd) entra no valor total da NF-e (vProd)
        /// </summary>
        public IndicadorTotal indTot { get; set; }

        /// <summary>
        ///     I18 - Declaração de Importação
        /// </summary>
        [XmlElement("DI")]
        public List<DI> DI { get; set; }

        /// <summary>
        ///     I50 - Grupo de informações de exportação para o item
        /// </summary>
        [XmlElement("detExport")]
        public List<detExport> detExport { get; set; }

        /// <summary>
        ///     I60 - Número do Pedido de Compra
        /// </summary>
        public string xPed { get; set; }

        /// <summary>
        ///     I61 - Item do Pedido de Compra
        /// </summary>
        public int? nItemPed { get; set; }

        /// <summary>
        ///     I70 - Número de controle da FCI - Ficha de Conteúdo de Importação
        /// </summary>
        public string nFCI { get; set; }

        /// <summary>
        ///     I80 - Detalhamento de produto sujeito a rastreabilidade
        ///     Versão 4.00
        /// </summary>
        [XmlElement("rastro")]
        public List<rastro> rastro { get; set; }

        /// <summary>
        ///     <para>129 (veicProd) - Detalhamento de Veículos novos</para>
        ///     <para>K01 (med) - Detalhamento de Medicamentos e de matérias-primas farmacêuticas</para>
        ///     <para>L01 (arma) - Detalhamento de Armamento</para>
        ///     <para>LA01 (comb) - Informações específicas para combustíveis líquidos e lubrificantes</para>
        /// </summary>
        [XmlElement("veicProd", typeof(veicProd))]
        [XmlElement("med", typeof(med))]
        [XmlElement("arma", typeof(arma))]
        [XmlElement("comb", typeof(comb))]
        public ProdutoEspecifico ProdutoEspecifico
        {
            get => _produtoEspecifico;
            set
            {
                nRECOPI = null; //ProdutoEspecifico e nRECOPI são mutuamente exclusivos
                _produtoEspecifico = value;
            }
        }

        /// <summary>
        ///     LB01 - Número do RECOPI
        /// </summary>
        public string nRECOPI
        {
            get => _nRecopi;
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                ProdutoEspecifico = null; //ProdutoEspecifico e nRECOPI são mutuamente exclusivos
                _nRecopi = value;
            }
        }

        #endregion

        #region Construtor

        public prod()
        {
            NVE = new List<string>();
        }

        #endregion

        public bool ShouldSerializenItemPed()
        {
            return nItemPed.HasValue;
        }

        public bool ShouldSerializevFrete()
        {
            return vFrete.HasValue && vFrete > 0;
        }

        public bool ShouldSerializevSeg()
        {
            return vSeg.HasValue && vSeg > 0;
        }

        public bool ShouldSerializevDesc()
        {
            return vDesc.HasValue && vDesc > 0;
        }

        public bool ShouldSerializevOutro()
        {
            return vOutro.HasValue && vOutro > 0;
        }

        private string _cEan;
        private string _cEanTrib;

        private string _nRecopi;
        private ProdutoEspecifico _produtoEspecifico;
        private decimal _qcom;
        private decimal _qtrib;
        private decimal? _vDesc;
        private decimal? _vFrete;
        private decimal? _vOutro;
        private decimal _vprod;
        private decimal? _vSeg;
        private decimal _vUnCom;
        private decimal _vUnTrib;
    }
}