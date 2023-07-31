using System;

namespace Exercicio1
{
    //Um número inteiro positivo é dito triangular se este for o resultado do produto de três números naturais consecutivos.
    //Por exemplo, o número 120 é triangular, dado que 120 = 4 ∗ 5 ∗ 6.
    //Escreva um programa que faça a leitura de um número inteiro e verifique se o número é ou não triangular.
    //Se o número for triangular, o programa deve apresentar a mensagem “O número “{ número}” é triangular”. Caso contrário, a mensagem deve ser “O número “{número}” NÃO é triangular”.
    //Sendo que, em ambos os casos, {número} é o número informado pelo usuário, conforme exemplo abaixo.
    //O número “120” é triangular.
    class Program
    {
        static void Main(string[] args)
        {
            ConferirTriangular();
        }
        public static void ConferirTriangular() 
        {
            int numeroInteiro = ReceberNumero();
            int primeiroNatural = 1, segundoNatural = 2, terceiroNatural = 3;
            int resultado = 0;
            for(int i = 0; resultado < numeroInteiro; i++) 
            {
                resultado = primeiroNatural * segundoNatural * terceiroNatural;
                primeiroNatural++;
                segundoNatural++;
                terceiroNatural++;
            }
            if(resultado == numeroInteiro) 
            {
                Console.WriteLine($"O número {numeroInteiro} é triangular");
            }
            else 
            {
                Console.WriteLine($"O número {numeroInteiro} não é triangular");
            }
        }
        private static int ReceberNumero()
        {
            bool num;
            int numeroRetorno = 0;
            do
            {
                Console.Write("Entre com um número inteiro: ");
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
