// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Recepcao.Retorno;

#endregion

namespace DFeBR.EmissorNFe.Servicos.Interfaces
{
    public interface IRetConsRec : IRetBasico
    {
        #region Propriedades

        retConsReciNFe Retorno { get; set; }

        #endregion

        ///// <summary>
        ///// Url do serviço
        ///// </summary>
        //string UrlServico { get; set; }

        ///// <summary>
        ///// WSDL
        ///// </summary>
        //string Wsdl { get; set; }
    }
}