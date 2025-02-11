// alternatingChars

using System;

public class alternatingChars
{
    public static void Main(string[] args)
    {
        Console.WriteLine("First Character: ");
        char firstChar = char.Parse(Console.ReadLine());

        Console.WriteLine("Second Character: ");
        char secondChar = char.Parse(Console.ReadLine());

        Console.WriteLine("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < i; j++)
            {
              Console.Write("-");
            }
            if (i % 2 == 0)
                Console.WriteLine(secondChar);
            
            else
                Console.WriteLine(firstChar);
        }
    }
}
