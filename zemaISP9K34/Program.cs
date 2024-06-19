using System;

public class Program
{
    public static void Main()
    {
        int number1 = 5;
        int number2 = 10;

        int result = Sum(number1, number2);
        Console.WriteLine("The sum is: " + result);
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
