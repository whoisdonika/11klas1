using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rectangles would you like to add? - ");
            int rectangleCount = int.Parse(Console.ReadLine());

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 1; i <= rectangleCount; i++)
            {
                Console.WriteLine($"Enter side A and B for rectangle number {i} : ");
                int sideA = int.Parse(Console.ReadLine());
                int sideB = int.Parse(Console.ReadLine());

                if (sideA < 1)
                {
                    Console.Write("Invalid value for side A. Try again : ");
                    sideA = int.Parse(Console.ReadLine());
                }

                if (sideB < 1)
                {
                    Console.Write("Invalid value for side B. Try again : ");
                    sideB = int.Parse(Console.ReadLine());
                }


                Rectangle rectangle = new Rectangle(sideA, sideB);

                rectangles.Add(rectangle);
            }

            foreach (Rectangle r in rectangles)
            {
                Console.WriteLine($"This rectangle's perimeter is {r.CalculatePerimeter()}cm and its area is {r.CalculateArea()}cm2.");
            }
        }
    }
}
