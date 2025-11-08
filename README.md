## Sobre o projeto

Esta API, desenvolvida utilizando **.NET 8**, adota os princípios de **Domain-Driven Design (DDD)** para oferecer uma solução estruturada e eficaz no gerenciamento de despesas pessoais. O principal objetivo é permitir que os usuários registrem suas despesas, detalhando informações como título, data e hora, descrição, valor e tipo de pagamento, com os dados sendo armazenados de forma segura em um banco de dados **MySQL**.

A arquitetura da **API** baseia-se em **REST**, utilizando métodos **HTTP** padronizados para uma comunicação eficiente e simplificada. Além disso, conta com documentação via **Swagger**, que proporciona uma interface gráfica interativa para que os desenvolvedores possam explorar e testar os endpoints de maneira fácil.

Dentre os pacotes NuGet utilizados, o **AutoMapper** é responsável pelo mapeamento entre objetos de domínio e requisição/resposta, reduzindo a necessidade de código repetitivo e manual. O **FluentAssertions** é empregado nos testes de unidade para tornar as verificações mais legíveis, ajudando a escrever testes claros e compreensíveis. Para as validações, o **FluentValidation** é utilizado para implementar regras de forma simples e intuitiva nas classes de requisição, mantendo o código limpo e fácil de manter. Por fim, o **EntityFramework** atua como um ORM (Object-Relational Mapper) que simplifica as interações com o banco de dados, permitindo o uso de objetos .NET para manipular dados diretamente, sem a necessidade de lidar com consultas SQL.

 ### Features

 - **Domain-Driven Design (DDD)**: Estrura Modular que facilita o entendimento e manutenção do domínio da aplicação.
 - **Testes de Unidade**: Tesyes abrangentes com FluentAssertions para garantir a funcionalidade e a qualidade.
 - **Geração de Relatórios**: Capacidade de exportar relatórios detalhados por **PDF e Excel**, oferecendo uma análise visuale eficaz das despesas.
 - **RESTful API com Documentação Swegger**: Interface documentada que facilita a integração e o teste por parte dos desenvolvedores.