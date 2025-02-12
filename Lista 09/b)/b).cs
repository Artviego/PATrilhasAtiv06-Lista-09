using System;

class Program
{
    static void Main()
    {
      string[] nomes = new string[5];
      double[,] notas = new double[5, 2];
      double[] medias = new double[5];


      //Coleta os dados dos alunos
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine($"Digite o nome do {i + 1}º aluno: ");
        nomes[i] = Console.ReadLine();

        Console.WriteLine($"Digite a primeira nota de {nomes[i]}: ");
        notas[i, 0] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Digite a segunda nota de {nomes[i]}: ");
        notas[i, 1] = Convert.ToDouble(Console.ReadLine());

        // Calcula a média
        medias[i] = (notas[i, 0] + notas[i, 1]) / 2;
      }

      // Imprima a listagem com os resultados
      Console.WriteLine("\nRelatório de notas dos alunos: ");
      Console.WriteLine("Nome\t\tNota 1\tNota 2 \tMédia");


      for (int i = 0; i < 5; i++)
      {
         Console.WriteLine($"{nomes[i]}\t{notas[i, 0]}\t{notas[i, 1]}\t{medias[i]:F2}");
      }
    }
}
