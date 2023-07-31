using System.Diagnostics;
using System.Security.Cryptography;

namespace Exercicio3
{
    //Escreva um programa que faça a leitura de uma frase, que pode ser uma citação, um ditado ou um excerto de um texto.
    //Ao final, escreva a frase digitada e, em uma nova linha, o número de caracteres desta frase.

    internal class Program
    {
        static void Main(string[] args)
        {
            LogarCaracteres();
        }
        public static void LogarCaracteres() 
        {
            Console.WriteLine("Digite seu texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(texto);
            Console.WriteLine($"Quantidade de caracteres no texto: {texto.Length}");
        }
    }
}