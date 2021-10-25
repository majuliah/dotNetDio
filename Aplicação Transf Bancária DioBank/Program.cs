using System;
using System.Collections.Generic;
using System.Globalization;

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
                        ListarContas();
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
            int entradaTipoConta = 0;
            string entradaNome = "", entradaCpf = "";
            double entradaSaldo = 0.0, entradaCredito = 0.0;
            Console.WriteLine("Inserir nova Conta: ");

            while (entradaTipoConta != 1 || entradaTipoConta != 2)
            {
                Console.WriteLine("Digite 1- Pessoa Física || Digite 2- Pessoa Jurídica");
                entradaTipoConta = int.Parse(Console.ReadLine());
            }

            while (entradaNome.Length < 0)
            {
                Console.WriteLine("Entre com o nome completo");
                entradaNome = Console.ReadLine();
            }
            
            while (entradaCpf.Length < 0 && entradaCpf.Length > 10)
            {
                Console.WriteLine("Entre com o CPF");
                entradaCpf = Console.ReadLine();
            }

            while (entradaSaldo < 0.0)
            {
                Console.WriteLine("Entre com um saldo maior que R$0,00");
                entradaSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            while (entradaCredito < 0.0)
            {
                Console.WriteLine("Entre com um saldo maior que R$0,00");
                entradaCredito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome,
                                        cpf: entradaCpf);
            listContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");
            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);
            }
            
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
