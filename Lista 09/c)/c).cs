using System;

public class Program
{
  public static void Main()
  {
    decimal[] numeroDec  = new decimal[3];
    double[] medias[] = new double[3];

    //Coleta os números decimais
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine($"Digite o {i + 1}º número decimal ");
      numeroDec[i] = Convert.ToDecimal(Console.ReadLine());

      // Calcula a média dos decimais
      medias[i] = (float)(numeroDec[i]/2m);
    }

    // Imprima a listagem com os resultados
    Console.WriteLine($"\nMédia dos números decimais: {medias[i]}");

  }
}