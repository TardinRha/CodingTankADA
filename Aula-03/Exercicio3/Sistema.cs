using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Sistema
    {
        public List<Senha> Senhas { get; set; } = new();
        public int NumeroPreferencial { get; set; } = 1;
        public int NumeroComum { get; set; } = 1;
        public int OpcaoSelecionada { get; set; }

        public Sistema()
        {
        }

        public string CriarCodigo(string tipo)
        {
            int numeroCodigo;
            char tipoCodigo;
            string Codigo;

            if (tipo == "Preferencial")
            {
                numeroCodigo = NumeroPreferencial;
                tipoCodigo = 'P';
                NumeroPreferencial++;
            }
            else
            {
                numeroCodigo = NumeroComum;
                tipoCodigo = 'C';
                NumeroComum++;
            }

            if (numeroCodigo < 10)
            {
                Codigo = $"{tipoCodigo}00{numeroCodigo}";
            }
            else if (numeroCodigo >= 10 && numeroCodigo < 100)
            {
                Codigo = $"{tipoCodigo}0{numeroCodigo}";
            }
            else
            {
                Codigo = $"{tipoCodigo}{numeroCodigo}";
            }

            return Codigo;
        }
        public void EmitirSenha(int tipoDeSenha)
        {
            var codigo = CriarCodigo(tipoDeSenha == 1 ? "Preferencial" : "Comum");
            var senha = new Senha(codigo);
            Senhas.Add(senha);
            Console.WriteLine($"Nova senha emitida: {senha.CodigoSenha}");
        }
        public void ChamarSenha()
        {
            Console.Clear();
            if (Senhas.Count == 0)
            {
                Console.WriteLine("Não há senhas para serem chamadas");
                return;
            }
            if (Senhas[0].GetTipo() == "Comum")
            {
                var primeiraSenhaPreferencial = Senhas.Find(s => s.GetTipo() == "Preferencial");
                if (primeiraSenhaPreferencial != null)
                {
                    Console.WriteLine("Chamando senha " + primeiraSenhaPreferencial.CodigoSenha);
                    Senhas.Remove(primeiraSenhaPreferencial);
                }
                else
                {
                    Console.WriteLine("Chamando senha " + Senhas[0].CodigoSenha);
                    Senhas.Remove(Senhas[0]);
                }
            }
            else
            {
                Console.WriteLine("Chamando senha " + Senhas[0].CodigoSenha);
                Senhas.Remove(Senhas[0]);
            }
        }
        public void Funcionar()
        {
            do
            {
                try
                {

                    Console.WriteLine("Deseja emitir qual tipo de senha?");
                    Console.WriteLine("1- Senha Preferencial");
                    Console.WriteLine("2- Senha Comum");
                    Console.WriteLine("3- Chamar próxima senha");
                    Console.WriteLine("0- Sair do console");
                    Console.Write("Digite a opção: ");
                    OpcaoSelecionada = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (OpcaoSelecionada == 1 || OpcaoSelecionada == 2)
                    {
                        EmitirSenha(OpcaoSelecionada);
                    }
                    else if (OpcaoSelecionada == 3)
                    {
                        ChamarSenha();
                    }
                } catch(Exception ex)
                {
                    Console.Clear();
                    continue; //Retoma do início ignorando a opção incorreta
                }
            } while (OpcaoSelecionada != 0);
        }
    }
}
