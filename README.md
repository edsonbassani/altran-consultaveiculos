# Consulta de Veículos WebAPI + User Interface

**Objetivo**

O objetivo deste código-fonte é implementar as seguintes características:

  1. Interface de Usuário utilizando tecnologia Angular 7
  2. Sistema WebAPI utilizando as seguintes plataformas:
    - DotNet core 3.1.1
    - Entity Framework Core 
    - xUnit (Testes Unitários)
    - Redirecionamento https
    
  
**Características Técnicas**
   - Cross Origin Resource Sharing (CORS)
   - Injeção de Dependência
   - Desacoplamento
   - Padrão de Projeto nTier/DDD/CQRS
   
    
**Como usar:**

 1. Subir a aplicação em servidor IISExpress, IIS ou Kestrel utilizando a **porta 4200**
 2. Subir a API em servidor IISExpress, IIS ou Kestrel utilizando a **porta 44380**
 2. Realizar a chamada da Interface de Usuário: http://localhost:4200/
 3. Informar um número de placa de veículo para consulta, segundo a massa de dados em anexo ao projeto. (Ex. ABC1234)
 4. Aguardar o retorno do resultado
 
 
 **Detalhes**
 A Interface de Usuário enviará uma requisição para a WebAPI utilizando o método POST contendo a string "ABC1234", por exemplo.
 Caso o registro seja encontrado, a WebAPI retornará o resultado 202 OK acompanhado dos detalhes do registros e exibirá na tela
 Caso o registro náo seja encontrado, a WebAPI retornará o resultado 404 Not Found, evitando exploração de ataques ou novas    vulnerabilidades. 
 

**Screenshots**

**Tela Inicial**
![](https://github.com/edsonbassani/altran-consultaveiculos/blob/master/Images/UI.png?raw=true)

**Métricas de Qualidade de Código**
![](https://github.com/edsonbassani/altran-consultaveiculos/blob/master/Images/ConsultaVeiculos.CodeMetrics.png?raw=true)

**Chamada WebAPI via Postman**
![](https://github.com/edsonbassani/altran-consultaveiculos/blob/master/Images/Postman.ConsultaPlaca.png?raw=true)

**Envio de registros WebAPI via Postman**
![](https://github.com/edsonbassani/altran-consultaveiculos/blob/master/Images/Postman.GravarPlaca.png?raw=true)

**Resultado dos Testes Unitários**
![](https://github.com/edsonbassani/altran-consultaveiculos/blob/master/Images/xUnitResults.png?raw=true)


**Download**
(https://github.com/edsonbassani/altran-consultaveiculos/blob/master/DevCo.zip)
