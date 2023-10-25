using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVježba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
             s = Console.ReadLine();

            string sVelika = s.ToUpper();
            string sMala = s.ToLower();
            string sPrvaTri = s.Substring(0, 3);
            string sZadnjihPet = s.Substring(s.Length - 5, 5);
            string s8_11 = s;

           
                Console.WriteLine(sVelika);


                Console.WriteLine(sMala);


                Console.WriteLine(sPrvaTri);


                Console.WriteLine(sZadnjihPet);

            if(s.Length > 11)
            {
                s8_11 = s.Substring(8, 3);
                Console.WriteLine(s8_11);
            }
            else
            {
                Console.WriteLine(" Tekst je prekratak");
            }
                Console.ReadKey();
            
               
            }

            
        }
    }

