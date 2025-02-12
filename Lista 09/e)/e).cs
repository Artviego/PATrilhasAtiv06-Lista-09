using System;

namespace exE
{
  class Program
  {
    public static void Main(string[] args)
    {

      int menor = 0;

      int[] numeros = {4, 2, 8, 2, 15, 7};

      for (int i = 0 ; i < numeros.Length; i++) {
        Console.Write("{0}, ", numeros[i]);
        menor = numeros[i];

        for(int j = 0; j < numeros.Length; j++){

          if (menor > numeros[j]) {
            menor = numeros[j];
          }
        }



      }
      Console.WriteLine("\nO menor é: {0}",menor);

      Console.Write("Press any key to continue . . . ");
      Console.ReadKey(true);
    }
  }
}