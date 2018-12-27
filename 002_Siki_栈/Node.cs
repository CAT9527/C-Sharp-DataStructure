using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Siki_栈
{
    /// <summary>
    /// 链栈的节点类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T data)
        {
            this.data = data;
            next = null;
        }
        public Node(T data,Node<T> next)
        {
            this.data = data;
            this.next = next;
        }
        public Node(Node<T> next)
        {
            data = default(T);
            this.next = next;
        }

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

        public Node<T> Next
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
}
