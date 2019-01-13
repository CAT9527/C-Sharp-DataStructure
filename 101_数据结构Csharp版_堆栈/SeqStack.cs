using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_数据结构Csharp版_堆栈
{
    /// <summary>
    /// 顺序栈实现栈的基本操作
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SeqStack<T> : IStack<T>
    {
        //初始化操作 容量maxsize，存储的数组data，栈顶元素top
        private int maxsize;
        private T[] data;
        private int top;

        public int Maxsize
        {
            get { return maxsize; }
            set { maxsize = value; }
        }
        public int Top { get { return top; } }
        
        public SeqStack(int size)
        {
            data = new T[size];
            maxsize = size;
            top = -1;
        }
        
        public void Clear()
        {
            top = -1;
        }

        public int GetLength()
        {
            return top + 1;
        }

        public T GetTop()
        {
            if (isEmpty())
            {
                Console.WriteLine("栈为空");
                return default(T);
            }
            return data[top];
        }

        public bool isEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 出栈操作
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T temp = default(T);
            if (isEmpty())
            {
                Console.WriteLine("栈已经空了");
                return temp;
            }
            temp = data[top];
            --top;
            return temp;
        }

        /// <summary>
        /// 入栈操作
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("栈已经满了");
                return;
            }
            data[++top] = item;
        }

        /// <summary>
        /// 判断栈是否为满
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            if (top == maxsize - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
