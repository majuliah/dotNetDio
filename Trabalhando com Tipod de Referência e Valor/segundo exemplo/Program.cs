using static System.Console;
public class Program
{

    static void Demo2()
    {
       Pessoa p1 = new Pessoa();
       p1.Nome = "Joao Silva";
       p1.Idade = 30;
       p1.Documento = "3546543540";

    var p2 = p1;
    //mesmo que
    Pessoa p3 = p1;

    Pessoa p4 = p1.Clone();


        TrocarNome(p1, "João SIlva Ano");
        WriteLine(@$"
        O novo nome de p1 é {p1.Nome}
        O nome de p2 é {p2.Nome}
        ");

    
    }

    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "44646563",
            Idade = 30,
            Nome = "Marajulha Carvalho"
        };

        StructPessoa p = default;
           p.Documento = "6563";
           p.Idade = 22;
           p.Nome = "Marajulha Alves";

        var p2 = p1;

        TrocarNome(p1, "Joaquina Lima");
        WriteLine(@$"
        Nome do p1 {p1.Nome}
        Nome do p2 {p2.Nome}
        ");

    }

    static void demo4()
    {
        string nome = "Marajulia";
        TrocarNome(nome, "Carla");

        WriteLine(@$"O novo nome é {nome}");

    }
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static void TrocarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)        
        {
            pares[i] += 1;    
        }
    }
    public static void Main()
    {
        int[] pares = new int[]{0, 2, 4, 6, 8};

        MudarParaImpar(pares);
        WriteLine(@$"Os impares {string.Join(", ", pares)}");

    }

}
