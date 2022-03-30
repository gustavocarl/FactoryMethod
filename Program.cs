using FactoryMethod.Fabricas;
using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            void Transporte()
            {
                Console.WriteLine("Selecione um tipo de serviço");
                Console.WriteLine();
                Console.WriteLine("1 - Caminhão");
                Console.WriteLine("2 - Barco");

                string opcao = Console.ReadLine();
                Transporte transporte = null;

                switch (opcao)
                {
                    case "1":
                        transporte = new CaminhaoTransporte();
                        break;

                    case "2":
                        transporte = new BarcoTransporte();
                        break;
                }

                if (transporte != null) { transporte.IniciarTransporte(); }

                Console.ReadLine();
            }

            Transporte();
        }
    }
}
