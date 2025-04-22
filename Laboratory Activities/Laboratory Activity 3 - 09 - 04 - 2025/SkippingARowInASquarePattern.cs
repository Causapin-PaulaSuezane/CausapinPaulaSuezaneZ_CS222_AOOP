// SkippingARowInASquarePattern

using System;

public class SkippingARowInASquarePattern
{
    public static void Main(string[] args)
    {
        Console.Write("Enter n : ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Enter y : ");
        int y = int.Parse(Console.ReadLine());
        
        Console.WriteLine();

         for (int i = 1; i <= n; i++)
        {
            if (i == y)
            {
                Console.WriteLine();
                continue;
            }

            for (int j = 1; j <= n; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}