using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    /// <summary>
    /// 链表节点类 ，数据域，引用域各一个
    /// </summary>
    class SNode<T>
    {
        //初始化 数据域（data:T） 引用域（next:SNode<T>） 封装字段   四个构造方法
        private T data;
        private SNode<T> next;

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

        public SNode()
        {
            data = default(T);
            next = null;
        }

        public SNode(T data)
        {
            this.data = data;
            next = null;
        }

        public SNode(SNode<T> next)
        {
            data = default(T);
            this.next = next;
        }
        public SNode(T data, SNode<T> next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
