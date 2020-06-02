using System;

namespace Studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            string userInput = Console.ReadLine();
            float radius = float.Parse(userInput);
            Console.WriteLine("The area of a circle of radius " + userInput + " is: " + (Math.PI * radius * radius));
            Console.WriteLine("The diameter of a circle of radius " + userInput + " is: " + (2 * radius));
            Console.WriteLine("The circumference of a circle of radius " + userInput + " is: " + (Math.PI * 2 * radius));
            Console.WriteLine("How many miles per gallon in your car? ");
            string userInput1 = Console.ReadLine();
            int mpg = int.Parse(userInput1);
            Console.WriteLine("The gallons used to travel around the circle with the radius " + userInput + " is: " + ((Math.PI * 2 * radius) / mpg));
        }
    }
}
