using System;
using System.IO;

namespace TESTAPPLICATION
{
    public class Program
    {


        public static void Main(string[] args)
        {
            for (count = 0; count < 25; count++)
            {
                Console.Write(count);
                if (_evenIfTake3())
                    Console.Write(" is even");
                else
                    Console.Write(" isn't even");
                Console.Write(Environment.NewLine);
            }
            Console.ReadKey();


        }

        public static int count;

        public static bool _evenIfTake3()
        {
            var iseven = ((count - 3) % 2) == 0 ? true : false;
            return iseven;
        }



    }
}
