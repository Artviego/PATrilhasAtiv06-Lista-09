using System;

class Program
{
    static void Main()
    {
        // Definindo o vetor de inteiros
        int[] vetor = new int[5];

        Console.WriteLine("Digite 5 números para o vetor:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = Convert.ToInt16(Console.ReadLine());
        }

        // Ordenando o vetor em ordem decrescente
        Array.Sort(vetor);  // Ordena em ordem crescente
        Array.Reverse(vetor); // Reverte para ordem decrescente


        Console.WriteLine("Vetor ordenado em ordem decrescente:");
        foreach (int valor in vetor)
        {
            Console.WriteLine(valor);
        }
    }
}
