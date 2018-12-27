using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Siki_队列
{
    /// <summary>
    /// 单链队列
    /// </summary>
    class Node<T>
    {
        private T data;
        private Node<T> next;


        public Node(T data)
        {
            this.data = data;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }


}
