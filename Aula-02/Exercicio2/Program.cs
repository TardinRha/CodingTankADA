using System;
namespace Exercicio2
{
    //Escreva um programa que faça a leitura de 4 valores inteiros A, B, C e D.
    //A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par, o programa deve escrever na saída padrão (“Console”) a mensagem "Valores Aceitos".
    //Caso contrário, deve escrever "Valores Não Aceitos"
    class Program
    {
        static void Main(string[] args)
        {
            Comparar();
        }
        private static void Comparar()
        {
            int A = ReceberNumero("primeiro");
            int B = ReceberNumero("segundo");
            int C = ReceberNumero("terceiro");
            int D = ReceberNumero("quarto");
            
            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }
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
