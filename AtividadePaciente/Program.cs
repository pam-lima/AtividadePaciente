using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePaciente
{
    internal class Program
    {
     
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu de Opções");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1 - Cadastro de Pacientes");
            Console.WriteLine("2 - Listar Pacientes");
            Console.WriteLine("3 - Atender Pacientes");
            Console.WriteLine("4 - Alterar Dados do Paciente");
            Console.WriteLine("Q - Sair");
            Console.WriteLine("--------------------------");
        }

        static void Continuar()
        {
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Pessoa paciente = new Pessoa();
            //paciente.CadastrarPaciente();
            //paciente.ListarPaciente();
            //paciente.AtenderPaciente();
            //paciente.AlterarDados();

            bool continuar = true;

            while (continuar)
            {
                Menu();
                string opcao = Console.ReadLine();
                if (int.Parse(opcao) == 1)
                {
                    Console.WriteLine("1 - Cadastro de Pacientes");
                    paciente.CadastrarPaciente();
                } 
                else if (int.Parse(opcao) == 2)
                {
                    Console.WriteLine("2 - Listar Pacientes");
                    paciente.ListarPaciente();
                    Continuar();
                }
                else if (int.Parse(opcao) == 3)
                {
                    Console.WriteLine("3 - Atender Pacientes");
                    paciente.AtenderPaciente();
                    Continuar();
                }
                else if (int.Parse(opcao) == 4)
                {
                    Console.WriteLine("4 - Alterar Dados do Paciente");
                    paciente.AlterarDados();
                    Continuar();
                }
                else if (opcao[0] == 'Q' || opcao[0] == 'q')
                {
                    Console.WriteLine("Sair");
                    continuar = false;
                }
                else { Console.WriteLine("Opção Inválida"); }
            } 
        }
    }
}
