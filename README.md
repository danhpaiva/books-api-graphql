<h1 align="center"> 🖳 BooksApi GraphQL 🖳</h1>

<p align="center">
    <img src="https://github.com/danhpaiva/blazor-viacep/blob/main/screen/image.png?raw=true" width="600" alt="BooksApi GraphQL">
</p>

<p align="center">
 <a href="#status">Status</a> • 
 <a href="#objective">Objetivo</a> •
 <a href="#installation">Desenvolvimento</a> • 
 <a href="#technology">Tecnologias</a> • 
 <a href="#author">Autor</a> • 
 <a href="#licence">Licença</a>
</p>

<h2 align="center" id=status> 
	⌛ Concluído ⌛
</h2>

<h2 id=objective>📜 Sobre</h2>
Criacao de uma API simples no modelo GraphQL em .Net + HotChocolate.AspNetCore. <br>
O modelo de dados esta simples porque o foco esta em abstrair alguns conhecimentos da biblioteca HotChocolate.

<h2 id=installation>✔️ Instalacao</h2>

Você precisa ter o Visual Studio 2022 ou VsCode instalado para testar o projeto.</br>
O projeto roda sob o SDK .Net 8.

Rode o projeto e acesse a URL:

~~~
https://localhost:7115/graphql/
~~~

Clique em Browse Schema, Operations e cole esse modelo de retorno de dados:

~~~
{
    books {
      id,
      title,
      author,
    }
}
~~~

Voce recebera um json semelhante a este:

~~~
{
  "data": {
    "books": [
      {
        "id": "3cbb8c83-1400-4166-97e4-93284010ea8e",
        "title": "Code Clean",
        "author": "Robert C. Martin"
      },
      {
        "id": "048cfb4c-d530-4bc9-a010-1af5c7d97562",
        "title": "Domain-Driven Design",
        "author": "Eric Evans"
      }
    ]
  }
}
~~~


<h2 id=technology>🧰 Tecnologias</h2>

As seguintes tecnologias foram utilizadas neste projeto:

- IDE: <a href="https://visualstudio.microsoft.com/pt-br/vs/">Visual Studio 2022</a>
- SDK: <a href="https://dotnet.microsoft.com/pt-br/download/dotnet/8.0">.Net 8</a>
- HotChocolate: <a href="https://www.nuget.org/packages/HotChocolate.AspNetCore/">HotChocolate.AspNetCore</a>
  
<h2 id=author>😎 Autor</h2>

Developed by <a href="https://www.linkedin.com/in/danhpaiva/" target="_blank">Daniel Paiva</a>

<h2 id=licence>🆓 Licença</h2>

Este projeto está sob a licença
<a href="https://github.com/danhpaiva/blazor-viacep/blob/main/LICENSE" target="_blank">MIT</a>
