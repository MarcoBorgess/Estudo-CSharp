using System;

namespace ATV7
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo V1 = new Veiculo("McLaren", "Senna", "Laranja", 5200.00);
            Locacao L1 = new Locacao("Marco", "29/03/2021", 10, V1);

            Console.WriteLine(L1.mostrarDados());
            Console.WriteLine("Valor Total: "+ L1.valorTotal().ToString("F2"));
        }
    }
}
