using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHardWay
{
    public class Rectangle
    {
        public double Width;
        public double Depth;
        public double Area;
        public double Perimeter;

        public Rectangle(double width, double depth)            //defines how we create an instance of a Rectangle object, and what (if any) parameters are required.
        {
            Width = width;
            Depth = depth;
            calcArea();                                         //ok to use private method here since we're inside the class
            Area = returnArea();                                //another way we could set the "Area" property
            Area = returnArea(Width, Depth);                    //another way we could set the "Area" property
            calcPerimeter();
        }

        public Rectangle()
        {
            Width = 0;
            Depth = 0;
            calcArea();
            calcPerimeter();
        }


        private void calcArea()                                 //Set as private so can only be used inside the Rectangle class, and not outside
        {                                                       //Outside the class, Rectangle.Area has meaning, but Rectangle.calcArea() is invalid since it is private                        
            Area = Width * Depth;                               //Note that this method is "void" meaning it doesn't return any value, but rather performs an operation,
        }                                                       //which in this case is defining the value of "Area"            

        private double returnArea()                             //for illustrative purposes, we could accomplish the same thing with a method that returns the value of "Area"
        {
            return Width * Depth;
        }

        private double returnArea(double width, double depth)   //yet another way we could accomplish the same goal, note that "width" and "depth" are not the same as
        {                                                       //"Width" and "Depth".  Here they are variable local to the "returnArea()" method and cannot be accessed outside the method        
            return width * depth;                               //Also note that this method as the same name as the previous method,             
        }                                                       //this is called "overloading" and is allowed so long as parameters are different

        private void calcPerimeter()
        {
            Perimeter = 2 * (Width + Depth);
        }
    }
}
