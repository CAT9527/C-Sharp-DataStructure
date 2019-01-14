using System;

namespace _101_数据结构Csharp版_堆栈
{
    class LinkStack<T> : IStack<T>
    {
        //初始化
        private StackNode<T> top;          //栈顶指示器
        private int size;                             //栈中元素个数
        public StackNode<T> Top
        {
            get { return top; }
            set { top = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        //初始化链栈
        public LinkStack()
        {
            top = null;
            size = 0;
        }
        public void Clear()
        {
            top = null;
            size = 0;
        }
        public int GetLength()
        {
            return size;
        }
        public T GetTop()
        {
            if (isEmpty())
            {
                Console.WriteLine("栈为空，无法执行GetTop取栈顶元素");
                return default(T);
            }
            return top.Data;
        }
        public bool isEmpty()
        {
            if (top == null && size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("栈为空，无法执行Pop出栈操作");
                return default(T);
            }
            StackNode<T> current = top;
            top = top.Next;
            --size;                          //先自减再保存size值
            return current.Data;
        }
        /// <summary>
        /// 入栈操作
        /// </summary>
        /// <param name="item">需要入栈的元素</param>
        public void Push(T item)
        {
            StackNode<T> newNode = new StackNode<T>(item);
            if (top==null)
            {
                top = newNode;
            }
            else
            {
                top.Next = newNode;
                top = newNode;
            }
            ++size;
        }
    }
}
