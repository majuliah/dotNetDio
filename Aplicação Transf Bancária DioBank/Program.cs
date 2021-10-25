using System;

namespace DioBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 100, 100, "Majulia", "09068787-96");

            Console.WriteLine(minhaConta.ToString());
            

        }
    }
}
