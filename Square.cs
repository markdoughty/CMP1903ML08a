using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903ML08a
{
    class Square : Shape
    {
        public int Length{get; set;}
        public int Width { get; set; }

        //Overriding method in the base class
        public override string Draw()
        {
            return "Drawing a Square";
        }

    }
}
