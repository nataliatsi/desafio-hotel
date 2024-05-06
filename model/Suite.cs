using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_hotel.model
{
    public class Suite
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
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

        public Suite(int id, string tipoSuite, int capacidade, decimal valorDiaria)
        {
            Id = id;
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

    }
}