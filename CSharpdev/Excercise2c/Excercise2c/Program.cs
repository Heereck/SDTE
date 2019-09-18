using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2c
{
    public class ClassRoom
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }

        public ClassRoom(string name, string lastname, string group, int age)///Initialize constructure
        {
            Name = name;
            LastName = lastname;
            Group = group;
            Age = age;
        }
        public ClassRoom()
        {
        }

    }
    public class ReturnValue
    {
        string returnthis;
        public string value
        {
            get
            {
                return returnthis;
            }
            set
            {
                returnthis = value;
            }
        }
    }

    public class IsPalindrome
    {
        public IsPalindrome()
        { }
        public bool IsPalindrome1(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }

        }


    }
    public class PrintDia
    {
       public void PrintDiagonal(int x)
        {
            // Declare a new StringBuilder.
            int j = 0;
            StringBuilder builder = new StringBuilder();
            builder.Append("Print Diagonal numbers: ").AppendLine();

            for (int i = 0; i < x; i++)
            {
               
                if (i == 0)

                {
                    builder.Append(i).AppendLine();
                }
                else if (i != 0)
                {
                    while (j != i)
                    {
                        builder.Append(" ");
                        j++;
                    }
                   builder.Append(i).AppendLine();
                   j = 0;
                }
                }
                      
            string innerString = builder.ToString();

            // Display with Debug.
            Console.WriteLine(innerString);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string a = "0";
            int b = 0;
            ClassRoom Terranova = new ClassRoom("Erick", "Gutierrez", "6B", 13);
            ClassRoom Begsu = new ClassRoom()
            {
                Name = "Pedrito",
                LastName = "Perez",
                Group = "5A",
                Age = 13
            };

            Console.WriteLine("Terranova has one student called {0} {1} he is studying in class {2} and he is {3} old",
                Terranova.Name, Terranova.LastName, Terranova.Group, Terranova.Age);

            Console.WriteLine("Begsu has one student called {0} {1} he is studying in class {2} and he is {3} old",
                Begsu.Name, Begsu.LastName, Begsu.Group, Begsu.Age);
            Console.WriteLine();

            ReturnValue return1 = new ReturnValue();
            return1.value = "Juan";
            Console.WriteLine("This is the returned Value: "+return1.value);
            Console.WriteLine();

            IsPalindrome palind = new IsPalindrome();
            var x = palind.IsPalindrome1("Civic");
            Console.WriteLine();
            Console.WriteLine("The word Civis is palindrome: "+x.ToString());
            Console.WriteLine();

            PrintDia PrintDia1 = new PrintDia();
            Console.WriteLine("Type the lenght of the diagonal: ");
            a = Console.ReadLine();
            try
            {
                b = Convert.ToInt16(a);
                PrintDia1.PrintDiagonal(b);

            }
            catch (Exception)
            {
                Console.WriteLine("Value was not a number");
            }
        }
    }
}
