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

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal.Tipos
{
    /// <summary>
    ///     <para>01 - Operação Tributável (base de cálculo = valor da operação (alíquota normal (cumulativo/não cumulativo)))</para>
    ///     <para>02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada))</para>
    ///     <para>03 - Operação Tributável (base de cálculo = quantidade vendida (alíquota por unidade de produto))</para>
    ///     <para>04 - Operação Tributável (tributação monofásica (alíquota zero))</para>
    ///     <para>05 - Operação Tributável (Substituição Tributária)</para>
    ///     <para>06 - Operação Tributável (alíquota zero)</para>
    ///     <para>07 - Operação Isenta da Contribuição</para>
    ///     <para>08 - Operação Sem Incidência da Contribuição</para>
    ///     <para>09 - Operação com Suspensão da Contribuição</para>
    ///     <para>49 - Outras Operações de Saída</para>
    ///     <para>50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para>
    ///     <para>51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno</para>
    ///     <para>52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação</para>
    ///     <para>53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para>
    ///     <para>54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para>
    ///     <para>55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para>
    ///     <para>
    ///         56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e
    ///         de Exportação
    ///     </para>
    ///     <para>
    ///         60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado
    ///         Interno
    ///     </para>
    ///     <para>
    ///         61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado
    ///         Interno
    ///     </para>
    ///     <para>62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação</para>
    ///     <para>
    ///         63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado
    ///         Interno
    ///     </para>
    ///     <para>
    ///         64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de
    ///         Exportação
    ///     </para>
    ///     <para>
    ///         65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de
    ///         Exportação
    ///     </para>
    ///     <para>
    ///         66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado
    ///         Interno, e de Exportação
    ///     </para>
    ///     <para>67 - Crédito Presumido - Outras Operações</para>
    ///     <para>70 - Operação de Aquisição sem Direito a Crédito</para>
    ///     <para>71 - Operação de Aquisição com Isenção</para>
    ///     <para>72 - Operação de Aquisição com Suspensão</para>
    ///     <para>73 - Operação de Aquisição a Alíquota Zero</para>
    ///     <para>74 - Operação de Aquisição sem Incidência da Contribuição</para>
    ///     <para>75 - Operação de Aquisição por Substituição Tributária</para>
    ///     <para>98 - Outras Operações de Entrada</para>
    ///     <para>99 - Outras Operações</para>
    /// </summary>
    public enum CSTPIS
    {
        /// <summary>
        ///     01 - Operação Tributável (base de cálculo = valor da operação (alíquota normal (cumulativo/não cumulativo)))
        /// </summary>
        [XmlEnum("01")] pis01 = 01,

        /// <summary>
        ///     02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada))
        /// </summary>
        [XmlEnum("02")] pis02 = 02,

        /// <summary>
        ///     03 - Operação Tributável (base de cálculo = quantidade vendida (alíquota por unidade de produto))
        /// </summary>
        [XmlEnum("03")] pis03 = 03,

        /// <summary>
        ///     04 - Operação Tributável (tributação monofásica (alíquota zero))
        /// </summary>
        [XmlEnum("04")] pis04 = 04,

        /// <summary>
        ///     05 - Operação Tributável (Substituição Tributária)
        /// </summary>
        [XmlEnum("05")] pis05 = 05,

        /// <summary>
        ///     06 - Operação Tributável (alíquota zero)
        /// </summary>
        [XmlEnum("06")] pis06 = 06,

        /// <summary>
        ///     07 - Operação Isenta da Contribuição
        /// </summary>
        [XmlEnum("07")] pis07 = 07,

        /// <summary>
        ///     08 - Operação Sem Incidência da Contribuição
        /// </summary>
        [XmlEnum("08")] pis08 = 08,

        /// <summary>
        ///     09 - Operação com Suspensão da Contribuição
        /// </summary>
        [XmlEnum("09")] pis09 = 09,

        /// <summary>
        ///     49 - Outras Operações de Saída
        /// </summary>
        [XmlEnum("49")] pis49 = 49,

        /// <summary>
        ///     50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno
        /// </summary>
        [XmlEnum("50")] pis50 = 50,

        /// <summary>
        ///     51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno<
        /// </summary>
        [XmlEnum("51")] pis51 = 51,

        /// <summary>
        ///     52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação
        /// </summary>
        [XmlEnum("52")] pis52 = 52,

        /// <summary>
        ///     53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno
        /// </summary>
        [XmlEnum("53")] pis53 = 53,

        /// <summary>
        ///     54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação
        /// </summary>
        [XmlEnum("54")] pis54 = 54,

        /// <summary>
        ///     55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação
        /// </summary>
        [XmlEnum("55")] pis55 = 55,

        /// <summary>
        ///     56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de
        ///     Exportação
        /// </summary>
        [XmlEnum("56")] pis56 = 56,

        /// <summary>
        ///     60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno
        /// </summary>
        [XmlEnum("60")] pis60 = 60,

        /// <summary>
        ///     61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno
        /// </summary>
        [XmlEnum("61")] pis61 = 61,

        /// <summary>
        ///     62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação
        /// </summary>
        [XmlEnum("62")] pis62 = 62,

        /// <summary>
        ///     63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno
        /// </summary>
        [XmlEnum("63")] pis63 = 63,

        /// <summary>
        ///     64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação
        /// </summary>
        [XmlEnum("64")] pis64 = 64,

        /// <summary>
        ///     65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de
        ///     Exportação
        /// </summary>
        [XmlEnum("65")] pis65 = 65,

        /// <summary>
        ///     66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno,
        ///     e de Exportação
        /// </summary>
        [XmlEnum("66")] pis66 = 66,

        /// <summary>
        ///     67 - Crédito Presumido - Outras Operações
        /// </summary>
        [XmlEnum("67")] pis67 = 67,

        /// <summary>
        ///     70 - Operação de Aquisição sem Direito a Crédito
        /// </summary>
        [XmlEnum("70")] pis70 = 70,

        /// <summary>
        ///     71 - Operação de Aquisição com Isenção
        /// </summary>
        [XmlEnum("71")] pis71 = 71,

        /// <summary>
        ///     72 - Operação de Aquisição com Suspensão
        /// </summary>
        [XmlEnum("72")] pis72 = 72,

        /// <summary>
        ///     73 - Operação de Aquisição a Alíquota Zero
        /// </summary>
        [XmlEnum("73")] pis73 = 73,

        /// <summary>
        ///     74 - Operação de Aquisição sem Incidência da Contribuição
        /// </summary>
        [XmlEnum("74")] pis74 = 74,

        /// <summary>
        ///     75 - Operação de Aquisição por Substituição Tributária
        /// </summary>
        [XmlEnum("75")] pis75 = 75,

        /// <summary>
        ///     98 - Outras Operações de Entrada
        /// </summary>
        [XmlEnum("98")] pis98 = 98,

        /// <summary>
        ///     99 - Outras Operações
        /// </summary>
        [XmlEnum("99")] pis99 = 99
    }
}