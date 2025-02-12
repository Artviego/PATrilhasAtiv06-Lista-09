using System;

public class Program
{
  public static void Main()
  {
    int[] numMenor = new int[3];
    int menor = 0;

    //Coleta os números inteiros
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine($"Digite o {i + 1}º número inteiro: ");
      numMenor[i] = Convert.ToInt32(Console.ReadLine());
      menor = numMenor
      
      if (menor > numMenor[i])
      {
        menor = numMaior[i];
      }
    }

    Console.WriteLine($"\nO menor número é o {menor}");
    Console.ReadKey(true);
  }
}
