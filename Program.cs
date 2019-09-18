using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the food you want to search");
            string a = Console.ReadLine();
            Console.WriteLine();
            using (XmlReader reader = XmlReader.Create(@"c:\Exercise3-11.xml"))
            {
                while (reader.ReadToFollowing("name"))
                {
                    var el = reader.ReadString();
                    if (el == a)
                    {
                        reader.ReadToNextSibling("price");
                        Console.WriteLine("The price of the food is: "+reader.ReadString());
                        reader.ReadToNextSibling("description");
                        Console.WriteLine("Description: "+reader.ReadString());
                        reader.ReadToNextSibling("calories");
                        Console.WriteLine("Calories per portion: " + reader.ReadString());
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
