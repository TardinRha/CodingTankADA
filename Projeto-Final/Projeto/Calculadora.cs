using System.Globalization;

namespace Projeto
{
    public class Calculadora
    {
        public string[,] DadosPessoas { get; set; }

        public void Funcionar()
        {
            ReceberDadosPessoas();
            PegarMediaAritmeticaAltura();
            Console.WriteLine("-----------------------------------------------------");
            PegarMediaAtitmeticaPeso();
            Console.WriteLine("-----------------------------------------------------");
            PegarIMCTodos();
            Console.WriteLine("-----------------------------------------------------");
            PegarPessoaMaisAlta();
            Console.WriteLine("-----------------------------------------------------");
            PegarPessoaMaisBaixa();
            Console.WriteLine("-----------------------------------------------------");
            PegarPessoaMaisPesada();
            Console.WriteLine("-----------------------------------------------------");
            PegarPessoaMaisLeve();
            Console.WriteLine("-----------------------------------------------------");
            PegarPessoaComMaiorIMC();
            Console.WriteLine("-----------------------------------------------------");
            PegarPessoaComMenorIMC();
        }
        private void ReceberDadosPessoas()
        {
            DadosPessoas = new string[3, 5]
            {
                { "Ana", "Paulo", "Márcia", "Pedro", "Beatriz" },
                { "1.70", "1.72", "1.62", "1.90", "1.53" },
                { "80", "90", "61", "84", "49" }
            };
        }
        public void PegarMediaAritmeticaAltura()
        {
            double alturaMedia = 0.0;
            int quantidadePessoas = 5;
            for (int i = 0; i < 5; i++)
            {
                alturaMedia += double.Parse(DadosPessoas[1, i], CultureInfo.InvariantCulture);
            }
            alturaMedia /= quantidadePessoas;
            Console.WriteLine($"A média aritmética de altura é {alturaMedia.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
        public void PegarMediaAtitmeticaPeso()
        {
            int pesoMedio = 0;
            int quantidadePessoas = 5;
            for (int i = 0; i < 5; i++)
            {
                pesoMedio += int.Parse(DadosPessoas[2, i]);
            }
            pesoMedio /= quantidadePessoas;
            Console.WriteLine($"A média aritmética de peso é {pesoMedio}.");
        }
        public void PegarIMCTodos()
        {
            double iMC;
            Console.WriteLine("IMC de todas as pessoas:");
            for (int i = 0; i < 5; i++)
            {
                iMC = PegarIMC(i);
                Console.WriteLine($"Nome: {DadosPessoas[0, i]} | IMC: {iMC.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
        public void PegarPessoaMaisAlta()
        {
            string pessoaMaisAlta = "";
            double maiorAltura = 0;
            for (int i = 0; i < 5; i++)
            {
                if (double.Parse(DadosPessoas[1, i], CultureInfo.InvariantCulture) > maiorAltura)
                {
                    maiorAltura = double.Parse(DadosPessoas[1, i], CultureInfo.InvariantCulture);
                    pessoaMaisAlta = DadosPessoas[0, i];
                }
            }
            Console.WriteLine($"A pessoa mais alta é {pessoaMaisAlta} tendo {maiorAltura.ToString("F2", CultureInfo.InvariantCulture)} de altura");
        }
        public void PegarPessoaMaisBaixa()
        {
            string pessoaMaisBaixa = "";
            double menorAltura = 0;
            for (int i = 0; i < 5; i++)
            {
                if (double.Parse(DadosPessoas[1, i]) > menorAltura)
                {
                    menorAltura = double.Parse(DadosPessoas[1, i], CultureInfo.InvariantCulture);
                    pessoaMaisBaixa = DadosPessoas[0, i];
                }
            }
            Console.WriteLine($"A pessoa mais baixa é {pessoaMaisBaixa} tendo {menorAltura.ToString("F2", CultureInfo.InvariantCulture)} de altura");
        }
        public void PegarPessoaMaisPesada()
        {
            string pessoaMaisPesada = "";
            double maiorPeso = 0;
            for (int i = 0; i < 5; i++)
            {
                if (double.Parse(DadosPessoas[2, i]) > maiorPeso)
                {
                    maiorPeso = double.Parse(DadosPessoas[2, i], CultureInfo.InvariantCulture);
                    pessoaMaisPesada = DadosPessoas[0, i];
                }
            }
            Console.WriteLine($"A pessoa mais pesada é {pessoaMaisPesada} tendo {maiorPeso} quilos");
        }
        public void PegarPessoaMaisLeve()
        {
            string pessoaMaisLeve = "";
            double menorPeso = double.Parse(DadosPessoas[2, 0]);
            for (int i = 0; i < 5; i++)
            {
                if (double.Parse(DadosPessoas[2, i]) < menorPeso)
                {
                    menorPeso = double.Parse(DadosPessoas[2, i], CultureInfo.InvariantCulture);
                    pessoaMaisLeve = DadosPessoas[0, i];
                }
            }
            Console.WriteLine($"A pessoa mais leve é {pessoaMaisLeve} tendo {menorPeso} quilos");
        }
        public void PegarPessoaComMaiorIMC()
        {
            double maiorIMC = 0;
            string pessoaMaiorIMC = "";
            for (int i = 0; i < 5; i++)
            {
                if (PegarIMC(i) > maiorIMC)
                {
                    maiorIMC = PegarIMC(i);
                    pessoaMaiorIMC = DadosPessoas[0, i];
                }
            }
            Console.WriteLine($"{pessoaMaiorIMC} é a pessoa com maior IMC sendo ele {maiorIMC.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public void PegarPessoaComMenorIMC()
        {
            double menorIMC = PegarIMC(0);
            string pessoaMenorIMC = "";
            for (int i = 0; i < 5; i++)
            {
                if (PegarIMC(i) < menorIMC)
                {
                    menorIMC = PegarIMC(i);
                    pessoaMenorIMC = DadosPessoas[0, i];
                }
            }
            Console.WriteLine($"{pessoaMenorIMC} é a pessoa com maior IMC sendo ele {menorIMC.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public double PegarIMC(int coluna)
        {
            double iMC = int.Parse(DadosPessoas[2, coluna]) / Math.Pow(double.Parse(DadosPessoas[1, coluna], CultureInfo.InvariantCulture), 2.0);
            return iMC;
        }
    }
}