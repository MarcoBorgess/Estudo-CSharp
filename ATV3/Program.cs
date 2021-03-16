using System;

namespace ATV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario();
            F1.nome = "Marco";
            F1.horas = 120;
            F1.valorHora = 200;
            
            double pag = F1.Pagamento();
            
            Console.WriteLine("Funcionário: "+F1.nome);
            Console.WriteLine("Pagamento: R$"+pag);
            
            Terceirizado T1 = new Terceirizado();

            T1.nome = "João";
            T1.horas = 120;
            T1.valorHora = 100;
            T1.despesaAdd = 100;
            
            pag = T1.Pagamento();

            Console.WriteLine("Funcionário: "+T1.nome);
            Console.WriteLine("Pagamento: R$"+pag);

            
        }
    }
}
