//Interest Calculator

using System;

public class InterestCalculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter principal amount : ");
        double principalAmount = double.Parse(Console.ReadLine());
        
        Console.Write("Enter rate of interest : ");
        double rateInterest = double.Parse(Console.ReadLine());
        
        Console.Write("Enter time in years : ");
        int timeYears = int.Parse(Console.ReadLine());
        
        double simpleInterest = (principalAmount * rateInterest * timeYears)/100;
        
        Console.Write($"Simple Interest : {simpleInterest}");
         
        
    }
}