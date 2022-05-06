// ===================================================================
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

namespace DFeBR.EmissorNFe.Utilidade.Exceptions
{
    public class FalhaContingenciaWebException : Exception
    {
        #region Construtor

        public FalhaContingenciaWebException()
        {
        }

        public FalhaContingenciaWebException(string message) : base(message)
        {
        }

        public FalhaContingenciaWebException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion
    }
}