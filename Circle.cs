using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903ML08a
{
    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int r)
        {
            Radius = r;
        }
        //Single Responsibility Principle:
        //eg: making sure class methods only return data, and do
        //not handle the output method
        public override string Draw()
        {
            return "Drawing a circle";
        }
        //Open/Closed Principle
        //Make sure that we can add functionality to the class (Area() method)
        //but without changing existing code
        //Calculating Area in other part of the code means we have to change the code
        //if another Area calculation is brought in.
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
