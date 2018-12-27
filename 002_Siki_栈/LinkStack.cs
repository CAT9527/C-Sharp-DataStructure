using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Siki_栈
{
    /// <summary>
    /// 链栈
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top;   //栈顶元素节点
        private int count = 0;    //栈中元素的个数

        /// <summary>
        /// 取得栈中元素的个数
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }
            
        }

        /// <summary>
        /// 清空栈中数据
        /// </summary>
        public void Clear()
        {
            count = 0;
            top = null;
        }

        /// <summary>
        /// 取得栈中元素的个数
        /// </summary>
        /// <returns>count</returns>
        public int GetLength()
        {
            return count;
        }

        /// <summary>
        /// 判断栈中是否有数据
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return count == 0;
        }

        /// <summary>
        /// 取得栈顶中的数据，不删除栈顶
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
             return top.Data;
        }

        /// <summary>
        /// 删除栈顶数据
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="item">需要入栈的元素</param>
        public void Push(T item)
        {
            //把新添加的元素作为头节点
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }
    }
}
