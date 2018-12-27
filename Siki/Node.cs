using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siki
{
    /// <summary>
    /// 单链表的节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Node<T>
    {
        private T data;  //存储数据
        private Node<T> next;  //指针 用来指向下一个元素

        /// <summary>
        /// 四个构造方法
        /// </summary>
        public Node()
        {
            data = default(T);
            next = null;
        }
        public Node(T value)
        {
            data = value;
            next = null;
        }
        public Node(Node<T> next)
        {
            this.next = next;
        }
        public Node(T value,Node<T> next)
        {
            this.data = value;
            this.next = next;
        }

        /// <summary>
        /// 两个字段的属性定义，使用get,set方法访问data,next
        /// </summary>
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
