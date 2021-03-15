using System;

namespace ATV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta C1 = new Conta("Maria", 1010, 200.00);
            ContaEmpresa C2 = new ContaEmpresa("Antonio", 1234, 15000.00, 5000.00);

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
