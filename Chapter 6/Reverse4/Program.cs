﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4
{
    class Program
    {
        public static void SwitchUP(ref int first, ref int middle,ref int middle2,ref int last)
        {
            Console.WriteLine("");
            int temp = first;
            int temp2 = middle;
            middle = middle2;
            middle2 = temp2;
            first = last;
            last = temp;
            Console.WriteLine("Switched");
        }
        static void Main(string[] args)
        {
            int Firstint = 11, middleInt = 7,middleInt2 = 100, LastInt = 13;
            Console.Write("First: " + Firstint);
            Console.Write(" Middle: " + middleInt);
            Console.Write(" Middle2: " + middleInt2);
            Console.Write(" Last: " + LastInt);
            SwitchUP(ref Firstint, ref middleInt,ref middleInt2, ref LastInt);
            Console.Write("First: " + Firstint);
            Console.Write(" Middle: " + middleInt);
            Console.Write(" Middle2: " + middleInt2);
            Console.Write(" Last: " + LastInt);


        }
    }

}
