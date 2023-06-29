using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("valores: m e d");
        string palavra = Console.ReadLine();
        while (palavra != "FIM")
        {
            Console.WriteLine(TrocaLetra(palavra));
            palavra = Console.ReadLine();
        }
    }

    static string TrocaLetra(string palavra)
    {
        string nova_palavra = "";
        Random gerador = new Random(4);

        Char letra1 = (char)('a'+ Math.Abs(gerador.Next() % 26));

        Char letra2 = (char)( 'a' + Math.Abs(gerador.Next() % 26));


        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] == letra1)
            {
                nova_palavra += letra2;
            }
            else
            {
                nova_palavra += palavra[i];
            }
        }
        return nova_palavra;
    }
}