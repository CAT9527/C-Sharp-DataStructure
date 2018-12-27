using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Siki_队列
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL中的队列
            //Queue<int> queue = new Queue<int>();
            //2.使用顺序队列
            //IQueue<int> queue = new SeqQueue<int>(4);
            //3.使用链队列
            IQueue<int> queue = new LinkQueue<int>();
            //入队（添加数据）
            queue.Enqueue(213);
            queue.Enqueue(121);
            queue.Enqueue(777);
            queue.Enqueue(666);

            Console.WriteLine("添加了四个数据之后的队列的大小为："+queue.Count);

            //出队（取得队首的数据，并删除，返回新队首的数据）
            int i = queue.Dequeue();
            Console.WriteLine("出队之后的队首为：" + i);
            Console.WriteLine("出队之后，队列的大小为："+queue.Count);

            //返回队首的数据，但不删除
            int j = queue.Peek();
            Console.WriteLine("Peek之后的队首为：" + j);
            Console.WriteLine("Peek之后，队列的大小为：" + queue.Count);

            //清空
            queue.Clear();
            Console.WriteLine("Clear之后，队列的大小为：" + queue.Count);
            Console.ReadKey();
        }
    }
}
