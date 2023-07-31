using System;
using System.Globalization;

namespace Exercicio4
{
    //Escreva um programa que faça a leitura da nota de um aluno, que pode variar de 0 a 10, com até duas casas decimais.Em seguida, o programa deve exibir o “Conceito” de aproveitamento do aluno na disciplina.O conceito é dado de acordo com a tabela a seguir.
    //Intervalo de Nota    Conceito
    // de 8.00 a 10.00      Ótimo
    // de 6.00 a 7.99       Bom
    // de 4.00 a 5.99       Regular
    // de 0.00 a 3.99       Péssimo
    class Program
    {
        static void Main(string[] args)
        {
            CalcularConceito();
        }
        private static void CalcularConceito() 
        {
            bool num;
            double notaAluno = 0;
            do
            {
                Console.Write("Entre com a nota do aluno (0.00): ");
                try
                {
                    notaAluno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if(notaAluno < 0)
                    {
                        throw new Exception("Erro: nota não pode ser inferior a 0!");
                    }
                    num = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Número inválido. Tente novamente!");
                    num = false;
                }
            } while (num == false);

            Console.WriteLine();
            ConceituarNota(notaAluno);
        }
        private static void ConceituarNota(double notaAluno) 
        {
            if (notaAluno < 4.00)
            {
                Console.WriteLine("Conceito: Péssimo");
            }
            else if (notaAluno < 6.00)
            {
                Console.WriteLine("Conceito: Regular");
            }
            else if (notaAluno < 8.00)
            {
                Console.WriteLine("Conceito: Bom");
            }
            else { Console.WriteLine("Conceito: Ótimo"); }
        }
    }
}
