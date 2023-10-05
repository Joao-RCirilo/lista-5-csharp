using System;

class Program
{
    static void Main()
    {
        // Criar um vetor para armazenar os números reais
        double[] vetor = new double[10];

        Console.WriteLine("Digite 10 números reais:");

        // Pedir ao usuário para inserir 10 números reais
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        // Mostrar os números reais na ordem inversa
        Console.WriteLine("Os números reais na ordem inversa são:");
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(vetor[i]);
        }
    }
}
