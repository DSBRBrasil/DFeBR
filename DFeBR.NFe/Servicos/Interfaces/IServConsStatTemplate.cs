// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


#region

#endregion

namespace DFeBR.EmissorNFe.Servicos.Interfaces
{
    public interface IServConsStatTemplate // : IBaseTemplate
    {
        #region Propriedades

        /// <summary>
        ///     Nome do serviço
        /// </summary>
        string NomeServico { get; }

        #endregion

        /// <summary>
        ///     Executar
        /// </summary>
        /// <returns></returns>
        IRetConsStat Executar();
    }
}