using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_数据结构Csharp版_队列
{
    /// <summary>
    /// 链队列的节点类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QueueNode<T>
    {
        private T data;                                     //数据域
        private QueueNode<T> next;            //引用域

        //构造函数
        public QueueNode()
        {
            data = default(T);
            next = null;
        }
        public QueueNode(T val)
        {
            data = val;
        }
        public QueueNode(QueueNode<T> p)
        {
            next = p;
        }
        public QueueNode(T val,QueueNode<T> p)
        {
            data = val;
            next = p;
        }
        
        //封装属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public QueueNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
