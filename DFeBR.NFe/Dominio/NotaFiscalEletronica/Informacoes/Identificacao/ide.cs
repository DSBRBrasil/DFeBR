﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using DFeBR.EmissorNFe.Utilidade;
using DFeBR.EmissorNFe.Utilidade.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Identificacao
{
    public class ide
    {
        #region Propriedades

        /// <summary>
        ///     B02 - Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE.
        /// </summary>
        public Estado cUF { get; set; }

        /// <summary>
        ///     B03 - Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e.
        /// </summary>
        public string cNF { get; set; }

        /// <summary>
        ///     B04 - Descrição da Natureza da Operação
        /// </summary>
        public string natOp { get; set; }


        /// <summary>
        ///     B06 - Modelo do Documento Fiscal
        /// </summary>
        public ModeloDocumento mod { get; set; }

        /// <summary>
        ///     B07 - Série do Documento Fiscal
        ///     <para>série normal 0-889</para>
        ///     <para>Avulsa Fisco 890-899</para>
        ///     <para>SCAN 900-999</para>
        /// </summary>
        public int serie { get; set; }

        /// <summary>
        ///     B08 - Número do Documento Fiscal
        /// </summary>
        public long nNF { get; set; }

        /// <summary>
        ///     B09 - Data de emissão do Documento Fiscal - V2.00
        /// </summary>
        [XmlIgnore]
        public DateTime dEmi { get; set; } //V2.00

        /// <summary>
        ///     Proxy para dEmi no formato AAAA-MM-DD
        /// </summary>
        [XmlElement(ElementName = "dEmi")]
        public string ProxydEmi
        {
            get => dEmi.ParaDataString();
            set => dEmi = DateTime.Parse(value);
        }

        /// <summary>
        ///     B10 - Data de Saída ou da Entrada da Mercadoria/Produto - V2.00
        /// </summary>
        [XmlIgnore]
        public DateTime dSaiEnt { get; set; } //V2.00

        /// <summary>
        ///     Proxy para dSaiEnt no formato AAAA-MM-DD
        /// </summary>
        [XmlElement(ElementName = "dSaiEnt")]
        public string ProxydSaiEnt
        {
            get => dSaiEnt.ParaDataString();
            set => dSaiEnt = DateTime.Parse(value);
        }

        /// <summary>
        ///     B09 - Data e Hora de emissão do Documento Fiscal
        /// </summary>
        [XmlIgnore]
        public DateTimeOffset dhEmi { get; set; }

        /// <summary>
        ///     Proxy para dhEmi no formato AAAA-MM-DDThh:mm:ssTZD (UTC - Universal Coordinated Time)
        /// </summary>
        [XmlElement(ElementName = "dhEmi")]
        public string ProxyDhEmi
        {
            get => dhEmi.ParaDataHoraStringUtc();
            set => dhEmi = DateTimeOffset.Parse(value);
        }

        /// <summary>
        ///     B10 - Data e Hora da saída ou de entrada da mercadoria / produto
        /// </summary>
        [XmlIgnore]
        public DateTimeOffset? dhSaiEnt { get; set; }

        /// <summary>
        ///     Proxy para dhSaiEnt no formato AAAA-MM-DDThh:mm:ssTZD (UTC - Universal Coordinated Time)
        /// </summary>
        [XmlElement(ElementName = "dhSaiEnt")]
        public string ProxydhSaiEnt
        {
            get => dhSaiEnt.ParaDataHoraStringUtc();
            set => dhSaiEnt = DateTimeOffset.Parse(value);
        }

        /// <summary>
        ///     B11 - Tipo do Documento Fiscal
        /// </summary>
        public TipoNFe tpNF { get; set; }

        /// <summary>
        ///     B11a - Identificador de Local de destino da operação
        /// </summary>
        public DestinoOperacao? idDest { get; set; } //Nulable por conta da v2.00

        /// <summary>
        ///     B12 - Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE)
        /// </summary>
        public long cMunFG { get; set; }

        /// <summary>
        ///     B21 - Formato de impressão do DANFE
        /// </summary>
        public TipoImpressao tpImp { get; set; }

        /// <summary>
        ///     B22 - Tipo de Emissão da NF-e
        /// </summary>
        public TipoEmissao tpEmis { get; set; }

        /// <summary>
        ///     B23 - Digito Verificador da Chave de Acesso da NF-e
        /// </summary>
        public int cDV { get; set; }

        /// <summary>
        ///     B24 - Identificação do Ambiente
        /// </summary>
        public TipoAmbiente tpAmb { get; set; }

        /// <summary>
        ///     B25a - Finalidade da emissão da NF-e
        /// </summary>
        public FinalidadeNFe finNFe { get; set; }

        /// <summary>
        ///     B25a - Indica operação com consumidor final
        /// </summary>
        public ConsumidorFinal? indFinal { get; set; } //Nulable por conta da v2.00

        /// <summary>
        ///     B25b - Indicador de presença do comprador no estabelecimento comercial no momento da operação
        /// </summary>
        public PresencaComprador? indPres { get; set; } //Nulable por conta da v2.00
        /// <summary>
        ///     B25c - Indicador de intermediador/marketplace
        /// </summary>
        public IndicadorIntermediador? indIntermed { get; set; }
         

        /// <summary>
        ///     B26 - Processo de emissão utilizado com a seguinte codificação:
        /// </summary>
        public ProcessoEmissao procEmi { get; set; }

        /// <summary>
        ///     B27 - versão do aplicativo utilizado no processo de emissão
        /// </summary>
        public string verProc { get; set; }

        /// <summary>
        ///     B28 - Informar apenas para tpEmis diferente de 1
        ///     <para>
        ///         Informar a data e hora de entrada em contingência
        ///     </para>
        /// </summary>
        [XmlIgnore]
        public DateTimeOffset dhCont { get; set; }

        /// <summary>
        ///     Proxy para dhCont no formato AAAA-MM-DDThh:mm:ssTZD (UTC - Universal Coordinated Time)
        /// </summary>
        [XmlElement(ElementName = "dhCont")]
        public string ProxydhCont
        {
            get => dhCont.ParaDataHoraStringUtc();
            set => dhCont = DateTimeOffset.Parse(value);
        }

        /// <summary>
        ///     B29 - Informar a Justificativa da entrada
        /// </summary>
        public string xJust { get; set; }

        /// <summary>
        ///     BA01 - Informação de Documentos Fiscais referenciados
        /// </summary>
        [XmlElement("NFref")]
        public List<NFref> NFref { get; set; }

        #endregion


        public bool ShouldSerializeidDest()
        {
            return idDest.HasValue;

        }

        public bool ShouldSerializeindFinal()
        {
            return indFinal.HasValue;
        }

        public bool ShouldSerializeindPres()
        {
            return indPres.HasValue;
        }
    }
}