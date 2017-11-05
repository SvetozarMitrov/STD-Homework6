using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option(triangle, square, radians)");
            string option = Console.ReadLine();
            switch (option)
            {
                case "triangle":
                    Console.WriteLine("Enter side:");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter heigh:");
                    int heigh = int.Parse(Console.ReadLine());
                    triangleMethod(side, heigh);
                    break;
                case "square":
                    Console.WriteLine("Enter side:");
                    int sideOfSquare = int.Parse(Console.ReadLine());
                    squareMethod(sideOfSquare);
                    break;
                case "radians":
                    Console.WriteLine("Enter the degrees you want to transform in radians:");
                    int radians = int.Parse(Console.ReadLine());
                    RadiansMethod(radians);
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;

            }


        }
        static void triangleMethod(int side, int heigh)
        {

            double triangleArea = (side * heigh) / 2.0;
            Console.WriteLine("The area of the triangle is = {0:F2}", triangleArea);
        }
        static void squareMethod(int sideOfSquare)
        {
            double squareArea = Math.Pow(sideOfSquare, 2);
            Console.WriteLine("The area of the square is = {0:F2}.", squareArea);
        }
        static void RadiansMethod(int radians)
        {
            double pi = Math.PI;
            double rad = (pi / 180) * radians;
            Console.WriteLine("Your degrees in radians is = {0}", rad);
        }
    }
}