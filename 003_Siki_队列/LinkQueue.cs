using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Siki_队列
{
    /// <summary>
    /// 链队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkQueue<T> : IQueue<T>
    {
        private Node<T> front;  //头节点
        private Node<T> rear;   //尾节点
        private int count;   //表示元素的个数

        public LinkQueue()
        {
            front = null;
            rear = null;
            count = 0;
        }
        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            count = 0;
        }

        /// <summary>
        /// 出队，处理队头
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("队列为空，无法出队");
                return default(T);
            }else if (count == 1)
            {
                T temp = front.Data;
                front = rear = null;
                count = 0;
                return temp;
            }
            else           //count>1
            {
                T temp = front.Data;
                front = front.Next;
                count--;
                return temp;
            }
        }

        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="item">需要入队的元素</param>
        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (count == 0)
            {
                front = newNode;
                rear = newNode;
                count = 1;
            }
            else
            {
                rear.Next = newNode;  //这里rear是原尾节点
                rear = newNode;           //这里rear是新尾节点
                count++;
            }
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            if (front!=null)
            {
                return front.Data;
            }
            else
            {
                return default(T);
            }
        }
    }
}
