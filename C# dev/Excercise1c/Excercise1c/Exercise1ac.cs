using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Excercise1c
{
    public class Exercise1ac
    {
        public void comparation(string str1, string str2) //compare 2 words 1.1
        {

            int result = 0;

            try
            { 
            result = string.Compare(str1, str2);

            if (result == 0)
            {
                Console.WriteLine("String 1:" + str1 + " is equal to string 2:" + str2);
            }
            else if (result == 1)
            {
                Console.WriteLine("String 1:" + str1 + " is larger than string 2:" + str2);
            }
            else if (result == -1)
            {
                Console.WriteLine("String 1:" + str1 + " is shorter than string 2:" + str2);
            }
            }

            catch (Exception e)
            {
                Console.WriteLine("Caught exception: ", e.Message);
            }

        }
        public void getNumber()
        {
            int[] numbers = new int[] { 1, 25, 3, 4, 5, 6, 71, 0 };
            int x = 0;
            int y = 0;

            Array.Sort(numbers);

            for (int j = 1; j < numbers.Length; j++)
            {
                y = numbers[j];

                if (y >= x)
                {
                    x = y;
                }
            }
            Console.WriteLine("1.2 - Print the biggest number  ");
            Console.WriteLine("The biggest value in the array is: " + x);
        }

        public void OrderBy()
        {
            string a;
            string b;
            string c;

            Console.WriteLine("1.3 - order by asc & desc");
            List<string> listOrd = new List<string>();
            Console.WriteLine("Type the first string: ");
            a = Console.ReadLine();
            listOrd.Add(a);
            Console.WriteLine("Type the second string: ");
            b = Console.ReadLine();
            listOrd.Add(b);
            Console.WriteLine("Type the third string: ");
            c = Console.ReadLine();
            listOrd.Add(c);

            //////////////////Order list Asc and Desc
            var desc = listOrd.OrderByDescending(i => i);
            var asc = listOrd.OrderBy(i => i);

            Console.WriteLine("Descending Order:");
            foreach (var r in desc)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("Ascending Order:");
            foreach (var r in asc)
            {
                Console.WriteLine(r);
            } 





        }
        public void StringLeng()
        {
            Console.WriteLine("1.4 - Count the length of a string");
            Console.WriteLine("Type the string you want to count");

            string StrValue = Console.ReadLine();
            char[] array = StrValue.ToCharArray();
            int countArr = array.Count();
            Console.WriteLine("The String " + StrValue + " contains " + countArr + "letters.");
        }
    }
}
