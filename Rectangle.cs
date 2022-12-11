using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces_IPolygon
{
    class Rectangle : IPolygon
    {
        public void calculateArea(int a, int b)
        {
            int area = a * b;
            Console.WriteLine($"Area of a rectangle is {area}.");
        }

        public void calculatePerimter(int c, int d)
        {
            int perimeter = 2*(c + d);
            Console.WriteLine($"Perimer of a rectangle is {perimeter}.");
        }
    }
}
