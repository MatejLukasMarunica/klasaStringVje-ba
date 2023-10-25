using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVježba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;

            Console.WriteLine("  Unesi neke rečenice  ");
            s1 = Console.ReadLine();

            string prvarec = s1.Substring(0, s1.IndexOf(" "));
            string zadnjirec = s1.Substring(s1.LastIndexOf(" ", s1.Length - 1));

            Console.WriteLine(prvarec + zadnjirec);

            Console.ReadKey();
        }
    }
}
