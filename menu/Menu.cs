using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_hotel.menu
{
    public class Menu
    {
        public void ExibirMenu()
        {
            Console.WriteLine("----- Sistema de Gerenciamento de Hotel -----");
            Console.WriteLine("1. Cadastrar uma suíte");
            Console.WriteLine("2. Listar suítes cadastradas");
            Console.WriteLine("3. Reservar uma suíte");
            Console.WriteLine("4. Cadastrar hóspedes");
            Console.WriteLine("5. Listar todos os hóspedes cadastrados");
            Console.WriteLine("6. Listar hóspedes por suíte");
            Console.WriteLine("7. Sair");
            Console.WriteLine("------------------------------------------------");
        }

        public int LerOpcao()
        {
            Console.Write("Escolha uma opção: ");
            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 7)
            {
                Console.WriteLine("Opção inválida. Escolha uma opção válida.");
                Console.Write("Escolha uma opção: ");
            }
            return opcao;
        }
    }
}
