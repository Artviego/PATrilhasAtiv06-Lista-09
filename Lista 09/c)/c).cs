
using System;

public class Program
{
  public static void Main()
  {
    decimal[] numeroDec = new decimal[3];
    decimal soma = 0;

    //Coleta os números decimais
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine($"Digite o {i + 1}º número decimal ");
      numeroDec[i] = Convert.ToDecimal(Console.ReadLine());
      soma += numeroDec[i];
    }

    //Calculando a média
    decimal media = soma / 3;

    //Exibe o resultado
    Console.WriteLine($"\nA média dos decimais é: {media}");
  }
}
