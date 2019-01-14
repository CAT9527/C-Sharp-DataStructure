using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_数据结构Csharp版_队列
{
    /// <summary>
    /// 使用顺序结构实现队列接口类(循环顺序队列)  Circular sequence Queue
    /// </summary>
    class CSeqQueue<T> : IQueue<T>
    {
        private int maxsize;                      //循环顺序队列的容量
        private T[] data;                         //数组，用于存储循环队列中的数据元素
        private int front;                        //指示最近一个已经离开队列的元素所占的位置
        private int rear;                         //指示最近一个进行入队列的元素的位置

        public T this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public int Maxsize
        {
            get { return maxsize; }
            set { maxsize = value; }
        }
        public int Front
        {
            get { return front; }
            set { front = value; }
        }
        public int Rear
        {
            get { return rear; }
            set { rear = value; }
        }
        
        //初始化队列
        public CSeqQueue() { }
        public CSeqQueue(int size)
        {
            data = new T[size];
            maxsize = size;
            front = rear = -1;          //队列为空
        }

        public void Clear()
        {
            front = rear = -1;
        }

        /// <summary>
        /// 出队操作
        /// </summary>
        /// <returns></returns>
        public T DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!!!");
                return default(T);
            }
            front = (front + 1) % maxsize;
            return data[front];
        }

        /// <summary>
        /// 入队操作
        /// </summary>
        /// <param name="elem"></param>
        public void EnQueue(T elem)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full!!!");
                return;
            }
            rear = (rear + 1) % maxsize;
            data[rear] = elem;
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            return data[(front + 1) % maxsize];
        }

        public int GetLength()
        {
            return (rear - front + maxsize) % maxsize;
        }

        public bool IsEmpty()
        {
            if (front == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if ((front == -1 && rear == maxsize - 1) || (rear + 1) % maxsize == front)
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
