using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    /// <summary>
    /// 双向链表的基本操作实现类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class DbLinkList<T> : IlinarList<T>
    {
        private DbNode<T> start;   //双向链表的头引用
        private int length;                 //双向链表的长度
        public DbLinkList()
        {
            start = null;
        }

        public void Clear()
        {
            start = null;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="i"></param>
        public void DeleteNode(int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("表为空or索引错误");
            }
            DbNode<T> current = start;
            if (i == 1)
            {
                start = current.Next;
                length--;
                return;
            }
            DbNode<T> previous = null;
            int j = 1;
            while (current.Next != null && j < i)
            {
                previous = current;
                current = current.Next;
                j++;
            }
            if (i == j)
            {
                previous.Next = current.Next;
                if (current.Next != null)
                    current.Next.Prev = previous;
                previous = null;
                current = null;
                length--;
            }
            else
            {
                Console.WriteLine("索引不存在");
            }
        }

        public int GetLength()
        {
            return length;
        }
        
        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>        
        //在双向链表的末尾追加数据元素
        public void InsertNode(T a)
        {
            DbNode<T> newNode = new DbNode<T>(a);
            if (IsEmpty())
            {
                newNode = start;
                length++;
                return;
            }

            DbNode<T> current = start;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Prev = current;
            newNode.Next = null;
            length++;
        }
        //在双向链表中的第i个数据元素的位置插入一个数据元素
        public void InsertNode(T a, int i)
        {
            DbNode<T> current;
            DbNode<T> previous;
            if (i < 1)
            {
                Console.WriteLine("索引出现错误");
                return;
            }
            DbNode<T> newNode = new DbNode<T>(a);
            //第一个元素
            if (i == 1)
            {
                newNode.Next = start;
                start = newNode;
                length++;
                return;
            }

            //第i个元素
            current = start;
            previous = null;
            int j = 1;
            while (current != null && j < i)
            {
                previous = current;
                current = current.Next;
                j++;
            }
            if (i == j)
            {
                newNode.Next = current;
                newNode.Prev = previous;
                if (current != null)
                    current.Prev = newNode;
                previous.Next = newNode;                
                length++;
            }
           
        }

        public bool IsEmpty()
        {
            if (start == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得双向链表的第i个数据元素
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T SearchNode(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("表为空");
                return default(T);
            }
            DbNode<T> current = start;
            int j = 1;
            while (current.Next != null && j < i)
            {
                current = current.Next;
                j++;
            }
            if (j == i)
            {
                return current.Data;
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }

        /// <summary>
        /// 查找值为value的索引
        /// </summary>
        /// <param name="value">需要查找的值</param>
        /// <returns>返回值所在的索引</returns>
        public T SearchNode(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("表为空");
                return default(T);
            }
            DbNode<T> current = start;
            int i = 0;
            while (current.Next != null && !current.Data.ToString().Contains(value.ToString()))
            {
                current = current.Next;
                i++;
            }
            if (current != null)
                return current.Data;
            else
                return default(T);

        }
    }
}
