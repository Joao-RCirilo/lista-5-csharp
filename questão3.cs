using System;

class Program
{
    static void Main()
    {
        
        double[] notas = new double[4];

        Console.WriteLine("Digite as 4 notas:");

      
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

       
        double soma = 0;
        foreach (double nota in notas)
        {
            soma += nota;
        }
        double media = soma / 4;

       
        Console.WriteLine("As notas inseridas são:");
        foreach (double nota in notas)
        {
            Console.WriteLine(nota);
        }
        Console.WriteLine($"A média das notas é: {media:F2}");
    }
}
