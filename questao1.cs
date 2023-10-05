using System;

class Program
{
    static void Main()
    {

        int[] vetor = new int[5];

        Console.WriteLine("Digite 5 números:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Os números são:");
        foreach (int numero in vetor)
        {
            Console.WriteLine(numero);
        }
    }
}