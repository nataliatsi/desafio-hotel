using System.Text;
using projeto_hotel.model;

Console.OutputEncoding = Encoding.UTF8;

#pragma warning disable CS8600 
#pragma warning disable CS8604 

List<Pessoa> hospedes = new List<Pessoa>();
Reserva reserva = new Reserva();

do
{
    Console.WriteLine("Bem-vindo ao sistema de reservas do hotel.");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Adicionar hóspede");
    Console.WriteLine("2. Adicionar suite");
    Console.WriteLine("3. Realizar reserva");
    Console.WriteLine("4. Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome do hóspede:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do hóspede:");
            string sobrenome = Console.ReadLine();
            Pessoa novoHospede = new Pessoa(nome, sobrenome);
            hospedes.Add(novoHospede);
            break;
        case "2":
            Console.WriteLine("Digite o tipo da suite:");
            string tipoSuite = Console.ReadLine();
            Console.WriteLine("Digite a capacidade da suite:");
            int capacidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da diária:");
            decimal valorDiaria = decimal.Parse(Console.ReadLine());
            Suite novaSuite = new Suite(tipoSuite, capacidade, valorDiaria);
            reserva.CadastrarSuite(novaSuite);
            break;
        case "3":
            Console.WriteLine("Digite a quantidade de dias da reserva:");
            int diasReservados = int.Parse(Console.ReadLine());
            reserva.CadastrarHospedes(hospedes);
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria(diasReservados)}");
            break;
        case "4":
            Console.WriteLine("Saindo do programa...");
            return;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
            break;
    }

} while (true);

#pragma warning restore CS8600
#pragma warning restore CS8604