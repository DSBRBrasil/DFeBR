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
    public class FalhaCriacaoServicoWebException : Exception
    {
        #region Construtor

        public FalhaCriacaoServicoWebException()
        {
        }

        public FalhaCriacaoServicoWebException(string message) : base(message)
        {
        }


        public FalhaCriacaoServicoWebException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion
    }
}