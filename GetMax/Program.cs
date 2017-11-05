using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number:");
            int num3 = int.Parse(Console.ReadLine());
            int max = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine("Your biggest number is {0}", max);
        }
    }
}
