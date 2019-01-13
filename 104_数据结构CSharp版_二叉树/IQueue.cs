using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_数据结构Csharp版_队列
{
    /// <summary>
    /// 队列的操作接口类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IQueue<T>
    {
        void EnQueue(T elem);                //入队操作
        T DeQueue();                               //出对操作
        T GetFront();                                //取队头元素
        int GetLength();                            //求队列长度
        bool IsEmpty();                             //判断队列是否为空
        void Clear();                                 //清空队列
        bool IsFull();                                 //判断队列是否为满
    }
}
