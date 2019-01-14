using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _102_数据结构Csharp版_队列
{
    class ServiceWindow
    {
        IBankQueue bankQ;

        //服务队列属性
        public IBankQueue BankQ
        {
            get { return bankQ; }
            set { bankQ = value; }
        }

        //作为线程的方法
        public void Service()
        {
            while (true)
            {
                Thread.Sleep(10000);
                if (!bankQ.IsEmpty())
                {
                    Console.WriteLine();
                    lock (bankQ)
                    {
                        Console.WriteLine("请{0}号到{1}号窗口！", bankQ.DeQueue(), Thread.CurrentThread.Name);
                    }
                }
            }
        }
    }
}
