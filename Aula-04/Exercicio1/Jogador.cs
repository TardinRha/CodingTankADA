using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Jogador
    {
        public string Nome { get; set; }
        public char Pedra { get; set; }

        public Jogador(string nome, char pedra) 
        {
            Nome = nome;
            Pedra = pedra;
        }
        public int[] EscolherJogada()
        {
            Console.Write("Qual coluna deseja marcar? ");
            char coluna = char.Parse(Console.ReadLine());
            Console.Write("Qual linha deseja marcar? ");
            char linha = char.Parse(Console.ReadLine());

            int colunaConvert;
            if (coluna == '0') { colunaConvert = 0; }
            else if (coluna == '1') { colunaConvert = 1; }
            else { colunaConvert = 2; }

            int linhaConvert;
            if(linha == 'A') { linhaConvert = 0; }
            else if (linha == 'B') { linhaConvert = 1; }
            else { linhaConvert = 2; }
            
            int[] posicao = new int[2];
            posicao[0] = linhaConvert;
            posicao[1] = colunaConvert;
            return posicao;
        }
    }
}
