using System;

namespace ATV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P1 = new Produto();
            P1.nome = "Notebook";
            P1.preco = 1100.00;

            Console.WriteLine(P1.PrecoEtiqueta());

            ProdutoImportado PI1 = new ProdutoImportado();
            PI1.nome = "Tablet";
            PI1.preco = 260.00;
            PI1.taxaImportacao = 20.00;

            Console.WriteLine(PI1.PrecoEtiqueta());

            ProdutoUsado PU1 = new ProdutoUsado();
            PU1.nome = "Iphone 7";
            PU1.preco = 400.00;
            PU1.anoFabr = "2017";

            Console.WriteLine(PU1.PrecoEtiqueta());
        }
    }
}
