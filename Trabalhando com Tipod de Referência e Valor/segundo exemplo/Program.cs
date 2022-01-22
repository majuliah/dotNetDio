using static System.Console;
public class Program
{
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    public static void Main()
    {
       Pessoa p1 = new Pessoa();
       p1.Nome = "Joao Silva";
       p1.Idade = 30;
       p1.Documento = "3546543540";

    var p2 = p1;
    //mesmo que
    Pessoa p3 = p1;


        TrocarNome(p1, "João SIlva Ano");
        WriteLine(@$"
        O novo nome de p1 é {p1.Nome}
        O nome de p2 é {p2.Nome}
        ");

    }

}
