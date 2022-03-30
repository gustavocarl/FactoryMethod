using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Veiculos
{
    public class Carro : IVeiculo
    {
        public void GetCarga()
        {
            Console.WriteLine("Pegar Passageiros");
        }

        public void IniciaRota()
        {
            GetCarga();
            Console.WriteLine("Iniciar Rota");
        }

    }
}
