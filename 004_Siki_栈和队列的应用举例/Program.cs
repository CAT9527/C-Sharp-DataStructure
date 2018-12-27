using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Siki_栈和队列的应用举例
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            for(int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);                    //入栈
                queue.Enqueue(str[i]);            //入队
            }

            bool isHui = true;
            while (stack.Count>0)
            {
                //栈的Pop是从栈顶读取数据，队列的Dequeue是从队首开始读取数据
                if (stack.Pop() != queue.Dequeue())
                {
                    isHui = false;
                    break;
                }
            }
            Console.WriteLine("是否为回文字符串："+isHui);
            Console.ReadKey();
        }
    }
}
