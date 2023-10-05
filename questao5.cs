using System;

class Program
{
    static void Main()
    {
        // Tamanho dos vetores
        int tamanho = 20;

        // Vetor para armazenar os 20 números inteiros
        int[] numeros = new int[tamanho];

        // Vetores para armazenar números pares e ímpares
        int[] pares = new int[tamanho];
        int[] impares = new int[tamanho];

        Console.WriteLine("Digite 20 números inteiros:");

        // Ler os números inteiros e armazená-los no vetor
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int contadorPares = 0;
        int contadorImpares = 0;

        // Separar números pares e ímpares
        for (int i = 0; i < tamanho; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares[contadorPares] = numeros[i];
                contadorPares++;
            }
            else
            {
                impares[contadorImpares] = numeros[i];
                contadorImpares++;
            }
        }

        // Imprimir os três vetores
        Console.WriteLine("\nNúmeros digitados:");
        ImprimirVetor(numeros);

        Console.WriteLine("\nNúmeros pares:");
        ImprimirVetor(pares, contadorPares);

        Console.WriteLine("\nNúmeros ímpares:");
        ImprimirVetor(impares, contadorImpares);
    }

    // Função para imprimir um vetor
    static void ImprimirVetor(int[] vetor, int tamanho = -1)
    {
        if (tamanho == -1)
        {
            tamanho = vetor.Length;
        }

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine(vetor[i]);
        }
    }
}
