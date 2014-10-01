using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse3
{
    class Program
    {
        public static void SwitchUP(ref int first, ref int middle, ref int last)
        {
            Console.WriteLine("");
            int temp = first;
            first = last;
            last = temp;
            Console.WriteLine("Switched");
        }
        static void Main(string[] args)
        {
            int Firstint = 11, middleInt =7, LastInt=13;
            Console.Write("First: " + Firstint );
            Console.Write(" Middle: " + middleInt);
            Console.Write(" Last: " + LastInt);
            SwitchUP(ref Firstint,ref middleInt,ref LastInt);
            Console.Write("First: " + Firstint);
            Console.Write(" Middle: " + middleInt);
            Console.Write(" Last: " + LastInt);


        }
    }
}
