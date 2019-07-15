using CaixaEletronico09;
using System;


namespace CaixaEletronicoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var caixaEletronico = new CaixaEletronico();

            Console.WriteLine("-->"+caixaEletronico.cofre);
        }
    }
}
