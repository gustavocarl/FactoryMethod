using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Veiculos
{
    public class Moto : IVeiculo
    {

        public void GetCarga()
        {
            Console.WriteLine("Receber Carga");
        }

        public void IniciaRota()
        {
            GetCarga();
            Console.WriteLine("Iniciar Entrega");
        }
    }
}
