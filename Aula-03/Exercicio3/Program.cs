using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercicio3
{
    //Um pequeno Banco precisa de um sistema de distribuição de senhas para seus clientes. Esse sistema deve apresentar um menu com as seguintes opções:
    //• Emitir Senha Preferencial
    //• Emitir Senha Comum
    //• Chamar Próxima Senha
    //• Sair
    //Ao emitir as senhas, o sistema deve informar na tela a senha que foi emitida.
    //As senhas preferenciais são formadas com a letra P seguida de uma sequência de um número sequencial de 3 casas.
    //Por exemplo, a primeira senha preferencial que deve ser emitida será a P001.
    //As senhas comuns seguem uma regra parecida, exceto pelo fato de que começam com a letra C.
    //Por exemplo, a primeira senha comum a ser emitida será a C001, a seguir será a vez da senha C002 e assim por diante.
    //Ao selecionar a opção Chamar Próxima Senha, o sistema deverá chamar a próxima senha que deverá ser atendida.Como o nome sugere, as senhas preferenciais devem ser atendidas antes das senhas comuns.
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema(); //Cria o sistema de gestão de senhas
            sistema.Funcionar();
        }
    }
}
