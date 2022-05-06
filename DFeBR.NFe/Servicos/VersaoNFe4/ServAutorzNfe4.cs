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
using System.Security.Cryptography.X509Certificates;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Configurar;
using DFeBR.EmissorNFe.Servicos.Templates;
using DFeBR.EmissorNFe.Utilidade.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Servicos.VersaoNFe4
{
    /// <summary>
    /// Autorização de NFE
    /// </summary>
    internal class ServAutorzNfe4 : ServAutorzTemplate
    {
        #region Construtor

        /// <summary>
        /// </summary>
        /// <param name="emissorServicoConfig">Configuracoes do Emissor</param>
        /// <param name="certificado">Certificado Digital</param>
        /// <param name="versao">Versão do serviço</param>
        /// <param name="compactarMensagem">True, compacta mensagem</param>
        /// <param name="idlote">Numero do lote</param>
        /// <param name="nFes"></param>
        public ServAutorzNfe4(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, int idlote, ICollection<NFe> nFes,
                VersaoServico versao, bool compactarMensagem = false) : base(emissorServicoConfig, certificado, idlote, nFes, versao,
                compactarMensagem)

        {
        }

        /// <summary>
        /// </summary>
        /// <param name="emissorServicoConfig">Configuracoes do Emissor</param>
        /// <param name="certificado">Certificado Digital</param>
        /// <param name="versao">Versão do serviço</param>
        /// <param name="xml">Uma string xml NFe bem formada</param>
        /// <param name="compactarMensagem">True, compacta mensagem</param>
        public ServAutorzNfe4(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, string xml, VersaoServico versao,
                bool compactarMensagem = false) : base(emissorServicoConfig, certificado, xml, versao, compactarMensagem)
        {
        }

        #endregion
    }
}