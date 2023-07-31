using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Senha
    {
        public string CodigoSenha { get; set; }

        public Senha(string codigoSenha) 
        {
            CodigoSenha = codigoSenha;
        }
        public string GetTipo()
        {
            if(CodigoSenha[0] == 'P')
            {
                return "Preferencial";
            }
            return "Comum";
        }
    }
}
