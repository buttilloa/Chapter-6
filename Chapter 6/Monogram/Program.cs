using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram
{
    class Program
    {
        public static void PatricksLoveRock(char One, char PatrickStar, char SquidwardsBigOlNose)
        {
            Console.WriteLine(" ** " + One + ". " + PatrickStar + ". " + SquidwardsBigOlNose + ". ** ");
        }
        static void Main(string[] args)
        {
            char CaptRayRayRedBeard = 'A', TheKracken = 'H', TheKrackensMom = 'B', JudgeJudy = 'D', CliffordTheBigRedDog = 'W', BigOlEarLobe = 'H';

            PatricksLoveRock(CaptRayRayRedBeard, TheKracken, TheKrackensMom);
            PatricksLoveRock(JudgeJudy, CliffordTheBigRedDog, BigOlEarLobe);
        }
        
    }
    }

