using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_数据结构CSharp版_二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
            HuffmanTree ht;

            Console.WriteLine("请输入叶节点数：");
            int leafNum = Convert.ToInt32(Console.ReadLine());
            ht = new HuffmanTree(leafNum);
            ht.Create();
            Console.WriteLine("位置\t权值\t父结点\t左孩子结点\t右孩子结点");
            for(int i = 0; i < 2 * leafNum - 1; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", i, ht[i].Weight, ht[i].Parent, ht[i].LChild, ht[i].RChild);
                
            }
            Console.ReadLine();
        }
    }
}
