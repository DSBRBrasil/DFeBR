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
    /// Consultar Recibo NFe
    /// </summary>
    internal class ServConsRecNfe4 : ServConsRecTemplate
    {
        #region Construtor

        /// <summary>
        ///     Inicializa objeto
        /// </summary>
        /// <param name="emissorServicoConfig">Configuração do Emissor</param>
        /// <param name="certificado">Certificado Digital</param>
        /// <param name="numRecibo">Numero do recibo</param>
        /// <param name="versao">Versao do Serviço</param>
        /// <param name="modelo"></param>
        public ServConsRecNfe4(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, string numRecibo,
                VersaoServico versao, ModeloDocumento modelo = ModeloDocumento.NFe) : base(emissorServicoConfig, certificado, numRecibo,
                versao, modelo)
        {
        }

        #endregion
    }
}