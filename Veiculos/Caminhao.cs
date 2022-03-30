using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Veiculos
{
    public class Caminhao : IVeiculo
    {
        public void GetCarga()
        {
            Console.WriteLine("Carga em Caixa");
        }

        public void TipoDeRota()
        {
            GetCarga();
            Console.WriteLine("Viagem Terrestre");
        }

    }
}
