using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用自己的顺序表
            SeqList<string> seqList = new SeqList<string>(10);
            seqList.InsertNode("da",1);
            seqList.InsertNode("dasdasda",2);
            seqList.InsertNode("85465",3);

            Console.WriteLine(seqList.SearchNode(5));
            Console.WriteLine(seqList.GetLength());
            seqList.InsertNode("sdasd", 5);
            for (int i = 0; i < seqList.GetLength(); i++)
            {
                Console.Write(seqList.SearchNode(i)+"   ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
