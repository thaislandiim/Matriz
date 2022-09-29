using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] numero = new int[3, 3];

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine("Insira um número: ");
                numero[linha, coluna] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine(numero[linha, coluna]);
            }
        }
    }
}