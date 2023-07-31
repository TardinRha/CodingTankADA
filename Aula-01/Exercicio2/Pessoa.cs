using System.Globalization;

namespace Exercicio2
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        public Pessoa()
        {
            Console.Write("Digite seu nome completo: ");
            Nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura (0.00): ");
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite seu peso (0.0): ");
            Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public void LogarDados()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Altura: {Altura.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Peso: {Peso.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
