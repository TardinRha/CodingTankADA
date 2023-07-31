using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Projeto
{
    class Program
    {
        //Dada a matriz "..."
        //Faça um programa que escreva no console:
        //A média aritmética de altura
        //A média aritmética de peso
        //O nome e IMC de cada uma das pessoas
        //O nome da pessoa mais alta e sua altura
        //O nome da pessoa mais baixa e sua altura
        //O nome da pessoa mais pesada e seu peso
        //O nome da pessoa mais leve e seu peso
        //O nome da pessoa com o maior IMC e seu valor
        //O nome da pessoa com o menor IMC e seu valor
        //Considere o cálculo do IMC como: IMC = (altura* altura) / peso
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Funcionar();
        }
    }
}