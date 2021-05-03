using System;

namespace ATV9
{
    class Program
    {
        static void Main(string[] args)
        {
            Math matematica = new Math();
            int[] resultados = new int[5];

            resultados[0] = matematica.soma(1, 9); // 10
            resultados[1] = matematica.sub(20, 9); // 11
            resultados[2] = matematica.div(24, 2); // 12
            resultados[3] = matematica.mult(13, 1);// 13
            resultados[4] = matematica.mult(7, 2); // 14

            foreach (int x in resultados){
                Console.WriteLine(x);
            }
        }
    }
}
