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
       public void PrintDiagonal()
        {
            // Declare a new StringBuilder.
            StringBuilder builder = new StringBuilder();
            builder.Append("Print Diagonal numbers: ");
            builder.AppendLine();
            builder.Append("1    ").AppendLine();
            builder.Append(" 2   ").AppendLine();
            builder.Append("  3 ").AppendLine();
            builder.Append("   4").AppendLine();
            builder.AppendLine();

            // Get a reference to the StringBuilder's buffer content.
            string innerString = builder.ToString();

            // Display with Debug.
            Console.WriteLine(innerString);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
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

            ReturnValue return1 = new ReturnValue();
            return1.value = "Returned Value";
            Console.WriteLine(return1.value);

            IsPalindrome palind = new IsPalindrome();
            var x = palind.IsPalindrome1("Civic");
            Console.WriteLine(x.ToString());

            PrintDia PrintDia1 = new PrintDia();
            PrintDia1.PrintDiagonal();
            
            

        }
    }
}
