using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    /// <summary>
    /// 双向链表的节点类
    /// </summary>
    class DbNode<T>
    {
        //初始化  数据域（data:T）前驱引用域（prev:DbNode<T>）  后继引用域（next:DbNode<T>）封装字段   四个构造函数
        private T data;    //数据域
        private DbNode<T> prev;  //前驱引用域
        private DbNode<T> next;  //后继引用域

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public DbNode<T> Prev
        {
            get
            {
                return prev;
            }
            set
            {
                prev = value;
            }
        }
        public DbNode<T> Next
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

        public DbNode()
        {
            data = default(T);
            next = null;
        }
        public DbNode(T value)
        {
            data = value;
            next = null;
        }
        public DbNode(DbNode<T> n)
        {
            data = default(T);
            next = n;
        }
        public DbNode(T value,DbNode<T> n)
        {
            data = value;
            next = n;
        }
    }
}
