README.md:

# Sistema de Reservas de Hotel

Este projeto foi desenvolvido como parte do desafio do módulo "Explorando a Linguagem C#" da trilha .NET da Digital Innovation One.

## Descrição

O Sistema de Reservas de Hotel é uma aplicação de linha de comando que permite aos usuários realizar reservas em um hotel, cadastrando hóspedes e suítes, e calculando o valor da reserva com base nos dias reservados, além de aplicar um desconto de 10% para reservas de 10 dias ou mais.

## Funcionalidades

- Adicionar hóspedes: Permite cadastrar novos hóspedes para a reserva.
- Adicionar suíte: Permite cadastrar novas suítes no hotel.
- Realizar reserva: Calcula o valor da reserva com base nos dias reservados e na capacidade da suíte, aplicando desconto se necessário.
- Sair: Encerra o programa.

## Regras e validações

- Não é possível reservar uma suíte com capacidade menor do que a quantidade de hóspedes.
- O método `ObterQuantidadeHospedes` da classe `Reserva` retorna a quantidade total de hóspedes.
- O método `CalcularValorDiaria` da classe `Reserva` retorna o valor da diária, aplicando desconto de 10% para reservas iguais ou maiores que 10 dias.

## Requisitos

- .NET SDK: É necessário ter o SDK do .NET instalado no seu sistema para compilar e executar o projeto.
- Terminal: O programa é executado via linha de comando.

## Como Executar

1. Certifique-se de ter o .NET SDK instalado em seu sistema.
2. Clone este repositório para o seu ambiente local.
3. Navegue até o diretório do projeto `projeto_hotel` via terminal.
4. Compile o projeto executando o comando `dotnet build` no terminal.
5. Execute o projeto com o comando `dotnet run`.
6. Siga as instruções exibidas no terminal para interagir com o sistema de reservas de hotel.

## Desafio de Projeto

Desafio de Projeto: [Digital Innovation One - Trilha .NET](https://github.com/digitalinnovationone/trilha-net-explorando-desafio)

## Licença

Este projeto está licenciado sob a Licença MIT. Consulte o arquivo [LICENSE](LICENSE) para obter detalhes.