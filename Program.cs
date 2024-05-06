using projeto_hotel.model;
using projeto_hotel.menu;
using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS8600 
#pragma warning disable CS8604 

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Pessoa> hospedes = new List<Pessoa>();

        string nome = "";
        string sobrenome = "";

        Pessoa p1 = new Pessoa(nome, sobrenome);
        Pessoa p2 = new Pessoa(nome, sobrenome);

        hospedes.Add(p1);
        hospedes.Add(p2);

        Hotel hotel = new Hotel();

        // int diasReservados = 0;

        // Reserva reserva = new Reserva(diasReservados);

        // reserva.CadastrarSuite(new Suite(1, "Premium", 2, 100));

        // reserva.CadastrarHospedes(hospedes);

        Menu menu = new Menu();
        int opcao;

        do
        {
            menu.ExibirMenu();
            opcao = menu.LerOpcao();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Cadastro de Suítes");
                    Console.Write("Digite o código da suíte: ");
                    int idSuite = int.Parse(Console.ReadLine());

                    Console.Write("Digite o tipo da suíte: ");
                    string tipoSuite = Console.ReadLine();

                    Console.Write("Digite a capacidade de hóspedes: ");
                    int capacidade = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor da diária: ");
                    decimal valorDiaria = decimal.Parse(Console.ReadLine());

                    Suite novaSuite = new Suite(idSuite, tipoSuite, capacidade, valorDiaria);
                    hotel.Suites.Add(novaSuite);
                    Console.WriteLine("Suíte cadastrada com sucesso!");
                    break;
                case 2:
                    Console.WriteLine("Listar suítes cadastradas");
                    hotel.ExibirSuites(hotel.Suites);
                    break;

                case 3:
                    Console.WriteLine("Reservar uma suíte");
                    //TODO: Lógica para reservar uma suíte
                    break;

                case 4:
                    Console.WriteLine("Cadastrar hóspedes e colocá-los em uma suíte");
                    //TODO: Lógica para cadastrar hóspedes e colocá-los em uma suíte
                    break;

                case 5:
                    try
                    {
                        Console.WriteLine("Listar todos os hóspedes cadastrados");
                        //TODO:Lógica para listar todos os hóspedes cadastrados
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Não há hóspedes cadastrados" + e.Message);
                    }
                    break;

                case 6:
                    Console.WriteLine("Listar hóspedes por suíte");
                    break;
                case 7:
                    Console.WriteLine("Saindo...");
                    break;
            }
        } while (opcao != 7);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
