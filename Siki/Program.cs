using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siki
{
    class Program
    {
        static void Main(string[] args)
        {

            //使用自己的顺序表
            LinkList<string> seqList = new LinkList<string>();

            seqList.Add("da");
            seqList.Add("dasdasda");
            seqList.Add("85465");
            
            Console.WriteLine(seqList.GetEle(2));
            Console.WriteLine(seqList.GetLength());
            seqList.Insert("sdasd", 5);
            for (int i = 0; i < seqList.GetLength(); i++)
            {
                Console.Write(seqList[i]+" ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
