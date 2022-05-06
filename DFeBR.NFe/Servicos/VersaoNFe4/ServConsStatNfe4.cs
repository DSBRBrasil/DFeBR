// ===================================================================
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
    /// Consultar Status NFe
    /// </summary>
    internal class ServConsStatNfe4 : ServConsStatTemplate
    {
        #region Construtor

        public ServConsStatNfe4(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, VersaoServico versao,
                ModeloDocumento modelo = ModeloDocumento.NFe) : base(emissorServicoConfig, certificado, versao, modelo)
        {
        }

        #endregion
    }
}