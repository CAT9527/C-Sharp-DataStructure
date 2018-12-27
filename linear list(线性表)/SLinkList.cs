using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_list_线性表_
{
    /// <summary>
    ///用单链表表示线性表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// 

    class SNode<T>
    {
        private T data;                   //数据域
        private SNode<T> next;    //引用域

        //单链表的四个构造函数：
        public SNode(T val,SNode<T> p)
        {
            data = val;
            next = p;
        }
        public SNode(SNode<T> p)
        {
            next = p;
        }
        public SNode(T val)
        {
            data = val;
            next = null;
        }
        public SNode()
        {
            data = default(T);
            next = null;
        }

        //数据域属性
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        //引用域属性
        public SNode<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
    class SLinkList<T> : ILinearList<T>
    {
        //一、初始化单链表
        //1、先声明一个结点类型的start变量，用于表示单链表的第一个结点
        private SNode<T> start;      //单链表的头引用
        int length;                            //单链表的长度

        //2、然后在单链表的构造函数中将start变量的值赋为null
        public SLinkList()
        {
            start = null;
        }

        //二、插入操作
        //1、在单链表的末尾追加数据元素
        public void InsertNode(T a)
        {
            if(start == null)
            {
                start = new SNode<T>(a);
                length++;
                return;
            }

            SNode<T> current = start;

            while(current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new SNode<T>(a);
            length++;
        }
        //2、在单链表的第i个数据元素的位置前插入一个数据元素
        public void InsertNode(T a, int i)
        {
            SNode<T> current;
            SNode<T> previous;
            if (i < 1 || i > length + 1)
            {
                Console.WriteLine("Position is error!!!");
                return;
            }
            SNode<T> newnode = new SNode<T>(a);

            //在空链表或第一个元素前插入第一个元素
            if (i == 1)
            {
                newnode.Next = start;
                start = newnode;
                length++;
                return;
            }

            //在单链表的两个元素之间插入一个元素
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
                previous.Next = newnode;
                newnode.Next = current;
                length++;
            }
        }

        //三、删除操作
        public void DeleteNode(int i)
        {
            if (IsEmpty() || i < 1)
            {

            }
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int GetLength()
        {
            return length;
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public T SearchNode(int i)
        {
            throw new NotImplementedException();
        }

        public T SearchNode(T value)
        {
            throw new NotImplementedException();
        }
    }
}
