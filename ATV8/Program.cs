using System;
using System.Collections.Generic;

namespace ATV8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluguel> alugueis = new List<Aluguel>();

            Aluguel A1 = new Aluguel("Marco Antonio", "marco@gmail.com", 1);
            Aluguel A2 = new Aluguel("Maria Green", "maria@gmail.com", 5);
            Aluguel A3 = new Aluguel("Alex Brown", "alex@gmail.com", 8);

            alugueis.Add(A1);
            alugueis.Add(A2);
            alugueis.Add(A3);
            
            int num = 1;
            foreach(Aluguel x in alugueis){
                Console.WriteLine("\nAluguel #"+num);
                num++;
                Console.WriteLine("Nome: "+x.Nome);
                Console.WriteLine("Email: "+x.Email);
                Console.WriteLine("Quarto: "+x.Quarto);
            }

            /*
            CONSULTAS:

            //Todos os dados dos alugueis que possuem cliente como nome começando com 'M'
            List<Aluguel> nomesM = alugueis.FindAll(x => x.Nome[0] == 'M');
            foreach(Aluguel x in nomesM){
                Console.WriteLine("Nome: "+x.Nome);
                Console.WriteLine("Email: "+x.Email);
                Console.WriteLine("Quarto: "+x.Quarto);
            }

            //Todos os dados do aluguel do quarto 1
            Aluguel quarto1 = alugueis.Find(x => x.Quarto == 1);
            Console.WriteLine("Nome: "+quarto1.Nome);
            Console.WriteLine("Email: "+quarto1.Email);
            Console.WriteLine("Quarto: "+quarto1.Quarto);
            
            //O nome do cliente do aluguel do quarto 5
            Aluguel quarto5nome = alugueis.Find(x => x.Quarto == 5);
            Console.WriteLine("Nome: " +quarto5nome.Nome);
            
            //O email dos clientes dos alugueis com quartos de numero maior que 1
            List<Aluguel> emails1 = alugueis.FindAll(x => x.Quarto > 1);
            foreach(Aluguel x in emails1){
                Console.WriteLine("Nome: "+x.Nome);
                Console.WriteLine("Email: "+x.Email);
                Console.WriteLine("Quarto: "+x.Quarto);
            }
            
            //Remover os alugueis dos quartos de numero menor que 8
            alugueis.RemoveAll(x => x.Quarto < 8);
            foreach(Aluguel x in alugueis){
                Console.WriteLine("Nome: "+x.Nome);
                Console.WriteLine("Email: "+x.Email);
                Console.WriteLine("Quarto: "+x.Quarto);
            }
            */
        }
    }
}
