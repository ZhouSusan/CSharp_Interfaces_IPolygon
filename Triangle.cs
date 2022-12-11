using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces_IPolygon
{
    public class Triangle : IPolygon , IColor 
    {
        public void CalculateArea(int a, int b)
        {
            double area = 0.5 * (a * b);
            Console.WriteLine($"Area of Triangle is {area}.");
        }

        public void GetColor()
        {
            Console.WriteLine("Blue Triangle");
        }
    }
}
