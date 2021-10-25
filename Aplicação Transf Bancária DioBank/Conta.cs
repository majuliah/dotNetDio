using System;

namespace DioBank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }
        private string Cpf { get; set; }


        public Conta(TipoConta tipoConta, double saldo, double credito, string nome, string cpf)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
            this.Cpf = cpf;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * (-1)))
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }
            else
            {
                this.Saldo -= valorSaque;
                Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
                return true;
            }
        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine($"O saldo atual da conta de {this.Nome} é de R${this.Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += " Tipo Conta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "CPF " + this.Cpf + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito + " | ";
            return retorno;
        }
        
    }

}