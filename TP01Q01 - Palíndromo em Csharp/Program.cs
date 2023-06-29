using System;

class program
{
    public static void Main(string[] args)
    {
        Console.Write("Numero a ser multiplicado: ");
        int num = int.Parse(Console.ReadLine()!);
        Console.Write("Quantas vezes esse número será multiplicado: ");
        int vezes = int.Parse(Console.ReadLine()!);
        int resultado = Mult_somando(num, vezes);
        Console.Write( "{0} x {1} = {2}", num, vezes, resultado);
    }
    static int Mult_somando(int x, int y){
       if(y==0){

        return 0;
       }

        if(y==1){

        return x;
        }

        else{
            return x + Mult_somando(x,y-1);
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
    }
}