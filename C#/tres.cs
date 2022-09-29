using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[,] numero = new int [3,2];

    for(int linha = 0; linha < 3; linha++){
      for(int coluna = 0; coluna < 2; coluna++){
        if (linha == 0 && coluna == 0) {
          Console.WriteLine("Insira um número: ");
          numero[linha, coluna] = Convert.ToInt32(Console.ReadLine());
        } else {
          if(coluna == 0) {
            numero[linha, coluna] = numero[linha - 1, 1] * 2;
          } else {
            numero[linha, coluna] = numero[linha, coluna -1] * 2;
          }
        }
      }
    }
    Console.WriteLine(numero[0,0] + ", " + numero[0,1] + ", " + numero[1,0] + ", " + numero[1,1] + ", " + numero[2,0] + ", " + numero[2,1]);
  }
}