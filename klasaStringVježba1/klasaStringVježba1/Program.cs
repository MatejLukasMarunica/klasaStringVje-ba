using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVježba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;

            Console.WriteLine("  Unesi neki string bilo koje dužine ");
            s1 = Console.ReadLine();

            Console.WriteLine(s1.Replace(" ", "_"));
            

            Console.ReadKey();
        }
    }
}
