using System;
using System.Collections.Generic;
using System.Threading;

namespace _102_数据结构Csharp版_队列
{
    class BankQueueApp
    {
        public static void Main()
        {
            IBankQueue bankQueue = null;
            Console.WriteLine("请选择存储结构的类型:1.顺序队列  2.链队列");

            char seleflag = Convert.ToChar(Console.ReadLine());
            switch (seleflag)
            {
                /*初始化顺序队列*/
                case '1':
                    int count;                  //接受循环顺序队列的容量
                    Console.Write("请输入队列可容纳的人数:");
                    count = Convert.ToInt32(Console.ReadLine());
                    bankQueue = new CSeqBankQueue(count);
                    break;
                /*初始化链队列*/
                case '2':
                    bankQueue = new LinkBankQueue();
                    break;
            }

            int windowCount = 2;        //设置银行柜台的服务窗口数。先设为1，然后依次增加看效果

            ServiceWindow[] sw = new ServiceWindow[windowCount];
            Thread[] swt = new Thread[windowCount];
            for (int i = 0; i < windowCount; i++)
            {
                sw[i] = new ServiceWindow();
                sw[i].BankQ = bankQueue;
                swt[i] = new Thread(new ThreadStart(sw[i].Service));
                swt[i].Name = "" + (i + 1);
                swt[i].Start();
            }
            while (true)
            {
                Console.Write("请点击触屏获取号码：");
                Console.ReadLine();
                int callnumber;
                if (!bankQueue.IsFull())
                {
                    callnumber = bankQueue.GetCallnumber();
                    Console.WriteLine("您的号码是{0}，你前面有{1}位，请等待！", callnumber, bankQueue.GetLength());
                    bankQueue.EnQueue(callnumber);
                }
                else
                    Console.WriteLine("现在业务繁忙，请稍后重试");
                Console.WriteLine();
            }
        }
    }
}
