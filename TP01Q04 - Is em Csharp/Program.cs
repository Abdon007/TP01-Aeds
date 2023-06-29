using System;

class program
{
    public static void Main(string[] args)
    {
        string palavra = Console.ReadLine();
        while (palavra != "FIM")
        {
            if (ConfereVogais(palavra))
            {
                Console.Write("SIM ");
            }
            else
            {
                Console.Write("NAO ");
            }

            if (ConfereConsoante(palavra))
            {
                Console.Write("SIM ");
            }
            else
            {
                Console.Write("NAO ");
            }
            if (ConfereInteiro(palavra))
            {
                Console.Write("SIM ");
            }
            else
            {
                Console.Write("NAO ");
            }
            if (ConfereReal(palavra))
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

    static bool ConfereVogais(string palavra)
    {
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] != 'a' && palavra[i] != 'e' && palavra[i] != 'i' && palavra[i] != 'o' && palavra[i] != 'u')
            {
                return false;
            }
        }
        return true;
    }
    static bool ConfereConsoante(string palavra)
    {
        bool contemApenasConsoantes = true;

        for (int i = 0; i < palavra.Length; i++)
        {
            if (char.IsLetter(palavra[i]) && !char.IsWhiteSpace(palavra[i]) && palavra[i] != 'a' && palavra[i] != 'e' && palavra[i] != 'i' && palavra[i] != 'o' && palavra[i] != 'u')
            {
                continue;
            }
            else
            {
                // O caractere não é uma consoante
                contemApenasConsoantes = false;
                break;
            }
        }

        if (contemApenasConsoantes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static bool ConfereInteiro(string palavra)
    {
        if (int.TryParse(palavra, out int num) && num % 1 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    static bool ConfereReal(string palavra)
    {
        int count = 0;
        if (palavra[0] == '.'|| palavra[0] == ',' )
        {
            return true;
        }
        else
        {

            if (Single.TryParse(palavra, out float num))
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == '.')
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    return false;
                }
                return true;
            }
            else{
                return false;
            }
        }


    }
}
