using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903ML08a
{
    public static class Utility
    {
        //Static compile time polymorphism
        //using method overloading
        public static int addInts(int a, int b)
        {
            return a + b;
        }

        public static int addInts(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
