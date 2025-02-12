using System;

public class Program
{
  public static void Main()
  {
    int[] numMaior = new int[3];
    int maior = 0;

    //Coleta os números inteiros
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine($"Digite o {i + 1}º número inteiro: ");
      numMaior[i] = Convert.ToInt32(Console.ReadLine());

      if (numMaior[i] > maior)
      {
        maior = numMaior[i];
      }
    }

    Console.WriteLine($"\nO maior número é o {maior}");
    Console.ReadKey(true);
  }
}
