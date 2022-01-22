using static System.Console;
public class Program
{
    static int Adicionar20(int x)
    {
        return x + 20;
    }
    public static void Main()
    {
        int a = 2;
        Adicionar20(a);

        WriteLine($"Valor da variável a é {a}");
    }

}
