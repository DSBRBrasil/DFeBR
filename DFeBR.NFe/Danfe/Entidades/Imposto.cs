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
    public class Imposto
    {
        #region Propriedades

        public decimal vBCIMS { get; }

        public decimal vICMS { get; }

        public decimal? vBCICMSST { get; }

        public decimal? vICMSST { get; }

        public decimal vProd { get; }

        public decimal vFrete { get; }

        public decimal vSeg { get; }

        public decimal vDesc { get; }

        public decimal vOutro { get; }

        public decimal vIpi { get; }

        public decimal vNF { get; }

        #endregion


        public Imposto(decimal vBcims, decimal vIcms, decimal? vBcicmsst, decimal? vIcmsst, 
                decimal vProd, decimal vFrete, decimal vSeg, decimal vDesc, decimal vOutro, decimal vIpi, decimal vNf)
        {
            vBCIMS = vBcims;
            vICMS = vIcms;
            vBCICMSST = vBcicmsst;
            vICMSST = vIcmsst;
            this.vProd = vProd;
            this.vFrete = vFrete;
            this.vSeg = vSeg;
            this.vDesc = vDesc;
            this.vOutro = vOutro;
            this.vIpi = vIpi;
            vNF = vNf;
        }
    }
}