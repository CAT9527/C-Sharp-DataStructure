using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_数据结构Csharp版_队列
{
    class CSeqBankQueue : CSeqQueue<int>, IBankQueue
    {
        private int callNumber;          //记录系统自动产生的新来顾客的服务号
        //叫号属性
        public int CallNumber
        {
            get { return callNumber; }
            set { callNumber = value; }
        }
        public CSeqBankQueue() { }
        public CSeqBankQueue(int size) : base(size) { }

        public int GetCallnumber()
        {
            if ((IsEmpty()) && callNumber == 0)
                callNumber = 1;
            else
                callNumber++;

            return callNumber;
        }
    }
}
