using System;

namespace ExerciciosSobreEstruturaCondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/

            Console.WriteLine("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());
            

            if (n1 >= 0)
            {
                Console.WriteLine("Número positivo");
            }
            else
            {
                Console.WriteLine("Número negativo");
            }
        }
    }
}
