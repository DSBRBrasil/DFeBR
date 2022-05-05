# Emissor_NFe
Componente gratuito para Geração de NFe e NFCe 4.00
Componente desenvolvida em **C#** sob .net standard 2.0


## Como usar

```cs
        /// <summary>
        /// Obter dados de configuração
        /// </summary>
        /// <returns></returns>
        private EmissorServicoConfig ObterConfiguracao()
        {
            // numero serial do certificado digital A1
            var serial = "0006ea4a695178883a8f92b10d0fa017";           
            var c1 = new EmissorServicoConfig(VersaoServico.Ve400, Estado.Ba, TipoAmbiente.Homologacao,caminhoConfig: "Arquivos");
            c1.ConfiguraCSC("000001", "99V851CA-C1C7-00P-BBDB-EEC38CFAA39F");
            c1.ConfiguraEmitente("0000000000", "", "MINHA EMPRESA", "NOME FANTASIA",
                    "000000", "", "00000", "000000", CRT.SimplesNacional, "logradouro", "1", "", "Bairro", 2927408, "Municipio", "BA", "410000",
                    null);
            c1.ConfiguraSchemaXSD(true, $@"{Environment.CurrentDirectory}\Schemas\versao4.00");
            c1.ConfiguraArquivoRetorno(true, @"D:\");
            c1.ConfiguraCertificadoA1Repositorio(serial); 
            return c1;
        }
        
        
        [TestMethod]
        [Description("Consultar status do serviço")]
        public void ConsultarStatusServico()
        {
            var c1 = ObterConfiguracao();
            var config = new Configurar(c1);
            var servNfe = new ServNFe4(config.EmissorConfig);
            var result = servNfe.ConsultarStatus("65");
            //Código de status com sucesso 
            Assert.AreEqual(107, result.Retorno.cStat);
        }
```

## Contribuição
Pull requests são bem vindos..

## Licença
**LGPL** (https://pt.wikipedia.org/wiki/GNU_Lesser_General_Public_License).
