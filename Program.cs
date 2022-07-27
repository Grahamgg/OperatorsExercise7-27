using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExercise7_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"17/4 is {quotient} remainder {remainder}");
            Console.WriteLine("Input the radius and receive the area of a circle.");
            int r = int.Parse(Console.ReadLine());
            var areaOfCircle = AreaOfCircle(r);
            Console.WriteLine($"The area of a circle with a radius of {r} is {AreaOfCircle(r)}");

        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
    }

