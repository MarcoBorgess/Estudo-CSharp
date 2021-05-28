using System;
using System.Collections.Generic;
using System.Linq;

namespace ATV10
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Elabore um algoritmo que calcule a idade média de 5 alunos.
            List<double> idades = new List<double>();

            for (int i = 1; i <= 5; i++){
                Console.WriteLine("Informa a idade do aluno "+ i);
                idades.Add(Convert.ToDouble(Console.ReadLine()));

            }

            Console.WriteLine("Média de idade dos alunos: " + idades.Average());
            
            //2. Crie um algoritmo que verifique se um número informado é par ou impar.
            Console.WriteLine("Informe um número");
            double x = Convert.ToDouble(Console.ReadLine());
            if(x % 2 == 0) {
                Console.WriteLine("Número é PAR");
            }else {
                Console.WriteLine("Número é IMPAR");
            }

            //3. Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
            int qntd = 0;
            for (int i = 1; i <= 10; i++){
                Console.WriteLine("Informe a idade da pessoa "+ i);
                int idade = Convert.ToInt32(Console.ReadLine());
                if (idade > 18) {
                    qntd++;
                }
            }
            Console.WriteLine("Pessoas com mais de 18 anos: "+ qntd);

            //4. Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.
            for (int i = 1; i <= 10; i++){
                Console.WriteLine("Informe o salário do funcionário "+ i);
                double sal = Convert.ToDouble(Console.ReadLine());
                if (sal <= 300){
                    Console.WriteLine("Salario reajustado: "+(sal*1.5));
                }else {
                    Console.WriteLine("Salario reajustado: "+(sal*1.3));
                }
            }

            //5. Faça um algoritmo que leia a altura e a matricula de dez aluno. Mostre a matricula do aluno mais alto e do aluno mais baixo.
            string[,] array = new string[3, 2];

            for (int i = 0; i < array.GetLength(0); i++){
                Console.WriteLine("Informe uma matricula");
                array[i, 0] = Console.ReadLine();
                Console.WriteLine("Informe a altura");
                array[i, 1] = Console.ReadLine();
            }
            double menor = Convert.ToDouble(array [0, 1]);
            double maior = Convert.ToDouble(array[0, 1]);
            int p = 0;
            int g = 0;
            for (int i = 0; i < array.GetLength(0); i++){
                if(Convert.ToDouble(array[i, 1]) < menor){
                    p = i;
                    menor = Convert.ToDouble(array[i, 1]);
                }
                if(Convert.ToDouble(array[i, 1]) > maior){
                    g = i;
                    maior = Convert.ToDouble(array[i, 1]);
                }
            }
            Console.WriteLine("Maior aluno: {0}, altura: {1}\n", array[g, 0], array [g, 1]);
            Console.WriteLine("Menor aluno: {0}, altura: {1}\n", array[p, 0], array [p, 1]);
        }
    }
}
