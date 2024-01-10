using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        
        double number2 = Convert.ToDouble(Console.ReadLine());

        
        double sum = number1 + number2;

        
        Console.WriteLine($"The sum of {number1} and {number2} is: {sum}");
        
    }
}