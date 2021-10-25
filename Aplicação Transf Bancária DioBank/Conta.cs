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


        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            //este é um método construtor: é chamado na hora de criar o objeto. ele terá os seguintes atributos:

            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
            //this serve para especificar qual instância iremos alterar, é muito específico

            //ele recebe os parâmetros, então na hora de criar um objeto devemos passar estes parâmetros
            //e como é privado, não podemos mudar
        }

        public bool Sacar(double valorSaque)
        {
            //Validação de saldo suficiente:
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
            //passamos o valor da transferência e para qual conta queremos transferir.
            if (this.Sacar(valorTransferencia))
            {
            //reutilizando o método de sacar e o de depositar   
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += " Tipo Conta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito + " | ";
            return retorno;
        }
        
    }

}