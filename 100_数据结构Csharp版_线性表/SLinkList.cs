using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    /// <summary>
    /// 单链表的实现类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SLinkList<T> : IlinarList<T>
    {
        private SNode<T> start;                  //单链表的头引用
        int length;                                         //单链表的长度

        //初始化单链表 构造函数
        public SLinkList()
        {
            start = null;
        }

        /// <summary>
        /// 清空操作
        /// </summary>
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
                Console.WriteLine("Link is empty or Position is error");
            }
            SNode<T> current = start;
            //如果删除位置是1，直接把start指向它的Next
            if (i == 1)
            {
                start = current.Next;
                length--;
                return;
            }
            SNode<T> previous = null;
            int j = 1;
            while (current != null && j < i)
            {
                previous = current;
                current = current.Next;
                j++;
            }
            if (j == i)
            {
                previous.Next = current.Next;
                current = null;
                length--;
            }
            else
            {
                Console.WriteLine("The ith node is not exist");
            }

        }

        /// <summary>
        /// 求单链表长度
        /// </summary>
        /// <returns>length</returns>
        public int GetLength()
        {
            return length;
        }

        /// <summary>
        /// 插入操作  分为末尾追加和中间插入
        /// </summary>
        public void InsertNode(T a)
        {
            if (start == null)
            {
                start = new SNode<T>(a);
                length++;
                return;
            }
            SNode<T> current = start;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new SNode<T>(a);
            length++;
        }
        public void InsertNode(T a, int i)
        {
            SNode<T> current;
            SNode<T> previous;
            if (i < 1 || i > length + 1)
            {
                Console.WriteLine("Position is error ");
                return;
            }

            //新元素a
            SNode<T> newNode = new SNode<T>(a);
            //在空链表或第一个元素前插入第一个元素
            if (i == 1)
            {
                newNode.Next = start;   //先将newNode的Next指向start的值
                start = newNode;            //原start不是start，再将现在的start的引用指向newNode
                length++;
                return;
            }

            //单链表的两个元素之间插入一个元素
            //先找到要插入的位置 i ，返回的previous是要插入的位置的前驱，current是后继
            current = start;
            previous = null;
            int j = 1;
            while (current != null && j < i)           
            {
                previous = current;
                current = current.Next;
                j++;
            }

            if (j == i)
            {
                previous.Next = newNode;
                newNode.Next = current;
                length++;
            }
        }

        /// <summary>
        /// 判断表是否为空
        /// </summary>
        /// <returns>false or true</returns>
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
        /// 获得单链表中的第i个数据元素
        /// </summary>
        /// <param name="i">索引 i </param>
        /// <returns>第i个元素的值</returns>
        public T SearchNode(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return default(T);
            }

            SNode<T> current = start;
            int j = 1;
            while (current != null && j < i)
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
                Console.WriteLine("The ith node is not exist");
                return default(T);
            }

        }

        /// <summary>
        /// 在单链表里寻找值为value的数据元素，返回索引位置
        /// </summary>
        /// <param name="value">要查找的值</param>
        /// <returns>索引位置</returns>
        public int SearchNode(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return -1;
            }

            SNode<T> curent = start;
            int i = 0;
            while (!curent.Data.ToString().Contains(value.ToString()) && curent != null)
            {
                curent = curent.Next;
                i++;
            }
            if (curent != null)
                return i;
            else
                return -1;
        }
    }
}
