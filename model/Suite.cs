using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_hotel.model
{
    public class Suite
    {
        
        private string tipoSuite;
        public string TipoSuite
        {
            get { return tipoSuite; }
            set { tipoSuite = value; }
        }

        private int capacidade;
        public int Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        private decimal valorDiaria;
        public decimal ValorDiaria
        {
            get { return valorDiaria; }
            set { valorDiaria = value; }
        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

    }
}