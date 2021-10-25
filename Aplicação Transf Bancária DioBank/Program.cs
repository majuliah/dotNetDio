using System;
using System.Collections.Generic;

namespace DioBank
{
    class Program
    {
        private static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoEntrada = ObterOpcaoEntrada();

            while (opcaoEntrada.ToUpper() != "X")
            {
                switch (opcaoEntrada)
                {
                    case "1":
                        //ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
                        break;
                    case "C":
                        Console.Clear(); 
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoEntrada = ObterOpcaoEntrada();
            }

            Console.WriteLine("Obrigada por utilizar meu programinha :)");
            Console.ReadLine();
        }

        private static void InserirConta()
        {
            int entradaTipoConta;
            string entradaNome;
            double entradaSaldo, entradaCredito;
            Console.WriteLine("Inserir nova Conta: ");
            
            Console.WriteLine("Digite 1- Pessoa Física || Digite 2- Pessoa Jurídica");
            
            
        }
        

        private static string ObterOpcaoEntrada()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("--Bem Vindo ao StudieBank---");
            Console.WriteLine("-------Entre com a opção----");
            Console.WriteLine("-------1) Listar Contas-----");
            Console.WriteLine("-------2) Criar Conta-------");
            Console.WriteLine("-------3) Transferência-----");
            Console.WriteLine("-------4) Sacar-------------");
            Console.WriteLine("-------5) Depositar---------");
            Console.WriteLine("-------C) Limpa Tela--------");
            Console.WriteLine("-------X) Sair--------------");
            Console.WriteLine(" ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.WriteLine(" ");
            return opcaoEscolhida;
        }
    }
}
