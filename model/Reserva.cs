using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_hotel.model
{
    public class Reserva
    {
        private List<Pessoa> hospedes;
        public List<Pessoa> Hospedes
        {
            get { return hospedes; }
            set { hospedes = value; }
        }

        private Suite suite;
        public Suite Suite
        {
            get { return suite; }
            set { suite = value; }
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade excedida. Não é possível cadastrar todos os hóspedes.");
            }
        }
 
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return hospedes.Count;
        }

        public decimal CalcularValorDiaria(int diasReservados)
        {

            decimal valor = diasReservados * Suite.ValorDiaria;

            if (diasReservados >= 10)
            {
                valor *= 0.9m;
            }

            return valor;
        }

    }
}