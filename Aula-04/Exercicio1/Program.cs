using System;

namespace Exercicio1
{
    //O Jogo da Velha (também conhecido como Jogo do Galo ou, ainda, Jogo Três em Linha) é um passatempo bastante popular.
    //Crie/escreva um Jogo da Velha usando uma matriz de caracteres(char) 3x3, de forma que ela seja inicializada com o caractere – (hífen ou sinal de menos). O jogo deve permitir que dois usuários possam jogar.
    //Para fazer a jogada, o programa deve solicitar ao usuário o número da linha(de 1 até 3) e o número da coluna(de 1 até 3), dentre as disponíveis, na qual o jogador deseja posicionar sua pedra.
    //Após a jogada, o programa deve marcar a casa escolhida pelo jogador com um X ou um O, de acordo com o símbolo associado ao jogador daquela jogada.
    //Ao final da partida, caso exista um vencedor, o programa deve exibir uma dentre as mensagens a seguir, de acordo com o resultado do jogo.
    //“Jogador 1 é o Vencedor”
    //“Jogador 2 é o Vencedor”
    //“Partida sem Vencedor!”
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();
            sistema.Funcionar();
        }
    }
}
