// TheFinalTotal


using System;

public class TheFinalTotal
{
    public static void Main(string[] args)
    {
        Console.Write("Enter an integer : ");
        int num = int.Parse(Console.ReadLine());
        
        int total = 10;
        
        if (num > 1){
            if (num % 2 == 0){
                Console.WriteLine("The number is even. ");
                total =  total + (num*num);
                Console.WriteLine(total);
            } else if (num % 2 == 1) {
                Console.WriteLine("The number is odd. ");
                total = total + (num*num*num);
                Console.WriteLine(total);
            }
        }else if (num < 0) {
            Console.Write("Enter another integer : ");
            int num2 = int.Parse(Console.ReadLine());
            total = total + (int)Math.Pow(num, num2);
            Console.WriteLine(total);
        }else {
             Console.WriteLine("Nothing hanppened.");
        }
    }
}