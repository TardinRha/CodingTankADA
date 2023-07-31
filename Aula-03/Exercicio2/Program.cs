using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Exercicio2
{
    //Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois números N1 por N2, que devem ser lidos do teclado.
    //É importante observar que a máquina que irá executar este programa é capaz de efetuar apenas duas operações matemáticas: adição e subtração.
    //Ou seja, você não poderá usar os operadores de multiplicação, divisão, módulo etc. bem como truncamentos.
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = ReceberNumero();
            double N2 = ReceberNumero();
            Multiplicar(N1, N2);
            Dividir(N1, N2);
        }
        public static void Multiplicar(double N1, double N2)
        {
            double resultado = 0;
            for (int i = 1; i <= N1; i++)
            {
                resultado += N2;
            }
            Console.WriteLine($"A multiplicação dos números é igual a {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public static void Dividir(double N1, double N2)
        {
            int divisao = 0;

            for (int i = 1; N1 >= N2; i++)
            {
                N1 -= N2;
                divisao++;
            }
            Console.WriteLine($"A divisão é igual a {divisao}");
        }
        private static double ReceberNumero()
        {
            bool num;
            double numeroRetorno = 0;
            do
            {
                Console.Write("Entre com um número inteiro ou decimal (0.00): ");
                try
                {
                    numeroRetorno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
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
