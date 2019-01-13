using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    /// <summary>
    /// 循环链表的实现类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CLinkList<T> : IlinarList<T>
    {

        private SNode<T> start;    //循环链表的头引用
        int length;                           //循环链表的长度

        public CLinkList()
        {
            start = null;
        }
        public void Clear()
        {
            start = null;
        }

        public void DeleteNode(int i)
        {
            if (IsEmpty() || i < 0 || i > length)
            {
                Console.WriteLine("Link is empty or Position is error");
            }
            SNode<T> current = start;

            if(i == 1)
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

        public int GetLength()
        {
            return length;
        }

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

        public bool IsEmpty()
        {
            return start == start.Next;
        }

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

        public T SearchNode(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return default(T);
            }

            SNode<T> current = start;
            int i = 0;
            while (!current.Data.ToString().Contains(value.ToString()) && current != null)
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
