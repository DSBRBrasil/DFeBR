# DFeBR - Emissor de Notas Fiscais Eletrônicas NFe

[![GitHub license](https://img.shields.io/github/license/DSBRBrasil/DFeBR?style=flat-square)](https://github.com/DSBRBrasil/DFeBR/blob/main/LICENSE)
[![GitHub issues](https://img.shields.io/github/issues/DSBRBrasil/DFeBR?style=flat-square)](https://github.com/DSBRBrasil/DFeBR/issues)
[![GitHub forks](https://img.shields.io/github/forks/DSBRBrasil/DFeBR?style=flat-square)](https://github.com/DSBRBrasil/DFeBR/network)
[![GitHub stars](https://img.shields.io/github/stars/DSBRBrasil/DFeBR?style=flat-square)](https://github.com/DSBRBrasil/DFeBR/stargazers)


Componente gratuito para Geração de NFe e NFCe versão 4.00

Desenvolvido em **C#** sob .NET STANDARD 2.0

Construido para ser flexivel e escalável. Versão melhorada do projeto origem https://github.com/ZeusAutomacao/DFe.NET


## Estado atual

Completamente **estável** para transmissão de notas ao consumidor modelos 65 e 55

**Não há e nem pode haver** dependência de componentes **Pagos ou Trial**

**DANFE** é gerada em formato string html, deixando a escolha do desenvolvedor usar este formato ou criar outro ao seu critério

O programador pode **alterar os endpoints** através de arquivo de configuração, pois tais endereços não estão **hard coded** no código fonte


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
## A Fazer 
- [ ] CT-e   - Conhecimento de Transporte Eletrônico :tada:
- [ ] MDF-e  - Manifesto Eletrônico de Documentos Fiscais :tada:
- [ ] CT-eOS - Conhecimento de Transporte Eletrônico para Outros Serviços (modelo 67) 


## Suporte
O uso deste componente **não lhe da direito nem garantia de suporte gratuito.**
Contudo, há serviços de consultoria para o uso correto do componente para emissão de NFe e NFCe dentro do contexto de sua aplicação. Caso necessite de uma consultoria, por gentilieza, criar uma [Issue](https://github.com/DSBRBrasil/Emissor_NFe/issues) e entraremos em contato o mais breve possível

## Contribuição
Pull requests são bem vindos.

## Licença
**LGPL** (https://pt.wikipedia.org/wiki/GNU_Lesser_General_Public_License).
