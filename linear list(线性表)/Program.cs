using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_list_线性表_
{
    class Program1
    {
        private static void Main1()
        {
            
        }
    }

    public class List<T>
    {
        private int maxsize;
        private T[] data;
        private int length;

        public int Length
        {
            get
            {
                return Length;
            }
        }

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

        public void Serch(T a)
        {

        }
    }


    public class sList<T> 
    {
        //定义线性表的基础属性
        private int maxsize;          //顺序表的最大容量
        private T[] data;                //数组，用于存储顺序表中的数据元素
        private int length;              //顺序表的实际长度

        //实际长度属性
        public int Length
        {
            get
            {
                return length;
            }
        }
        //最大容量属性
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

        //下面开始线性表的基本操作实现
        //1、初始化线性表
        public sList(int size)
        {
            maxsize = size;
            data = new T[maxsize];
            length = 0;
        }

        //2、线性表的插入操作（包括末尾添加和中间添加）
        //在顺序表的末尾追加数据元素
        public void InsertNode(T a)
        {
            //如果表已经满了，就在最后一位添加，并将表长度+1
            if (IsFull())
            {
                Console.WriteLine("LIst is full ！！！");
                return;
            }
            data[length] = a;
            length++;
        }
        //在顺序表内追加数据元素
        public void InsertNode(T a, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("LIst is full ！！！");
                return;
            }
            if (i < 1 || i > length + 1)
            {
                Console.WriteLine("Position is error！！！");          //位置i错误
                return;
            }
            else
            {
                //从末尾，将元素往后移动一位
                for (int j = length - 1; j >= i - 1; j--)
                {
                    data[j + 1] = data[j];
                }
                //然后再将数据a插入序号i-1的位置
                data[i - 1] = a;
            }
            //表长度+1
            length++;
        }

        //3、顺序表的删除操作
        //删除表中的第i个数据元素
        public void DeleteNode(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty !!!");
                return;
            }
            if (i < 1 || i > length + 1)
            {
                Console.WriteLine("Position is error！！！");          //位置i错误
                return;
            }
            else
            {
                //直接将位置i-1以后的数据往前移动一位
                for (int j = i; j < length; j++)
                {
                    data[j - 1] = data[j];
                }
                length--;
            }
        }

        //4、查找表元素
        //获得顺序表中的第i个数据元素
        public T SearchNode(int i)
        {
            if (IsEmpty() || (i < 1) || (i > length))
            {
                Console.WriteLine("List is empty or Position is error");
                return default(T);
            }
            return data[i - 1];
        }

        //5、定位表元素
        //在顺序表中查找值为value的数据元素，返回第一个出现value值的序号
        public T SearchNode(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty !!!");
                return default(T);
            }
            int i = 0;
            for (i = 0; i < length; i++)
            {
                if (data[i].ToString().Contains(value.ToString()))
                {
                    break;
                }
            }
            if (i >= length)
            {
                return default(T);
            }
            return data[i];
        }

        //6、求表长度
        public int GetLength()
        {
            return length;
        }

        //7、清空表数据
        public void Clear()
        {
            length = 0;
        }

        //8、判断顺序表是否为空
        public bool IsEmpty()
        {
            if (length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //9、判断顺序表是否为满
        public bool IsFull()
        {
            if (length == maxsize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
