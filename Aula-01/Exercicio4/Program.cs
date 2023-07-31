using System.Globalization;
namespace Exercicio4
{
    //Escreva um programa para calcular a área de um círculo. A área de um círculo é dada pela seguinte fórmula:
    //𝐴 = 𝜋𝑟^2
    //O valor do raio r será digitado pelo usuário(assumir que serão digitados apenas valores positivos).
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularArea();
        }
        public static void CalcularArea() 
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"Área = {area.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}