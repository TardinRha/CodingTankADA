using System;

namespace Exercicio2
{
    //Escreva um programa que faça a leitura do nome, da idade, da altura e e do peso do usuário. Após isso, escreva cada uma das informações em uma linha no console.
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new();
            pessoa.LogarDados();
        }
    }
}