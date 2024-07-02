using System;

namespace BasicExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            BasicExercise basicExercise = new BasicExercise();
            basicExercise.helloWorld();
            basicExercise.printName();
            basicExercise.operations();
        }
    }
}
    public class BasicExercise
    {
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
}
