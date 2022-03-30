using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Veiculos
{
    public class Barco : IVeiculo
    {

        public void GetCarga()
        {
            Console.WriteLine("Carga em Container");
        }

        public void IniciaRota()
        {
            GetCarga();
            Console.WriteLine("Viagem Marítima");
        }
    }
}
