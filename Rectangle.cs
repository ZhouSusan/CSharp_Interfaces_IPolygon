using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces_IPolygon
{
    public class Rectangle : IPolygon , IColor
    {
        public void CalculateArea(int a, int b)
        {
            int area = a * b;
            Console.WriteLine($"Area of a rectangle is {area}.");
        }

        void IColor.getColor()
        {
            Console.WriteLine("Yellow Rectangle");
        }
    }
}
