using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces_IPolygon
{
    public class Triangle : IPolygon
    {
        void IPolygon.CalculateArea(int a, int b)
        {
            int area = 1 / 2 * (a * b);
            Console.WriteLine($"Area of Triangle is is {area}.");
        }
    }
}
