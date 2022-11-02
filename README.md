# Sobre
Aplicação .NET CORE que consome um serviço SOAP para a disciplina de APIs e Web Services da Pós Graduação de Engenhaia de Software.


Objetivo:

Entendimento prático: 
 - Proxies 
 - Protocolo HTTP/HTTPS 
 - Como implementar uma chamada a um Web Service na linguagem/plataforma em que o aluno esteja mais habituado. 

Enunciado:
1. Crie uma aplicação simples, utilizando a linguagem/plataforma que você preferir, que consuma um Web Service SOAP. Implemente pelo menos três operações. Web Service de exemplo: https://www.crcind.com/csp/samples/SOAP.Demo.cls 
 2. Instale um proxy HTTP na sua máquina e verifique as mensagens enviadas/recebidas quando a sua aplicação acessa algum dos recursos implementados no Web Service. 


Resultados:

- Linguagem utilizada: .NET Core 3.1
- IDE: Visual Studio 2019
- Proxy: [Fiddler Classic](https://www.telerik.com/fiddler/fiddler-classic)

SAÍDA DO PROGRAMA
![image](https://user-images.githubusercontent.com/12875299/199601090-20c4ffc4-dd45-4251-8828-726b1b1b543b.png)

OPERAÇÃO 1 - Listar países
![image](https://user-images.githubusercontent.com/12875299/199601162-be7f8a8f-fa9a-4da2-a2e2-1016623ca905.png)
![image](https://user-images.githubusercontent.com/12875299/199601192-2e687132-8430-4bd9-a116-33a98ef60fd7.png)

OPERAÇÃO 2 - Obter país por código
![image](https://user-images.githubusercontent.com/12875299/199601390-d9d47899-71d4-4032-a6cc-e5272272deca.png)
![image](https://user-images.githubusercontent.com/12875299/199601421-3a34b960-6edc-436a-bdcd-cdf518d941ca.png)

OPERAÇÃO 3 - Obter capital 
![image](https://user-images.githubusercontent.com/12875299/199601501-a2c380fd-1a37-4913-b50a-40375fe1b4de.png)
![image](https://user-images.githubusercontent.com/12875299/199601531-6a8907ba-39dc-47b0-bd21-f9569a441705.png)


OPERAÇÃO 4 - Obter nome da moeda do país
![image](https://user-images.githubusercontent.com/12875299/199601581-f77831d7-4a36-416e-830b-a8a148130768.png)
![image](https://user-images.githubusercontent.com/12875299/199601616-37623cf2-d2ca-49a6-9f57-de37c844a595.png)


OPERAÇÃO 5 - Obter código de telefone do país
![image](https://user-images.githubusercontent.com/12875299/199601650-5474a378-49fd-4deb-a709-ed3d69131b1a.png)
![image](https://user-images.githubusercontent.com/12875299/199601692-452a54f9-2999-4b0e-b64b-33ccf871c978.png)


