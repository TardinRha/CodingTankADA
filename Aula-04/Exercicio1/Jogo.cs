using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Jogo
    {
        public Jogador Jogador1 { get; set; } = new("Jogador 1", 'X');
        public Jogador Jogador2 { get; set; } = new("Jogador 2", 'O');
        public char[,] Tabuleiro { get; set; } = new char[3, 3];
    }
}
