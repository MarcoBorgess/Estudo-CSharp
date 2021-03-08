using System;

namespace ATV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta C1 = new Conta();
            C1.Nome = ("Maria");
            C1.Numero = (1010);
            C1.Saldo = (200.00);

            ContaEmpresa C2 = new ContaEmpresa();
            C2.Nome = ("Antonio");
            C2.Numero = (1234);
            C2.Saldo = (15000.00);
            C2.LimiteEmprestimo = (5000.00);

            Console.WriteLine("Saldo Atual do "+C1.Nome+" : $"+C1.Saldo);
            C1.Depositar(300.00);
            Console.WriteLine("Saldo Atual do "+C1.Nome+" : $"+C1.Saldo);
            C1.Sacar(50.00);
            Console.WriteLine("Saldo Atual do "+C1.Nome+" : $"+C1.Saldo);

            Console.WriteLine("Saldo Atual do "+C2.Nome+" : $"+C2.Saldo);
            C2.Sacar(1000.00);
            Console.WriteLine("Saldo Atual do "+C2.Nome+" : $"+C2.Saldo);
            C2.Depositar(2000.00);
            Console.WriteLine("Saldo Atual do "+C2.Nome+" : $"+C2.Saldo);
            C2.Emprestar(3000.00);
            Console.WriteLine("Saldo Atual do "+C2.Nome+" : $"+C2.Saldo);

        }
    }
}
