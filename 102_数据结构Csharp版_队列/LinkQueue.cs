using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_数据结构Csharp版_队列
{
    class LinkQueue<T> : IQueue<T>
    {
        private QueueNode<T> front;              //队列头指示器
        private QueueNode<T> rear;               //队列尾指示器
        private int size;                                     //队列节点个数
        public QueueNode<T> Front
        {
            get { return front; }
            set { front = value; }
        }
        public QueueNode<T> Rear
        {
            get { return rear; }
            set { rear = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        //初始化链队列
        public LinkQueue()
        {
            front = rear = null;
            size = 0;
        }
        public void Clear()
        {
            front = rear = null;
            size = 0;
        }
        /// <summary>
        /// 出队操作
        /// </summary>
        /// <returns></returns>
        public T DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            QueueNode<T> p = front;
            front = front.Next;
            if(front == null)
            {
                rear = null;
            }
            --size;
            return p.Data;
        }
        /// <summary>
        /// 入队操作
        /// </summary>
        /// <param name="elem"></param>
        public void EnQueue(T elem)
        {
            QueueNode<T> q = new QueueNode<T>(elem);
            if (IsEmpty())
            {
                front = q;
                rear = q;
            }
            else
            {
                rear.Next = q;
                rear = q;
            }
            ++size;
        }
        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            return front.Data;
        }
        public int GetLength()
        {
            return size;
        }

        public bool IsEmpty()
        {
            if ((front == rear) && (size == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //链队列没有满的情况
        public bool IsFull()
        {
            return false;
        }
    }
}
