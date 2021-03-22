using System;

namespace ATV5
{
    class Program
    {
        static void Main(string[] args)
        {

            Gerente G1 = new Gerente();
            G1.matricula = 01;
            G1.nome = "Carla";
            G1.idade = 48;
            G1.salario = 2400.00; //comissão +1000

            Console.WriteLine("Gerente ->");
            Console.WriteLine(G1.mostrarDados());
            Console.WriteLine(G1.mostrarSalario());

            Supervisor S1 = new Supervisor();
            S1.matricula = 02;
            S1.nome = "Rodrigo";
            S1.idade = 34;
            S1.salario = 1200.00; //comissão +600

            Console.WriteLine("Supervisor ->");
            Console.WriteLine(S1.mostrarDados());
            Console.WriteLine(S1.mostrarSalario());

            Vendedor V1 = new Vendedor();
            V1.matricula = 03;
            V1.nome = "Luis";
            V1.idade = 22;
            V1.salario = 600.00; //comissão +300

            Console.WriteLine("Vendedor ->");
            Console.WriteLine(V1.mostrarDados());
            Console.WriteLine(V1.mostrarSalario());

        }
    }
}
