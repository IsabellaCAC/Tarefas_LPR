using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numero = new();
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        numeros.Add(4);
        numeros.Insert(4, 7);

        bool contem8 = numeros.Contains(8);
        Console.WriteLine("Contém o numero 8? " + contem8);

        int numMaiorQue4 = 0;

        foreach (int n in numeros)
        {
            if (n > 4)
            {
                numMaiorQue4++;
                Console.WriteLine("Sao maiores que 4: " + n);
            }
        }
        int repete;
        foreach (int n in numeros) 
        {
            if (i==3) repete++;
            Console.WriteLine(repete);
        }

        numeros.Remove(2);

        while (numeros.Contains(4)) numeros.Remove(4);

        numeros.Remove(4);
        numeros.Clear();








    }

}

