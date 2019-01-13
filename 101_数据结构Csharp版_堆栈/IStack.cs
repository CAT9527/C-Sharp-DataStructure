using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_数据结构Csharp版_堆栈
{
    interface IStack<T>
    {
        void Push(T item);    //入栈操作
        T Pop();                    //出栈操作
        T GetTop();               //取出栈顶元素
        int GetLength();        //求栈的长度
        bool isEmpty();         //判断栈是否为空
        void Clear();             //清空操作
    }
}
