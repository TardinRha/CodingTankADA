using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Sistema
    {
        public Jogo Jogo { get; set; } = new Jogo();
        public int OpcaoSelecionada = 1;

        public void Funcionar()
        {
            GerarTabuleiro();
            MostrarTabuleiro();
            do
            {
                Console.WriteLine();
                MarcarOpcaoJogador("JOGADOR 1");
                if (ConferirGanhador() == 0) { break; };
                Console.WriteLine();
                MarcarOpcaoJogador("JOGADOR 2");
                if (ConferirGanhador() == 0) { break; };
            } while (OpcaoSelecionada != 0);
        }
        public void GerarTabuleiro()
        {
            Jogo.Tabuleiro[0, 0] = '-';
            Jogo.Tabuleiro[0, 1] = '-';
            Jogo.Tabuleiro[0, 2] = '-';
            Jogo.Tabuleiro[1, 0] = '-';
            Jogo.Tabuleiro[1, 1] = '-';
            Jogo.Tabuleiro[1, 2] = '-';
            Jogo.Tabuleiro[2, 0] = '-';
            Jogo.Tabuleiro[2, 1] = '-';
            Jogo.Tabuleiro[2, 2] = '-';
        }
        public void MostrarTabuleiro()
        {
            Console.WriteLine("    0   1   2  ");
            Console.WriteLine($"A | {Jogo.Tabuleiro[0, 0]} | {Jogo.Tabuleiro[0, 1]} | {Jogo.Tabuleiro[0, 2]} |");
            Console.WriteLine($"B | {Jogo.Tabuleiro[1, 0]} | {Jogo.Tabuleiro[1, 1]} | {Jogo.Tabuleiro[1, 2]} |");
            Console.WriteLine($"C | {Jogo.Tabuleiro[2, 0]} | {Jogo.Tabuleiro[2, 1]} | {Jogo.Tabuleiro[2, 2]} |");
        }
        public void MarcarOpcaoJogador(string jogador)
        {
            bool tentarNovamente = true;
            do
            {
                try
                {
                    Console.WriteLine(jogador);
                    if (jogador == "JOGADOR 1")
                    {
                        int[] posicao = Jogo.Jogador1.EscolherJogada();
                        if (Jogo.Tabuleiro[posicao[0], posicao[1]] == '-') //Confere se a posição está disponível
                        {
                            Jogo.Tabuleiro[posicao[0], posicao[1]] = Jogo.Jogador1.Pedra;
                            MostrarTabuleiro();
                            tentarNovamente = false;
                        }
                        else
                        {
                            Console.WriteLine("Posição já escolhida anteriormente!");
                            Console.WriteLine();
                            tentarNovamente = true;
                        }
                    }
                    else 
                    {
                        int[] posicao = Jogo.Jogador2.EscolherJogada();
                        if (Jogo.Tabuleiro[posicao[0], posicao[1]] == '-')
                        {
                            Jogo.Tabuleiro[posicao[0], posicao[1]] = Jogo.Jogador2.Pedra;
                            MostrarTabuleiro();
                            tentarNovamente = false;
                        }
                        else
                        {
                            Console.WriteLine("Posição já escolhida anteriormente!");
                            Console.WriteLine();
                            tentarNovamente = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    continue; //Retoma do início ignorando a opção incorreta
                }
            } while (tentarNovamente == true);
        }
        public int ConferirGanhador()
        {
            char? pedraGanhadora = VerificarLinhas() ?? VerificarColunas() ?? VerificarDiagonais();
            if (pedraGanhadora == 'X')
            {
                Console.WriteLine($"JOGADOR 1 VENCEU!!");
                return 0;
            }
            else if (pedraGanhadora == 'O')
            {
                Console.WriteLine($"JOGADOR 2 VENCEU!!");
                return 0;
            }
            else
            {
                bool tabuleiroCheio = VerificarTabuleiroCheio();
                if (tabuleiroCheio)
                {
                    Console.WriteLine("Partida sem vencedor!");
                    return 0;
                }
            }
            return 1;
        }
        private char? VerificarLinhas()
        {
            for (int i = 0; i < 3; i++)
            {
                if (Jogo.Tabuleiro[i, 0] == Jogo.Tabuleiro[i, 1] && Jogo.Tabuleiro[i, 1] == Jogo.Tabuleiro[i, 2])
                {
                    return Jogo.Tabuleiro[i, 0];
                }
            }
            return null;
        }
        private char? VerificarColunas()
        {
            for (int i = 0; i < 3; i++)
            {
                if (Jogo.Tabuleiro[0, i] == Jogo.Tabuleiro[1, i] && Jogo.Tabuleiro[1, i] == Jogo.Tabuleiro[2, i])
                {
                    return Jogo.Tabuleiro[0, i];
                }
            }
            return null;
        }
        private char? VerificarDiagonais()
        {
            if (Jogo.Tabuleiro[0, 0] == Jogo.Tabuleiro[1, 1] && Jogo.Tabuleiro[1, 1] == Jogo.Tabuleiro[2, 2])
            {
                return Jogo.Tabuleiro[0, 0];
            }

            if (Jogo.Tabuleiro[0, 2] == Jogo.Tabuleiro[1, 1] && Jogo.Tabuleiro[1, 1] == Jogo.Tabuleiro[2, 0])
            {
                return Jogo.Tabuleiro[0, 2];
            }
            return null;
        }
        private bool VerificarTabuleiroCheio()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Jogo.Tabuleiro[i, j] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
