using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_数据结构Csharp版_堆栈
{
    class Program
    {
        static void Main1(string[] args)
        {
            SeqStack<int> seqStack = new SeqStack<int>(5);
            seqStack.Push(2331);
            seqStack.Push(5555);
            seqStack.Push(7777);
            seqStack.Push(1234);
            seqStack.Push(8888);

            seqStack.Pop();
            Console.WriteLine(seqStack.Top+"------"+seqStack.GetTop());
            Console.ReadKey();
        }
    }
}
