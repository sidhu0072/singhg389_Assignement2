using System;

class Program
{
    static void Main(string[] args)
    {
        int sumEven = 0;
        int sumOdd = 0;

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is an even number");
                sumEven += i;
            }
            else
            {
                Console.WriteLine($"{i} is an odd number");
                sumOdd += i;
            }
        }

        Console.WriteLine($"Total of even numbers: {sumEven}");
        Console.WriteLine($"Total of odd numbers: {sumOdd}");
    }
}
