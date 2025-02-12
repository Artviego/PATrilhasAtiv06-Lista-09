using System;

class Program
{
    static void Main()
    {
        // Criando um vetor para armazenar os 10 nomes
        string[] nomes = new string[10];

        // Solicitando ao usuário para digitar os 10 nomes
        Console.WriteLine("Digite 10 nomes:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º nome: ");
            nomes[i] = Console.ReadLine();
        }

        // Imprimindo a lista de nomes
        Console.WriteLine("\nLista de nomes digitados:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}º nome: {nomes[i]}");
        }
    }
}
