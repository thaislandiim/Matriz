using System;

class Program {
  public static void Main (string[] args) {
    int[,] num = new int[2,2];

    Console.WriteLine("Insira um número: ");
    num[0,0] = Convert.ToInt32(Console.ReadLine());

    for(int linha = 0; linha < 2; linha++) {
      for(int coluna = 0; coluna < 2; coluna++) {
        num[linha, coluna] = num[0,0];
        Console.WriteLine(num[linha, coluna]);
      }
    }
  }
}