using System;
class Primenumber
{
    public static void Main()
    {
        int number = 7, value = 0;
        for (int valueTwo = 1; valueTwo <= number; valueTwo++)
        {
            if (number % valueTwo == 0)
            {
                value++;
            }
        }
        if (value == 2)
        {
            Console.WriteLine("prime number:" + number);
        }
        else
        {
            Console.WriteLine("Not a Prime Number:" + number);
        }
    }
}

