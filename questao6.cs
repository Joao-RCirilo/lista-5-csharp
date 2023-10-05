using System;

class Program
{
    static void Main()
    {
        // Número de alunos
        int numeroDeAlunos = 10;

        // Vetor para armazenar as médias dos alunos
        double[] medias = new double[numeroDeAlunos];

        Console.WriteLine("Digite as quatro notas de cada aluno:");

        // Loop para ler as notas e calcular as médias
        for (int i = 0; i < numeroDeAlunos; i++)
        {
            double somaNotas = 0;

            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Aluno {i + 1}, Nota {j + 1}: ");
                double nota = double.Parse(Console.ReadLine());
                somaNotas += nota;
            }

            medias[i] = somaNotas / 4;
        }

        // Contagem de alunos com média maior ou igual a 7.0
        int contadorAlunosAprovados = 0;

        foreach (double media in medias)
        {
            if (media >= 7.0)
            {
                contadorAlunosAprovados++;
            }
        }

        // Imprimir o número de alunos aprovados
        Console.WriteLine($"\nNúmero de alunos com média maior ou igual a 7.0: {contadorAlunosAprovados}");
    }
}

