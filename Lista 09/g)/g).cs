using System;

public class project
{
    public static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] soma = new int[5];

        // Preenche o primeiro vetor
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número do 1º vetor: ");
            vetor1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n");
        // Preenche o segundo vetor
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número do 2º vetor: ");
            vetor2[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Soma dos vetores
        for (int i = 0; i < 5; i++)
        {
            soma[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("\nVetor Soma:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Soma na posição {i + 1}: {soma[i]}");
        }

        Console.ReadKey(true);
    }
}