using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVježba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;

            Console.WriteLine(" Unesi 1 cijeli i 1 decimalni, odvoji ih razmakom");
            s = Console.ReadLine();

            string x1 = s.Substring(0, s.IndexOf(" "));
            string y1 = s.Substring(s.LastIndexOf(" ", s.Length - 1));

            int x = Convert.ToInt32(x1);
            float y = Convert.ToSingle(y1);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();

            Console.WriteLine(x * 2);
            Console.WriteLine(y * 2);

            Console.ReadKey();
        }
    }
}
