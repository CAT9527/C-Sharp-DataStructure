using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siki
{
    /// <summary>
    /// 顺序表实现方式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SeqList<T> : IListDS<T>
    {
        private T[] data;//数组，用来存储数据
        private int count = 0;      //表示存了多少的数据,标志位

        public SeqList(int size)  //size就是最大容量
        {
            data = new T[size];
            count = 0;
        }
        public SeqList() : this(10)    //调用参数为1的构造函数，size  = 10；
        {

        }

        /// <summary>
        /// 取得数据的个数
        /// </summary>
        /// <returns>数据数组的长度</returns>
        public int GetLength()
        {
            return count;
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="item">需要添加的数据</param>
        public void Add(T item)
        {
            if (count == data.Length)  //说明当前数组已存满
            {
                Console.WriteLine("当前顺序表已经存满，不允许再存入");
            }
            else
            {
                data[count] = item;    //如果有count个数据，则索引为count位置的就是新数据加入的位置
                count++;                    //count为计数器，自增1
            }
        }

        /// <summary>
        /// 取得顺序表中的元素
        /// </summary>
        /// <param name="index">元素索引</param>
        /// <returns></returns>
        public T GetEle(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }

        public T this[int index]
        {
            get { return GetEle(index); }
        }

        
        /// <summary>
        /// 清空操作，直接将标志位为0
        /// </summary>
        public void Clear()
        {
            count = 0;
        }

        /// <summary>
        /// 删除某个索引上的元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>索引上的元素</returns>
        public T Delete(int index)
        {
            T temp = data[index];
            for (int i = index + 1; i < count; i++)
            {
                data[i - 1] = data[i];        //把数据向前移动
            }
            count--;
            return temp;
        }

        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="item">要插入的数据</param>
        /// <param name="index">要插入的索引位置</param>
        public void Insert(T item, int index)
        {
            //如果前向后遍历会发生数据覆盖的问题     int i = index; i < count; i++
            //所以解决方案是后向前遍历      int i = count-1; i >=index; i--
            for (int i = count-1; i >=index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        /// <summary>
        /// 顺序表是否为空
        /// </summary>
        /// <returns>布尔值</returns>
        public bool IsEmpty()
        {
            return count == 0;
        }

        /// <summary>
        /// 返回数据存在的索引位置
        /// </summary>
        /// <param name="value">数据元素</param>
        /// <returns>存在返回索引，不存在返回-1</returns>
        public int Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (Array.IndexOf(data, value) > 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
