using System;

class Program
{
    static void Main()
    {
        
        char[] caracteres = new char[10];

        Console.WriteLine("Digite 10 caracteres:");

        
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Caractere {i + 1}: ");
            caracteres[i] = char.ToLower(Console.ReadKey().KeyChar); 
            Console.WriteLine(); 
        }

        
        int consoantesCount = 0;
        Console.WriteLine("Consoantes inseridas:");
        foreach (char c in caracteres)
        {
            if (char.IsLetter(c) && !"aeiou".Contains(c))
            {
                Console.WriteLine(c);
                consoantesCount++;
            }
        }

        Console.WriteLine($"Total de consoantes lidas: {consoantesCount}");
    }
}
