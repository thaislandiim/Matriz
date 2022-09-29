using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[,] numero = new int[5,2];

    for(int linha= 0; linha <5; linha++){
      for(int coluna=0; coluna < 2; coluna ++) {
        Console.WriteLine("Insira um número: ");
        numero[linha, coluna] = Convert.ToInt32(Console.ReadLine());
      }
    }

    Console.WriteLine("O 1° número é: " + numero[0,0] + " e o último número: " + numero[4,1]);
  }
}