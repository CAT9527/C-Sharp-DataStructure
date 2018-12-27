using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Siki_串
{
    class StringDS
    {
        private char[] data;   //用来存放字符串中的字符

        public StringDS(char[] array)
        {
            data = new char[array.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = array[i];
            }
        }

        public StringDS(string str)
        {
            data = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                data[i] = str[i];
            }
        }
        //根据索引访问字符的索引器
        public char this[int index]
        {
            get { return data[index]; }
        }

        //获取长度
        public int GetLength()
        {
            return data.Length;
        }

        /// <summary>
        /// 如果两个字符串一样，那么返回0
        /// 如果当前字符串小于s，那么返回-1
        /// 如果当前字符串大于s，那么返回 1
        /// 可以用作各种排序（比如按照姓名拼音首字母来排序姓名）
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Compare(StringDS s)
        {
            int len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength();  //取得两个字符串中长度更小的那个字符串长度
            int index = -1;  //存储不相等的字符的索引位置
            for (int i = 0; i < len; i++)
            {
                if (this[i] != s[i])
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                if (this[index] > s[index])
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (this.GetLength() == s.GetLength())
                {
                    return 0;
                }
                else
                {
                    if (this.GetLength() > s.GetLength())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        /// <summary>
        /// 字符串从索引index截取一段长度为length为新的字符串并返回
        /// </summary>
        /// <param name="index">开始索引</param>
        /// <param name="length">截取长度</param>
        /// <returns></returns>
        public StringDS SubString(int index, int length)
        {
            char[] newData = new char[length];
            for (int i = index; i < index + length; i++)
            {
                newData[i - index] = data[i];
            }
            return new StringDS(newData);
        }

        //402-06:21
        public static StringDS Concat(StringDS s1, StringDS s2)
        {
            char[] newData = new char[s1.GetLength() + s2.GetLength()];
            for (int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }
            for (int j = 0; j < s2.GetLength(); j++)
            {
                newData[s1.GetLength() + j] = s2[j];
            }
            return new StringDS(newData);
        }

        public int IndexOf(StringDS s)
        {
            for (int i = 0; i < this.GetLength() - s.GetLength(); i++)
            {
                bool isEqual = true;
                for (int j = i; j < i + s.GetLength(); j++)
                {
                    if (this[j] != s[j - i])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual)
                {
                    return i;
                }
                else
                {
                    continue;
                }
            }
            return -1;
        }

        public string ToString()
        {
            return new string(data);
        }
    }
}