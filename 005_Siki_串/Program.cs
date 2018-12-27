using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Siki_串
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDS s = new StringDS("I am a teacher");
            StringDS i = new StringDS("excellent");
            StringDS r = new StringDS("student");
            Console.WriteLine(s.GetLength());
            Console.WriteLine(i.GetLength());
            Console.WriteLine(r.GetLength());

            StringDS s2 = s.SubString(8, 6);            
            Console.WriteLine(s2.ToString());
            StringDS i2 = i.SubString(2, 1);
            Console.WriteLine(i2.ToString());

            

            Console.ReadKey();
        }
        
    }
}
