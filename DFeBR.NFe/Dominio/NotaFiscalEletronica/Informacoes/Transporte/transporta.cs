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

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Transporte
{
    public class transporta
    {
        #region Variaveis Globais

        private const string ErroCpfCnpjPreenchidos = "Somente preencher um dos campos: CNPJ ou CPF, para um objeto do tipo transporta!";

        #endregion

        #region Propriedades

        /// <summary>
        ///     X04 - CNPJ do Transportador
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
        ///     X05 - CPF do Transportador
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
        ///     X06 - Razão Social ou nome
        /// </summary>
        public string xNome { get; set; }

        /// <summary>
        ///     X07 - Inscrição Estadual do Transportador
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        ///     X08 - Endereço Completo
        /// </summary>
        public string xEnder { get; set; }

        /// <summary>
        ///     X09 - Nome do município
        /// </summary>
        public string xMun { get; set; }

        /// <summary>
        ///     X10 - Sigla da UF
        /// </summary>
        public string UF { get; set; }

        #endregion

        private string cnpj;
        private string cpf;
    }
}