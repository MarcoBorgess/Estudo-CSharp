using System;
using System.Collections.Generic;

namespace Testes
{
    class Program
    {
        static void Main(string[] args){
            
            /*LISTAS
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa("Arthur", 18));
            pessoas.Add(new Pessoa("Bianca", 20));
            pessoas.Add(new Pessoa("Celso", 15));
            pessoas.Add(new Pessoa("Diego", 30));

            foreach (Pessoa p in pessoas) {
                Console.WriteLine(p.nome + " tem " + p.idade + " anos.");
            }
            */

            //ARRAYS
            int[] arrayInteiro = new int[10];
            for (int i = 0; i < arrayInteiro.Length; i++){
                arrayInteiro[i] = i + 1;
            }
            foreach (int x in arrayInteiro){
                Console.WriteLine(x);
            }
            
        }
    }
}
