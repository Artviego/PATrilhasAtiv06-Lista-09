using System;

public class project
{
  public static void Main()
  {
    int[] numero1 = new int[4];
    int[] numero2 = new int[4];
    int[] soma = new int[4];
    
    for (int i = 0; i < 5; i++)
    {
      Console.Write($"Digite o {i + 1}º número do 1º vetor: ");
      numero1[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int j = 0; j < 5; j++)
    {
      Console.Write($"Digite o {j + 2}º número do 2º vetor: ");
      numero2[j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}