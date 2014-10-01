using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area
{
    class Program
    {
       
        public static int Area51(int width,int length) 
        {
            return width * length;
        }
     public static double AreaDoubleDogDare(double width, double length)
        {
            return length * width;   
     }
     public static double HalfandHalfIceTea(int width, double length)
        {
            return length * width;   
     } 
        static void Main(string[] args)
        {
            int widthInput=11, lengthInput=7;
            Console.WriteLine("Int Area: " + Area51(widthInput,lengthInput));
            double widthInput2 = Convert.ToDouble(widthInput), lengthInput2 = Convert.ToDouble(lengthInput);
            Console.WriteLine("Double Area: " + AreaDoubleDogDare(widthInput2, lengthInput2));
            Console.WriteLine("Half and Half Area: " + HalfandHalfIceTea(widthInput, lengthInput2));


        }
    }
}
