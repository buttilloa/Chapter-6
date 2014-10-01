using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpongeBobSQUAREPants
{
    class Program
    {
       
        public static void PotatoSack(ref int TheBestInt)
        {
            TheBestInt *= TheBestInt;
            Console.WriteLine(TheBestInt);
        } 
        static void Main(string[] args)
        {
            int TheBestInt;
            Console.Write("Enter another value you loser: ");
            TheBestInt = Convert.ToInt32(Console.ReadLine());
            PotatoSack(ref TheBestInt);
            Console.WriteLine(TheBestInt);
        }
    }
}
