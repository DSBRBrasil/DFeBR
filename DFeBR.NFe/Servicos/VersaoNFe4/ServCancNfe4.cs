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
using System.Security.Cryptography.X509Certificates;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Configurar;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Evento;
using DFeBR.EmissorNFe.Servicos.Templates;
using DFeBR.EmissorNFe.Utilidade.Tipos;

#endregion

namespace DFeBR.EmissorNFe.Servicos.VersaoNFe4
{
    /// <summary>
    /// Cancelamento de NFe
    /// </summary>
    internal class ServCancNfe4 : ServCancTemplate
    {
        #region Construtor

        public ServCancNfe4(EmissorServicoConfig emissorServicoConfig, X509Certificate2 certificado, int idlote,
                ICollection<EventoBuilder> eventoBuilder, VersaoServico versao, ModeloDocumento modelo = ModeloDocumento.NFe) : base(
                emissorServicoConfig, certificado, idlote, eventoBuilder, versao, modelo)
        {
        }

        #endregion
    }
}