using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_hotel.model
{
    public class Hotel
    {
        public List<Suite> Suites { get; set; }

        public Hotel()
        {
            Suites = new List<Suite>();
        }

        public void ExibirSuites(List<Suite> suites)
        {
            foreach (Suite suite in suites)
            {
                Console.WriteLine($"Suíte: {suite.Id} Tipo: {suite.TipoSuite} Capacidade: {suite.Capacidade} Valor da diária: R${suite.ValorDiaria}");
            }
        }
    }
}