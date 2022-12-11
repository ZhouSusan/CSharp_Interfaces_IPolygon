using CSharp_Interfaces_IPolygon;

namespace CSharp_Interface_IPolygon
{
    public class Program
    {
        public static void Main()
        {
            IPolygon rect1 = new Rectangle();
            rect1.CalculateArea(100, 200);
            

            Triangle triTrangle = new Triangle();
            triTrangle.CalculateArea(13, 28);
            triTrangle.GetColor();

            Rectangle rect2 = new Rectangle();
            rect2.CalculateArea(30, 30);
            rect2.GetColor();

            Circle circle = new Circle();
            circle.CalculateArea(2, 2);
            circle.GetColor();
        }
    }
}

