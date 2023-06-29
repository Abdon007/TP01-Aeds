using System;
class Program
{
    public static void Main(string[] args)
    {
        string frase;
        frase = Console.ReadLine();
        while (frase != "FIM")
        {
            int tam = frase.Length;
            int ini = 0;
            int fim = tam - 1;
            Console.WriteLine(recursivo(frase, ini, fim));
            frase = Console.ReadLine();
        }
    }

    public static string recursivo(string frase, int ini, int fim)
    {
        if (ini >= fim)
        {
            return "SIM";
        }
        else
        {
            if (frase[ini] == frase[fim])
            {
                return recursivo(frase, ini + 1, fim - 1);
            }
        }
        return "NAO";
    }
}
