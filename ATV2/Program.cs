using System;

namespace ATV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta C1 = new Conta();
            C1.Nome = ("Maria");
            C1.Numero = (1010);
            C1.Saldo = (200.00);

            Conta C2 = new Conta();
            C2.Nome = ("Pedro");
            C2.Numero = (1234);
            C2.Saldo = (100.00);

            Console.WriteLine("Saldo Atual do "+C1.Nome+" : $"+C1.Saldo);
            C1.Depositar(300.00);
            Console.WriteLine("Saldo Atual do "+C1.Nome+" : $"+C1.Saldo);
            C1.Sacar(50.00);
            Console.WriteLine("Saldo Atual do "+C1.Nome+" : $"+C1.Saldo);

            Console.WriteLine("Saldo Atual do "+C2.Nome+" : $"+C2.Saldo);
            C2.Sacar(100.00);
            Console.WriteLine("Saldo Atual do "+C2.Nome+" : $"+C2.Saldo);
            C2.Depositar(1500.00);
            Console.WriteLine("Saldo Atual do "+C2.Nome+" : $"+C2.Saldo);

            C1.transferir(C2, 50.00);
            Console.WriteLine("Saldo Atual do "+C1.Nome+" : $"+C1.Saldo);
            Console.WriteLine("Saldo Atual do "+C2.Nome+" : $"+C2.Saldo);
        }
    }
}
