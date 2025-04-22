// Currency Converter

using System;

public class CurrencyConverter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter amount in USD : ");
        double amount = double.Parse(Console.ReadLine());
        
        Console.Write("Enter exchange rate from USD to EUR : ");
        double rate = double.Parse(Console.ReadLine());
        
        double EUR = amount * rate;
        
        Console.Write($"Amount in EUR : {EUR}");
    }
}