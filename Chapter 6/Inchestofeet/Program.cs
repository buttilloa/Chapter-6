using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inchestofeet
{
    class Program
    {
        static void Main(string[] args)
        {
            int inches;
            Console.Write("Enter Inches: ");
            inches = Convert.ToInt32(Console.ReadLine());
            inchesToFeet(inches);
            inchesToYards(inches);

        }
        public static void inchesToFeet(int inches)
        {
         Console.WriteLine(inches/12+" feet " +inches%12 +" inches");
        }
        public static void inchesToYards(int inches)
        {
            Console.WriteLine(inches / 36 + " Yard(s) " + (inches % 36)/12 + " Feet and " + inches % 12 + " Inches");

        }
    }
}
