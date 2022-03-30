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
                Console.WriteLine("1 - Carro");
                Console.WriteLine("2 - Moto");

                string opcao = Console.ReadLine();
                Transporte transporte = null;

                switch (opcao)
                {
                    case "1":
                        transporte = new CarroTransporte();
                        break;

                    case "2":
                        transporte = new MotoTransporte();
                        break;
                }

                if (transporte != null) { transporte.IniciarTransporte(); }

                Console.ReadLine();
            }

            Transporte();
        }
    }
}
