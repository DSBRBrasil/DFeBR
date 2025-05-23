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
using System.Xml.Serialization;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Destinatario
{
    public class dest
    {
        #region Variaveis Globais

        private const string ErroCpfCnpjPreenchidos = "Somente preencher um dos campos: CNPJ ou CPF, para um objeto do tipo dest!";

        #endregion

        #region Propriedades

        /// <summary>
        ///     E02 - CNPJ do destinatário
        /// </summary>
        public string CNPJ
        {
            get => cnpj;
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                if (string.IsNullOrEmpty(cpf))
                    cnpj = value;
                else
                    throw new ArgumentException(ErroCpfCnpjPreenchidos);
            }
        }

        /// <summary>
        ///     E03 - CPF do destinatário
        /// </summary>
        public string CPF
        {
            get => cpf;
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                if (string.IsNullOrEmpty(cnpj))
                    cpf = value;
                else
                    throw new ArgumentException(ErroCpfCnpjPreenchidos);
            }
        }

        /// <summary>
        ///     E03a - Identificador do destinatário, em caso de comprador estrangeiro
        /// </summary>
        public string idEstrangeiro { get; set; }

        /// <summary>
        ///     E04 - Razão Social ou nome do destinatário
        /// </summary>
        public string xNome { get; set; }

        /// <summary>
        ///     E05 - Endereço do Destinatário da NF-e
        /// </summary>
        public enderDest enderDest { get; set; }

        /// <summary>
        ///     E16a - Indicador da IE do destinatário:
        /// </summary>
        public indIEDest? indIEDest { get; set; } //Nulable por conta da v2.00

        /// <summary>
        ///     E17 - Inscrição Estadual
        ///     <para>Campo de informação obrigatória nos casos de emissão própria (procEmi = 0, 2 ou 3).</para>
        ///     <para>
        ///         A IE deve ser informada apenas com algarismos para destinatários contribuintes do ICMS, sem caracteres de
        ///         formatação (ponto, barra, hífen, etc.);
        ///     </para>
        ///     <para>
        ///         O literal “ISENTO” deve ser informado apenas para contribuintes do ICMS que são isentos de inscrição no
        ///         cadastro de contribuintes do ICMS e estejam emitindo NF-e avulsa;
        ///     </para>
        /// </summary>
        [XmlElement(IsNullable = true)]
        public string IE { get; set; }

        /// <summary>
        ///     E18 - Inscrição na SUFRAMA (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob
        ///     controle da SUFRAMA)
        /// </summary>
        public string ISUF { get; set; }

        /// <summary>
        ///     E18a - Inscrição Municipal
        ///     <para>
        ///         Este campo deve ser informado, quando ocorrer a emissão de NF-e conjugada, com prestação de serviços sujeitos
        ///         ao ISSQN e fornecimento de peças sujeitos ao ICMS.
        ///     </para>
        /// </summary>
        public string IM { get; set; }

        /// <summary>
        ///     E19 - Informar o e-mail do destinatário. O campo pode ser utilizado para informar o e-mail de recepção da NF-e
        ///     indicada pelo destinatário
        /// </summary>
        public string email { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        ///     A versão do serviço é obrigatória por conta do tratamento que será feito na propriedade IE
        /// </summary>
        /// <param name="versao"></param>
        public dest()
        {
            IE = "";
        }

        #endregion

        public bool ShouldSerializeindIEDest()
        {
            return indIEDest.HasValue;
        }

        public bool ShouldSerializeIE()
        {
            var teste = !string.IsNullOrEmpty(IE);
            return teste;
        }

        private string cnpj;
        private string cpf;
    }
}