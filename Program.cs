using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903ML08a
{
    class Program
    {
        static void Main(string[] args)
        {
          var shapes = new List<Shape>();
            shapes.Add(new Square(4, 6));
            shapes.Add(new Circle(3));
            shapes.Add(new Square(6, 2));

           foreach(var shape in shapes)
            {
                Output(shape);
            }

        }
        public static void Output(Shape shape)
        {
            if(shape is Square)
            {
                //The outputs could be handled by a dedicated class
                //satisfying Single Responsibility Principle.
                Console.WriteLine($"{shape.Draw()}");
                Console.WriteLine($"Area = {shape.Area()}");
            }
            if (shape is Circle)
            {
                Console.WriteLine($"{shape.Draw()}");
                Console.WriteLine($"Area = {shape.Area()}");
            }
        }


    }
}
