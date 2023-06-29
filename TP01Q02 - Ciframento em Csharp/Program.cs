using System;

class Program
{
    static void Main(string[] args)
    {

        int numcar = 0, num = 0;

        string txt1 = Console.ReadLine();
        while (txt1 != "FIM")
        {
            Console.WriteLine(Codifica(txt1, numcar, num));
            txt1 = Console.ReadLine();
        }
    }

    static string Codifica(string txt1, int numcar, int num)
    {
        numcar = txt1.Length;
        string txt2 = "";

        for (int i = 0; i < numcar; i++)
        {
            txt2 += (char)(Convert.ToInt32(txt1[i]) + 3);
        }
        return txt2;
    }
}