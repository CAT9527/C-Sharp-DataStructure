﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Siki_队列
{
    /// <summary>
    /// 顺序队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SeqQueue<T> : IQueue<T>
    {
        private T[] data;
        private int count;       //表示当前有多少个元素

        private int front;   //队首（队首元素索引-1）
        private int rear;    //队尾（队尾元素索引）

        public SeqQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }
        public SeqQueue() : this(10) { }

        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            count = 0;
            front = rear = -1;
        }

        /// <summary>
        /// 出队 ，删除元素
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (count > 0)
            {
                T temp = data[front + 1];   //取得队首元素
                front++;                              //因为front-1是原队首的索引，那么新队首就是front自增1
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空，无法取得队首的值");
                return default(T);
            }
        }

        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="item">入队元素</param>
        public void Enqueue(T item)
        {
            if (count==data.Length)
            {
                Console.WriteLine("队列已满，不能再加了");
            }
            else
            {
                if (rear == data.Length - 1)
                {
                    data[0] = item;
                }
                else
                {
                    data[rear + 1] = item;
                    rear++;
                }
            }
            count++;
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
            T temp = data[front + 1];   //取得队首元素
            return temp;
        }
    }
}
