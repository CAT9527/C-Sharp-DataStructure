using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_数据结构Csharp版_堆栈
{

    class StackNode<T>
    {
        private T data;   //数据域
        private StackNode<T> next;    //引用域

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public StackNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public StackNode()
        {
            data = default(T);
            next = null;
        }

        public StackNode(T value)
        {
            data = value;
            next = null;
        }
        public StackNode(T value,StackNode<T> p)
        {
            data = value;
            next = p;
        }
    }
}
