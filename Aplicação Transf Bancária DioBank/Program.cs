using System;


namespace DioBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 100, 100, "Majulia");

            Console.WriteLine(minhaConta.ToString());
            

        }
    }
}
