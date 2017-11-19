using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHardWay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate the area and perimeter of three different rectangles... the hard way
            double width1, depth1, area1, perimeter1, width2, depth2, area2, perimeter2, width3, depth3, area3, perimeter3;

            width1 = 1;
            depth1 = 2;
            area1 = width1 * depth1;                                //bad way to do repetitive operation
            perimeter1 = 2 * (width1 + depth1);                     //bad way to do repetitive operation
            area1 = calcArea(width1, depth1);                       //slightly better way to do repetitive operation, but we still end up repeating ourselves when we set properties manually
                                                                    //should create "Rectangle" class and write code only once for how to calculate properties 
            perimeter1 = calcPerimeter(width1, depth1);
            
            width2 = 3;
            depth2 = 4;
            area2 = width2 * depth2;                                //bad way to do repetitive operation
            perimeter2 = 2 * (width2 + depth2);                     //bad way to do repetitive operation
            area2 = calcArea(width2, depth2);                       //slightly better way to do repetitive operation, but we still end up repeating ourselves when we set properties manually
                                                                    //should create "Rectangle" class and write code only once for how to calculate properties               
            perimeter2 = calcPerimeter(width2, depth2);

            width3 = 5;
            depth3 = 6;
            area3 = width3 * depth3;                                //bad way to do repetitive operation
            perimeter3 = 2 * (width3 + depth3);                     //bad way to do repetitive operation
            area3 = calcArea(width3, depth3);                       //slightly better way to do repetitive operation, but we still end up repeating ourselves when we set properties manually
                                                                    //should create "Rectangle" class and write code only once for how to calculate properties
            perimeter3 = calcPerimeter(width3, depth3);

            Rectangle rectangle1 = new Rectangle(1, 2);             //much better way to define a rectangle, now if we need to access the different properties of rectangle1,  
            Rectangle rectangle2 = new Rectangle(3, 4);             //we would simply use rectangle1.Width or rectangle1.Depth or rectangle1.Area or rectangle1.Perimeter
            Rectangle rectangle3 = new Rectangle(5, 6);



        }

        static double calcArea(double width, double depth)
        {
            return width * depth;
        }

        static double calcPerimeter(double width, double depth)
        {
            return 2 * (width + depth);
        }
    }
}
