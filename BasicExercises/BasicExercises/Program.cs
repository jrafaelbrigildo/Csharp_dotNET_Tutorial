using System;

namespace BasicExercises
{
    class Program
    {
        //Main function
        public static void Main(string[] args)
        {
            //instance of the class named BasicExercise
            BasicExercise basicExercise = new BasicExercise();
            basicExercise.sumOfPrimeNumbers();
        }
    }
}
    //Defining class named BasicExercise
    public class BasicExercise
{
    //methods
    public void helloWorld()
    {
        var message = "Hello World!";
        Console.WriteLine(message);
    }
    public void printName()
    {
        var name = "John Rafael";
        Console.WriteLine("Hi! " + name);
    }
    public void operations()
    {
        var expression1 = -1 + 4 * 6;
        var expression2 = (35 + 5) % 7;
        var expression3 = 14 + -4 * 6 / 11;
        var expression4 = 2 + 15 / 6 * 1 - 7 % 2;

        Console.WriteLine(expression1);
        Console.WriteLine(expression2);
        Console.WriteLine(expression3);
        Console.WriteLine(expression4);
    }
    //swap numbers method
    public void swapNumbers()
    {
        int num1, num2, temp;

        Console.Write("Input first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Input second number: ");
        num2 = int.Parse(Console.ReadLine());
        
        //swapping the value number
        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After Swapping");
        Console.WriteLine("First number: " + num1);
        Console.WriteLine("Second number: " + num2);
    }
    //method to print multiplication table of a number
    public void multiplicationTable()
    {
        int num;

        Console.Write("Enter the number: ");
        num = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= 10; i++)
        {   
            //display multiplication table
            int result = num * i;
            Console.WriteLine(num + " x " + i + " = " + result);
        }
    }
    public void oddNumbers()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
            
        }
    }
    public void sumOfPrimeNumbers()
    {
        int sum = 0;
        int count = 0;
        for (int i = 2; count < 500; i++)
        {
            bool isPrime = true;
            // Check if i is divisible by any number up to its square root
            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break; // No need to continue checking further divisors
                }
            }
            // Only increment sum and count if i is a prime number
            if (isPrime)
            {
                sum += i;
                count++;
            }
        }
        Console.WriteLine($"Sum of the first 500 prime numbers is: {sum}");
    }

}
