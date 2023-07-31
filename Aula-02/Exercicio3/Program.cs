using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace Exercicio3
{
    //Escreva um programa que faça a leitura de 5 valores Inteiros.
    //Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares, quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos.
    //Cada uma das informações deve ser escrita em uma linha diferente.
    class Program
    {
        static void Main(string[] args)
        {
            Categorizar();
        }
        private static void Categorizar()
        {
            List<int> numeros = new()
            {
                ReceberNumero("primeiro"),
                ReceberNumero("segundo"),
                ReceberNumero("terceiro"),
                ReceberNumero("quarto"),
                ReceberNumero("quinto")
            };

            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;
            //Considerei 0 como número par e neutro, por esse motivo, ele não vai ser considerado positivo nem negativo.
            foreach (int n in numeros)
            {
                if (n % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                if (n > 0)
                {
                    positivos++;
                }
                if (n < 0) //Aqui é um if para não considerar o 0, o que aconteceria se fosse um else.
                {
                    negativos++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Numeros Pares: {pares}");
            Console.WriteLine($"Numeros Ímpares: {impares}");
            Console.WriteLine($"Numeros Positivos: {positivos}");
            Console.WriteLine($"Numeros Negativos: {negativos}");
        }
        private static int ReceberNumero(string posicao)
        {
            bool num;
            int numeroRetorno = 0;
            do
            {
                Console.Write($"Entre com o {posicao} valor: ");
                try
                {
                    numeroRetorno = int.Parse(Console.ReadLine());
                    num = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Número inválido. Tente novamente!");
                    num = false;
                }
            } while (num == false);
            return numeroRetorno;
        }
    }
}
