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
        
    }
    
}