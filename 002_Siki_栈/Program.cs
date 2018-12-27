using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Siki_栈
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL中的stack<T>
            //Stack<char> stack = new Stack<char>();
            //2.使用自己定义的顺序栈
            //IStackDS<char> stack = new SeqStack<char>(30);
            //3.使用自己定义的链栈
            IStackDS<char> stack = new LinkStack<char>();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');

            Console.WriteLine("Push a b c之后的数据个数：{0}",stack.Count);
            char temp = stack.Pop();
            Console.WriteLine("Pop之后的数据：" + temp);
            Console.WriteLine("Pop之后的数据个数：" + stack.Count);
            char temp2 = stack.Peek();
            Console.WriteLine("Peek之后的数据：" + temp2);
            Console.WriteLine("Peek之后的数据个数：" + stack.Count);

            stack.Clear();
            Console.WriteLine("clear之后的数据个数：" + stack.Count);

            //Console.WriteLine("空栈取得栈顶的值"+stack.Peek());  //出现异常
            //当空栈的时候，不要进行peek或者pop的操作，否则会出现异常
            Console.ReadKey();
        }
    }
}
