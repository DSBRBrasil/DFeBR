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
    #region

    #endregion

    public class FalhaCertificadoDigitalException : Exception
    {
        #region Construtor

        public FalhaCertificadoDigitalException()
        {
        }

        public FalhaCertificadoDigitalException(string message) : base(message)
        {
        }

        public FalhaCertificadoDigitalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion
    }
}