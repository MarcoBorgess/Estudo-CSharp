using System;

namespace ATV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Capa Capa01 = new Capa("Verde", "Plastico", 50.00);
            Celular Celular01 = new Celular("Motorola", "Preto", "G8 Plus", 1200.00, Capa01);

            Console.WriteLine("O valor total do celular " + Celular01.marca + " " + Celular01.modelo +
                                " com uma capa " + Celular01.Capa.cor + " de " + Celular01.Capa.material +
                                " é de R$" + Celular01.valorTotal().ToString("F2"));
        }
    }
}
