using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePaciente
{
    class Pessoa
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private double cpf { get; set; }
        private double rg { get; set; }
        private string endereco { get; set; }
        private double datanasc { get; set; }
        private int Idade { get; set; }
        private int telefone { get; set; }
        private string email { get; set; }

        Pessoa[] paciente = new Pessoa[4];

        
        public void CadastrarPaciente()
        {
            {
                for (int i = 0; i < paciente.Length; i++)
                {
                    Id = i++;

                    Console.WriteLine("Nome do Paciente {0}: ", i);
                    string nome = Console.ReadLine();

                    //Console.WriteLine("CPF do Paciente {0}: ", i);
                    //cpf = double.Parse(Console.ReadLine());

                    //Console.WriteLine("RG do Paciente {0}: ", i);
                    //rg = double.Parse(Console.ReadLine());

                    //Console.WriteLine("Endereço do Paciente {0}: ", i);
                    //endereco = Console.ReadLine();

                    //Console.WriteLine("Data de Nascimento do Paciente {0}: ", i);
                    //datanasc = double.Parse(Console.ReadLine());

                    Console.WriteLine("Idade do Paciente {0}: ", i);
                    int idade = int.Parse(Console.ReadLine());

                    //Console.WriteLine("Telefone do Paciente {0}: ", i);
                    //telefone = int.Parse(Console.ReadLine());

                    //Console.WriteLine("Email do Paciente {0}: ", i);
                    //email = Console.ReadLine();

                    Console.WriteLine("Paciente {0} Cadastrado com Sucesso!", i);
                    paciente[i] = new Pessoa { Id = i, Nome = nome, Idade = idade };
                }
            }
        }

        private void Listar()
        {
            {
                foreach (var p in paciente)
                {
                    if (p.Idade >= 65)
                    {
                        Console.WriteLine($"{p.Nome} - Atendimento Preferencial");
                    }
                }
                foreach (var p in paciente)
                {
                    if (p.Idade < 65)
                    {
                        Console.WriteLine($"{p.Nome} - Atendimento Comum");
                    }

                }
            }
        }
        public void ListarPaciente()
        {
            Listar();
        }
        public void AtenderPaciente()
        {
            Listar();
        }

        
    public void AlterarDados()
        {
            Listar();
            Console.WriteLine("Selecione o paciente que deseja alterar os dados: ");
            int numpac = int.Parse(Console.ReadLine());
        }
  
    }
}
