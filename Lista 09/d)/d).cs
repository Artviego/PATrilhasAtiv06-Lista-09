using System;

public class Program
{
  public static void Main()
  {
    int[] numMaior = new int[3];

    //Coleta os números decimais
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine($"Digite o {i + 1}º número inteiro: ");
      numMaior[i] = Convert.ToInt(Console.ReadLine());

      int maior = 0;
      if (vetorNum[i] > maior)
      {
        maior = vetorNum[i];
      }
      Console.WriteLine($"\nO maior número é o {maior}");
    }

    Console.ReadKey(true);
  }
}
