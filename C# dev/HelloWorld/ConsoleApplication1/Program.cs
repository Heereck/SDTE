using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            int z = 0;
            int l = 0;


            z = ++x;

            Console.WriteLine("HEllo World ++x: " + z + " Jola");

            z = x++;
            Console.WriteLine("HEllo World x++: " + z + " Jola");
            l = 5;
        }
    }
}
