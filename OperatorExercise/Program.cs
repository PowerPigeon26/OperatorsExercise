namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int subtract = a - b;
            int multiply = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"In this instance, a is {a} and b is {b}.");
            Console.WriteLine($"The sum of a and b is {sum}.");
            Console.WriteLine($"When a is subtracted by b, the result is {subtract}.");
            Console.WriteLine($"When a is multiplied by b, the result is {multiply}.");
            Console.WriteLine($"When a is divided by b, the result is {quotient}.");
            Console.WriteLine($"When a modulus b is done, the result is {remainder}.");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());  //possible null reference, yuck! Find different options to fix this, other than just loop check
            double circleArea1 = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {circleArea1}.");

        }

        public static double AreaOfCircle(double radius)
        {
            double areaOfCircle = Math.PI * radius * radius;
            return areaOfCircle;
        }
    }
}
