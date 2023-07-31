using System;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace Exercicio1
{
    //Escreva um programa que faça a leitura do nome do usuário e imprima uma saudação no console usando o nome digitado.

    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao();
        }
        public static void Saudacao()
        {
            Console.Write($"Digite seu nome: ");
            string usuario = Console.ReadLine();
            while ( usuario == null || usuario.Length < 2 ) 
            { 
                Console.WriteLine("O nome digitado é inválido! Tente novamente!");
                Console.WriteLine();
                Console.Write($"Digite seu nome: ");
                usuario = Console.ReadLine();
            }

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine($"Bom dia {usuario}!");
            }
            if (DateTime.Now.Hour < 18)
            {
                Console.WriteLine($"Boa tarde {usuario}!");
            }
            else
            {
                Console.WriteLine($"Boa noite {usuario}!");
            }
        }
    }
}