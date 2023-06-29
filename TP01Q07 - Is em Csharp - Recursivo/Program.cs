using System;

class program
{
    static void Main(string[] args)
    {
        string palavra = Console.ReadLine();
        while (palavra != "FIM")
        {
            int i = 0;
            int count = 0;
            int tam = palavra.Length;
            if (ConfereVogais(palavra, i, tam))
            {
                Console.Write("SIM ");
            }
            else
            {
                Console.Write("NAO ");
            }
            if (ConfereConsoantes(palavra, i, tam))
            {
                Console.Write("SIM ");
            }
            else
            {
                Console.Write("NAO ");
            }
            if (ConfereInteiro(palavra, i, tam))
            {
                Console.Write("SIM ");
            }
            else
            {
                Console.Write("NAO ");
            }
            if (ConfereReais(palavra, i, tam, count))
            {
                Console.Write("SIM ");
            }
            else
            {
                Console.Write("NAO ");
            }
            palavra = Console.ReadLine();
            Console.WriteLine();
        }
    }
    static bool ConfereVogais(string palavra, int i, int tam)
    {
        if (i == tam)
        {
            return true;
        }
        if (palavra[i] != 'a' && palavra[i] != 'e' && palavra[i] != 'i' && palavra[i] != 'o' && palavra[i] != 'u')
        {
            return false;
        }
        else
        {
            return ConfereVogais(palavra, i + 1, tam);
        }
    }

    static bool ConfereConsoantes(string palavra, int i, int tam)
    {
        if (i == tam)
        {
            return true;
        }
        if (char.IsLetter(palavra[i]) && !char.IsWhiteSpace(palavra[i]) && palavra[i] != 'a' && palavra[i] != 'e' && palavra[i] != 'i' && palavra[i] != 'o' && palavra[i] != 'u')
        {
            return ConfereConsoantes(palavra, i + 1, tam);

        }
        else
        {
            return false;
        }
    }
    static bool ConfereInteiro(string palavra, int i, int tam)
    {
        if (i >= tam)
        {
            return true;
        }
        if (int.TryParse(palavra, out int num) && num % 1 == 0)
        {
            return ConfereInteiro(palavra, i + 1, tam);
        }
        else
        {
            return false;
        }
    }
    static bool ConfereReais(string palavra, int i, int tam, int count)
    {

        if (i >= tam)
        {
            return true;
        }
        if (palavra[0] == '.' || palavra[0] == ',')
        {
            return true;
        }
        if (Single.TryParse(palavra, out float num))
        {
            if (palavra[i] == '.' || palavra[i] == ',')
            {
                count++;
            }
            if (count > 1)
            {
                return false;
            }
            else
            {
                return ConfereReais(palavra, i + 1, tam, count);
            }
        }
        else
        {
            return false;
        }
    }
}