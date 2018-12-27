using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    /// <summary>
    /// 顺序表的基本操作，继承于线性表基本操作类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SeqList<T> : IlinarList<T>
    {
        //1.初始化（用于存储数据的数组）（最大容量size）（实际长度）
        private T[] data;                 //使用数组存储数据
        private int maxsize;           //最大容量
        private int length = 0;          //数组元素的数量

        public int Maxsize
        {
            get
            {
                return maxsize;
            }
            set
            {
                maxsize = value;
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
        }

        public SeqList(int size)
        {
            maxsize = size;
            data = new T[size];
            length = 0;
        }
        public SeqList() : this(10) { }

        /// <summary>
        /// 清空操作
        /// </summary>
        public void Clear()
        {
            length = 0;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="i">第i个数据元素</param>
        public void DeleteNode(int i)
        {
            if (length == 0)
            {
                Console.WriteLine("表为空，不能删除");
            }
            if (i < 1 || i > length)
            {
                Console.WriteLine("索引位置有误");
            }
            else
            {
                for(int j = i - 1; j < length; j++)
                {
                    data[j-1] = data[j];
                }
                length--;
            }
        }

        /// <summary>
        /// 获取表长度
        /// </summary>
        /// <returns>表长度count</returns>
        public int GetLength()
        {
            return length;
        }

        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="a">要插入的值</param>
        /// <param name="index">索引位置</param>
        public void InsertNode(T a, int i)
        {
            if (length == 0)
            {
                data[0] = a;
                length++;
            }else if (length == maxsize)
            {
                Console.WriteLine("表已满，不能插入");
            }
            else
            {
                for(int j = length - 1; j >= i - 1; j--)
                {
                    data[j + 1] = data[j];
                }
                data[i - 1] = a;
            }
            length++;
        }

        /// <summary>
        /// 判断表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return length == 0;
        }

        /// <summary>
        /// 获得顺序表中的第i个数据元素
        /// </summary>
        /// <param name="i"></param>
        /// <returns>data[i-1]</returns>
        public T SearchNode(int i)
        {
            if (IsEmpty() || (i < 1) || (i > length))
            {
                Console.WriteLine("表为空或者索引位置有误");
                return default(T);
            }

                return data[i - 1];

            
        }

        /// <summary>
        /// 在顺序表中查找值为value的数据元素
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int SearchNode(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("表为空");
                return -1;
            }
            int i = 0;
            for(i = 0; i < length; i++)
            {
                if (data[i].ToString().Contains(value.ToString()))
                {
                    break;
                }
            }
            if (i >= length)
            {
                return -1;
            }
            return i;
            
        }

        
    }
}
