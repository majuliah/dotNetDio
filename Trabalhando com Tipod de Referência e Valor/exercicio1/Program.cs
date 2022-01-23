using static System.Console;
public class Program
{

    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
                return i;   
        }
        return -1;
    }
    public static void Main(){

        int[] numeros = new int[] {0, 1, 2, 3, 4, 5};
        WriteLine("Digite o número que gostaria de entrar");
        int numero = int.Parse(ReadLine());

        int indexEncontrado = EncontrarNumero(numeros, numero);
        WriteLine($"O número encontrado está na posição {indexEncontrado}");
    }
    


}
