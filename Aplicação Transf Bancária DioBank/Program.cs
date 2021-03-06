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
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
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
            string entradaNome, entradaCpf;
            double entradaSaldo = 0.0, entradaCredito = 0.0;
            Console.WriteLine("Inserir nova Conta: ");

            Console.WriteLine("Digite 1- Pessoa Física || Digite 2- Pessoa Jurídica");
            entradaTipoConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o nome completo");
            entradaNome = Console.ReadLine();
            
            Console.WriteLine("Entre com o CPF");
            entradaCpf = Console.ReadLine();
            
            Console.WriteLine("Entre com um saldo maior que R$0,00");
            entradaSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com um saldo maior que R$0,00");
            entradaCredito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

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
        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite agora o valor que deseja sacar");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorDeposito);
        }

        private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor para ser depositado: ");
            double valorDepositado = double.Parse(Console.ReadLine());
            
            listContas[indiceConta].Depositar(valorDepositado);
        }

        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor de transferência: ");
            double valorTransferencia = double.Parse(Console.ReadLine());
            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
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
