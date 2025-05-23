﻿// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using System.Security.Cryptography.X509Certificates;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Configurar;
using DFeBR.EmissorNFe.Servicos.Templates;
using DFeBR.EmissorNFe.Utilidade.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Servicos.VersaoNFe4
{
    /// <summary>
    /// Inutilizar NFe
    /// </summary>
    internal class ServInutNfe4 : ServInutTemplate
    {
        #region Construtor

        /// <summary>
        /// </summary>
        /// <param name="emissorServicoConfig"></param>
        /// <param name="certificado"></param>
        /// <param name="cnpj">CNPJ</param>
        /// <param name="ano">Ano</param>
        /// <param name="modelo">Modelo do documento</param>
        /// <param name="serie">Numero de serie</param>
        /// <param name="numeroInicial">Numero inicial</param>
        /// <param name="numeroFinal">Numero final</param>
        /// <param name="justificativa">Justificativa</param>
        public ServInutNfe4(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, string cnpj, int ano,
                ModeloDocumento modelo, int serie, int numeroInicial, int numeroFinal, string justificativa) : 
                base(emissorServicoConfig,
                certificado, cnpj, ano, modelo, VersaoServico.Ve400, serie, numeroInicial, numeroFinal, justificativa)
        {
        }

        #endregion
    }
}