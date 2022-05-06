// ===================================================================
//  Empresa: DSBR - Empresa de Desenvolvimento de Sistemas
//  Projeto: DSBR - Automação Comercial
//  Autores:  Valnei Filho, Vagner Marcelo
//  E-mail: dsbrbrasil@yahoo.com.br
//  Data Criação: 10/04/2020
//  Todos os direitos reservados
// ===================================================================


namespace DFeBR.EmissorNFe.Danfe.Entidades
{
    public class Volume
    {
        #region Propriedades

        public decimal? Quantidade { get; }

        public string Especie { get; }

        public decimal PesoBruto { get; }

        public decimal PesoLiq { get; }

        public string Marca { get; }

        
        public Volume(decimal? quantidade, string especie, decimal pesoBruto, decimal pesoLiq, string marca)
        {
            Quantidade = quantidade;
            Especie = especie;
            PesoBruto = pesoBruto;
            PesoLiq = pesoLiq;
            Marca = marca;  
        }

        #endregion
    }
}