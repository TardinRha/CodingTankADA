using System;

namespace Exercicio1
{
    //Escrever um programa que faça a leitura de duas strings, converta-as para inteiro e efetue a sua soma, exibindo o resultado da operação no console com uma mensagem conforme no exemplo abaixo.
    //Não se esqueça de adicionar tratamento de erros ao seu código. |O resultado da soma de “4” com “6” é “10”|
    class Program
    {
        static void Main(string[] args)
        {
            Somar();
        }
        private static void Somar()
        {
            int primeiroValor = ReceberNumero("primeiro");
            int segundoValor = ReceberNumero("segundo");
            Console.WriteLine();
            int soma = primeiroValor + segundoValor;
            Console.WriteLine($"O resultado da soma de {primeiroValor} com {segundoValor} é {soma}");
        }
        private static int ReceberNumero(string posicao)
        {
            //Normalmente usaria o TryCatch porém, com base na aula e no que foi pedido explicitamente nesse exercício,
            // entendi que o TryParse caberia melhor para a resolução e o tratamento de erro.
            bool num;
            int numeroRetorno;
            do
            {
                Console.Write($"Digite o {posicao} valor: ");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out numeroRetorno))
                {
                    num = true;
                }
                else
                {
                    Console.WriteLine("Número inválido. Tente novamente!");
                    num = false;
                }
            } while (num == false);
            return numeroRetorno;
        }
    }
}