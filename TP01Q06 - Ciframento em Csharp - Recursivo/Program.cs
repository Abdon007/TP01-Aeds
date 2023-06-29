using System;
class program{
    public static void Main(string []args){
        string palavra;
        string cifra = "";
        palavra = Console.ReadLine();
        while(palavra != "FIM"){
            int i = 0;
            int tam = palavra.Length;
            Console.WriteLine(Ciframento(palavra,i,tam,cifra));
            palavra = Console.ReadLine();
        }
    }

    static string Ciframento(string palavra,int i, int tam, string cifra){
        if(i == tam ){
            return cifra;
        }
        else{
            cifra += (char)(Convert.ToInt32(palavra[i])+3);
            cifra = Ciframento(palavra,i+1,tam,cifra);
        }
        return cifra;
    }
}