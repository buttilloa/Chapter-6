using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Bone_It
{
    class Program
    {

        public static int SpareChairSquareDareFairCareBearSnare(int numbre)
        {
            return numbre * numbre;
        }
        public static int jubes(int numbre2)
        {
            return numbre2 * numbre2 * numbre2;
        }
        static void Main(string[] args)
        {
            Console.Write("Put in (haha put in) a number: ");
            int MiccioIsSuchAWeenee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SpareChairSquareDareFairCareBearSnare(MiccioIsSuchAWeenee));
            Console.WriteLine(jubes(MiccioIsSuchAWeenee));
        }
    }
}
