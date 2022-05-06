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
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.RetornoServicos.Evento;

#endregion

namespace DFeBR.EmissorNFe.Servicos.Interfaces
{
    public interface IServicoStrategy
    {
        #region Propriedades

        /// <summary>
        ///     Certificado Digital
        /// </summary>
        X509Certificate2 X509Certificate2 { get; }

        /// <summary>
        ///     Configuracao do Emissor
        /// </summary>
        EmissorServicoConfig EmissorConfig { get; }

        #endregion

        /// <summary>
        /// Consulta o status do Serviço de NFe
        /// </summary>
        /// <param name="modelo">Retorna status do serviço</param>
        /// <returns></returns>
        IRetConsStat ConsultarStatus(string modelo);

        /// <summary>
        ///     Obtém um XML de evento de cancelamento formatado após todas as fases de preparação antes do envio a SEFAZ
        /// </summary>
        /// <param name="idlote">Número do lote</param>
        /// <param name="eventoBuilders">Dados do evento cancelar uma NFe</param>
        /// <param name="modelo">Modelo do documento 55 ou 65</param>
        string ObterXmlCancelamento(int idlote, ICollection<EventoBuilder> eventoBuilders, string modelo);

        /// <summary>
        ///     Obtém um XML formatado após todas as fases de preparação antes do envio a SEFAZ
        /// </summary>
        /// <param name="nfe">Objeto NFe</param>
        /// <returns></returns>
        string ObterXmlAutorizacao(NFe nfe);

        /// <summary>
        ///     Solicita autorização de uma NFe
        /// </summary>
        /// <param name="xmlNFe">Uma string Xml Nfe </param>
        /// <param name="compactarMensagem">Define se a mensagem será enviada para a SEFAZ compactada</param>
        /// <returns></returns>
        IRetAutorz Autorizar(string xmlNFe, bool compactarMensagem = false);

        /// <summary>
        ///     Solicita autorização de uma NFe
        /// </summary>
        /// <param name="NFe">Objeto NFe</param>
        /// <param name="compactarMensagem">Define se a mensagem será enviada para a SEFAZ compactada</param>
        /// <returns></returns>
        IRetAutorz Autorizar(NFe nfe, bool compactarMensagem = false);

        /// <summary>
        ///     Inutilizar número de nota
        /// </summary>
        /// <param name="cnpj">CNPJ</param>
        /// <param name="ano">Ano</param>
        /// <param name="modelo">Modelo do documento 55 ou 65</param>
        /// <param name="serie">Numero de serie</param>
        /// <param name="numeroInicial">Numero inicial</param>
        /// <param name="numeroFinal">Numero final</param>
        /// <param name="justificativa">Justificativa</param>
        /// <returns></returns>
        IRetInut Inutilizar(string cnpj, int ano, string modelo, int serie, int numeroInicial, int numeroFinal, string justificativa);

        /// <summary>
        ///     Consultar NFe por sua Chave
        /// </summary>
        /// <param name="documento">Uma chave Nfe ou uma Xml Nfe bem formada</param>
        /// <param name="pelaChave">True, pesquisar pela chave, False pesquisar por um documento Xml bem formado </param>
        /// <param name="modelo">Modelo do documento 55 ou 65</param>
        /// <returns></returns>
        IRetConsProt ConsultarPelaChave(string documento, bool pelaChave, string modelo);

        /// <summary>
        ///     Consultar NFe pelo número do recibo
        /// </summary>
        /// <param name="numRecibo">Número do recibo</param>
        /// <param name="modelo">Modelo do documento 55 ou 65</param>
        /// <returns></returns>
        IRetConsRec ConsultarPeloRecibo(string numRecibo, string modelo);

        /// <summary>
        ///     Cancelar uma NFe
        /// </summary>
        /// <param name="idlote">Número do lote</param>
        /// <param name="eventoBuilders">Dados do evento cancelar uma NFe</param>
        /// <param name="modelo">Modelo do documento 55 ou 65</param>
        /// <returns></returns>
        IRetCancelar CancelarNFe(int idlote, ICollection<EventoBuilder> eventoBuilders, string modelo);

        /// <summary>
        ///     Carta de Correção de uma NFe
        /// </summary>
        /// <param name="idlote">Número do lote</param>
        /// <param name="eventoBuilders">Dados do evento cancelar uma NFe</param>
        /// <param name="modelo">Modelo do documento 55 ou 65</param>
        /// <returns></returns>
        IRetRecepEvento CartaCorrecaoNFe(int idlote, ICollection<EventoBuilder> eventoBuilders, string modelo);
    }
}