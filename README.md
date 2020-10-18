# :globe_with_meridians: API People

## O que temos aqui

 Uma API  REST que retorna os dados de uma pessoa cadastrada em banco de dados.

## Tecnologias usadas

**Linguagen:**

- C#

**Framework:**

- .NET Core

**Banco de dados:**

- MariaDB

## Pré requisitos para executar a API

- [SDK .Net Core](https://dotnet.microsoft.com/download/dotnet-core/3.0)
- [MariaDB](https://mariadb.org/download/)

# Como usar

Após instalar o SDK e o MariaDB, baixe a [API](https://github.com/AllanBelo/API-.NET-Core-ADO.Net-MariaDB/archive/master.zip) crie o banco com o aruivo data_base.sql que esta nos arquivos que baixou, 

altere o *userid* e *password* do  banco de dados do arquivo appsettings.json:

```
​```javascript 
*"ConnectionStrings"*:{*"MySqlDbConnection"*: "server=127.0.0.1;database=data_base; userid=**Seu_usuario**; password=**Sua_senha**" },
​```
```



Abra o prompt de comando dentro da pasta onde baixou a API e execute o comando:

```shell
dotnet run
```

# End point 

```
|Verbo HTTP | Endpoint e Parametro|
|-----------| --------------------|
GET | https://localhost:5001/api/people/{PersonID}
```





