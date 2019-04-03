using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text;
namespace Excercise1c
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 0 };
            int[] numbers2 = new int[8];
            int x = 0;
            int y = 0;
            string a;
            string b;
            var listtest = new Dictionary<string, int>()
             {
                {"Uno", 1},
                {"Dos", 2},
                {"Tres", 3},
                {"Cuatro",4 }
             };
            var list = new List<string>(listtest.Keys);

            /////
            /////Print the first 5 numbers of the list 2.1
            /////

            Console.WriteLine("2.1 - Print the first 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Print the second list ");
            for (int i = 0; i < 2; i++)
            {
                numbers2[i] = numbers[i + 6];
                Console.WriteLine(numbers2[i]);
            }
            /////
            /////Print the smallest number 2.2
            /////
            x = numbers[0];//first Value


            for (int j = 1; j < numbers.Length; j++)
            {
                y = numbers[j];

                if (y <= x)
                {
                    x = y;

                }
            }

            Console.WriteLine("2.2 - Print the Smallest number  ");
            Console.WriteLine("Value of x: " + x);

            Console.WriteLine("2.3 - Print the list based on the key ");

            foreach (string key in list)
            {
                Console.WriteLine(" List " + key);
            }

            Exercise1ac test1 = new Exercise1ac();
            Console.WriteLine("1.1 - Comparison between 2 words");
            Console.WriteLine("Type the first string: ");
            a = Console.ReadLine();
            Console.WriteLine("Type the second string: ");
            b = Console.ReadLine();
            test1.comparation(a, b);
            Console.ReadLine();

            Exercise1ac BigNum = new Exercise1ac();////Print the biggest number
            BigNum.getNumber();
            Console.ReadLine();

            Exercise1ac order = new Exercise1ac();////order a list by asc or desc
            order.OrderBy();
            Console.ReadLine();

            Exercise1ac strLen = new Exercise1ac();////Count the length of a string
            strLen.StringLeng();
            Console.ReadLine();


        }
    }
}

