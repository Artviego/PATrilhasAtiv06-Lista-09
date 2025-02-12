
using System;

public class Program
{
  public static void Main()
  {
    decimal[] numeroDec = new decimal[3];

    //Coleta os números decimais
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine($"Digite o {i + 1}º número decimal ");
      numeroDec[i] = Convert.ToDecimal(Console.ReadLine());

      double soma = 0;
      foreach([i] in numeroDec[3])
      {
        soma += [i];
      }
    }

    //Calculando a média
    decimal media = soma/2;

    //Exibe o resultado
    Console.WriteLine($"\nA média dos decimais somado é de: {media}");
  }
}
