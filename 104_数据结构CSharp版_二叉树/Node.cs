using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_数据结构CSharp版_二叉树
{
    /// <summary>
    /// 二叉链表的结点类
    /// </summary>
    class Node<T>
    {
        private T data;       //数据域
        private Node<T> lChild;            //左孩子的指针域
        private Node<T> rChild;            //右孩子的指针域

        //封装属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> LChild
        {
            get { return lChild; }
            set { lChild = value; }
        }

        public Node<T> RChild
        {
            get { return rChild; }
            set { rChild = value; }
        }

        //构造函数
        public Node(T val, Node<T> lp, Node<T> rp)
        {
            data = val;
            lChild = lp;
            rChild = rp;
        }
        public Node(Node<T> lp, Node<T> rp)
        {
            data = default(T);
            lChild = lp;
            rChild = rp;
        }
        public Node(T val)
        {
            data = val;
            lChild = null;
            rChild = null;
        }
        public Node()
        {
            data = default(T);
            lChild = null;
            rChild = null;
        }

    }
}
