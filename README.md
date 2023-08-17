# Sistema de Processamento de Pedidos de Comércio Eletrônico - RabbinhoCommerce

## Sobre o sistema
Este sistema é um sistema de processamento de pedidos de comércio eletrônico que permite aos clientes navegar por um catálogo de produtos, adicionar produtos ao carrinho de compras, fazer o checkout e acompanhar o status de seus pedidos. O sistema usa o RabbitMQ para implementar o processamento de pedidos em segundo plano.

O objetivo do sistema é fornecer uma solução para empresas que desejam vender produtos online. Ele resolve o problema de gerenciar pedidos, estoque e entrega de produtos de maneira eficiente e escalável.

## Documentação da API
A API do sistema inclui os seguintes endpoints:

- `GET /api/produtos`: Retorna uma lista de todos os produtos disponíveis no catálogo.
- `GET /api/carrinhos`: Retorna o conteúdo atual do carrinho de compras do cliente.
- `POST /api/carrinhos/{produtoId}/{quantidade}`: Adiciona um produto ao carrinho de compras do cliente com a quantidade especificada.
- `DELETE /api/carrinhos/{produtoId}`: Remove um produto do carrinho de compras do cliente.
- `POST /api/carrinhos/Checkout`: Remove um produto do carrinho de compras do cliente.



## Aprendizados
Ao desenvolver este sistema, aprendemos sobre várias tecnologias e conceitos importantes, incluindo:

- Desenvolvimento de APIs RESTful usando ASP.NET Core
- Uso do RabbitMQ para implementar mensagens assíncronas e processamento em segundo plano
- Criação e gerenciamento de carrinhos de compras e pedidos
- Gerenciamento de estoque e entrega de produtos

Esperamos que este projeto possa servir como um exemplo útil para outros desenvolvedores que desejam criar sistemas semelhantes.



## Melhorias

## Validação de Dados
Uma melhoria  será feita na controller de carrinho, essa melhoria será adicionar mais validações de dados para garantir que as informações fornecidas pelo cliente estejam corretas e completas. Isso será feito usando anotações de validação nos modelos de dados e adicionando verificações de validação personalizadas no código.

## Separação de Responsabilidades
Outra melhoria que será feita é separar as responsabilidades da controller de carrinho em diferentes classes e serviços. Por exemplo, o cálculo do total do pedido e a criação do objeto `Pedido` serão movidos para um serviço separado, deixando a controller mais enxuta e focada em lidar com as requisições HTTP.

## Integração com Serviços Externos
Também será feita a integração da controller de carrinho com serviços externos, como sistemas de pagamento ou serviços de entrega. Isso permitirá que o cliente finalizasse o pedido e efetuasse o pagamento diretamente pelo sistema, sem precisar sair do site.

## Testes Automatizados
Por fim, uma melhoria importante que será feita é adicionar testes automatizados para garantir a qualidade e a confiabilidade do código. Isso ajudará a detectar e corrigir erros mais rapidamente e a garantir que novas funcionalidades não afetem o funcionamento correto do sistema.
