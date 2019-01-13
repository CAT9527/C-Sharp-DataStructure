using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_数据结构Csharp版_堆栈
{
    /// <summary>
    /// 用顺序栈解决火车车厢重排问题
    /// </summary>
    class TrainArrangeBySeqStack
    {
        //车厢重排算法。K个缓冲铁轨，车厢初始排序存放在p中
        private bool Railroad(int [] p,int n ,int k)
        {
            //如果重排成功,返回true，否则返回false
            //创建与缓冲铁轨对应的堆栈
            SeqStack<int>[] H;
            H = new SeqStack<int>[k + 1];
            
        }
    }
}
