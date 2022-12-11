using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Interfaces_IPolygon
{
    public class Circle : IPolygon, IColor
    {
        public void CalculateArea(int a, int b) 
        {
            // Expect a == b == radius
            Console.WriteLine(3.14 * a * b);
        }
        public void GetColor() 
        {
            Console.WriteLine("Green Circle. You know that means go right?");
        }
    }
}
