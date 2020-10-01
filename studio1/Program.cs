using System;

namespace studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            string radiusInput = Console.ReadLine();
            //convert user input to type double
            double number;

            if (radiusInput == "" || !Double.TryParse(radiusInput, out number))
            {
                Console.WriteLine("That does not work for the radius!");
                Environment.Exit(0);
            }

            double radius = double.Parse(radiusInput);

            //while (radius < 0.0)
            //{
            //    Console.WriteLine("You can't have a negative radius! Give it another try!");
            //    radiusInput = Console.ReadLine();
            //    radius = Double.Parse(radiusInput);
            //}

            do
            {
                Console.WriteLine("You can't have a negative radius! Give it another try!");
                radiusInput = Console.ReadLine();
                radius = Double.Parse(radiusInput);

            } while (radius < 0.0);

            double area = Math.PI * radius * radius;
            area = Math.Round(area, 3);
            Console.WriteLine($"The area of a circle with {radius} radius is {area}.");
            //Console.WriteLine("The area of a circle with " + radius + " radius is " + area + ".");

            double circumference = Math.PI * 2 * radius;
            circumference = Math.Round(circumference, 3);
            double diameter = 2 * radius;
            diameter = Math.Round(diameter, 3);
            Console.WriteLine($"The circumference of the circle is {circumference}");
            Console.WriteLine($"The diameter of the circle is {diameter}");


            //mpg
            Console.WriteLine("How many miles per gallon does your car get?");
            string mpgInput = Console.ReadLine();
            double mpg = Double.Parse(mpgInput);
            mpg = Math.Round(mpg, 3);

            double gallonsUsed = circumference / mpg;
            Console.WriteLine($"You need {gallonsUsed} gallons to travel around this circle");


        }
    }
}
