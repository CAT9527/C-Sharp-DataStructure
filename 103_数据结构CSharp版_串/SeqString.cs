using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_数据结构CSharp版_串
{
    class SeqString : IString<SeqString>
    {
        private char[] data;      //字符数组
        public char this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //三个构造函数
        public SeqString(char[] arr)
        {
            data = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                data[i] = arr[i];
            }
        }
        public SeqString(SeqString s)
        {
            data = new char[s.GetLength()];
            for (int i = 0; i < s.GetLength(); i++)
            {
                data[i] = s[i];
            }
        }
        //求串长度
        public SeqString(int len)
        {
            data = new char[len];
        }
        //串比较
        public int Compare(SeqString s)
        {
            int len = ((this.GetLength() <= s.GetLength()) ? this.GetLength() : s.GetLength());
            int i = 0;
            for (i = 0; i < len; ++i)
            {
                if (this[i] != s[i])
                {
                    break;
                }
            }
            if (i < len)
            {
                if (this[i] < s[i])
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else if (this.GetLength() == s.GetLength())
            {
                return 0;
            }
            else if (this.GetLength() < s.GetLength())
                return -1;
            else
                return 1;
        }

        //串连接
        public SeqString Concat(SeqString s)
        {
            SeqString s1 = new SeqString(this.GetLength() + s.GetLength());
            for (int i = 0; i < this.GetLength(); i++)
            {
                s1.data[i] = this[i];
            }
            for (int i = 0; i < s.GetLength(); i++)
            {
                s1.data[i + this.GetLength()] = s[i];
            }
            return s1;
        }

        //串删除
        public SeqString Delete(int index, int len)
        {
            if ((index < 0) || (index > this.GetLength() - 1) || (len < 0) || (len > this.GetLength() - index))
            {
                Console.WriteLine("Position or Length is error");
                return null;
            }

            SeqString s = new SeqString(this.GetLength() - len);
            int j = 0;
            for (int i = 0; i < index; i++)
            {
                s[j++] = this[i];
            }
            for (int i = index+len; i < this.GetLength(); ++i)
            {
                s[j++] = this[i];
            }
            return s;
        }

        public int GetLength()
        {
            return data.Length;
        }

        //串定位
        public int indexOf(SeqString s, int startpos)
        {
            SeqString sub;
            sub = this.SubString(startpos, this.GetLength() - startpos);
            if (sub.GetLength() < s.GetLength())
            {
                Console.WriteLine("There is not string s");
                return -1;
            }

            int i, j, v;
            i = 0; j = 0;
            while (i < sub.GetLength() && j < s.GetLength())
            {
                if (sub.data[i] == s.data[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i = i - j + 1;
                    j = 0;
                }
            }
            if (j == s.GetLength())
                v = i - s.GetLength() + startpos;
            else
                v = -1;

            return v;
        }

        //串插入
        public SeqString Insert(int index, SeqString s)
        {
            int len = s.GetLength();
            int len2 = len + this.GetLength();
            SeqString s1 = new SeqString(len2);
            if (index < 0 || index > this.GetLength() - 1)
            {
                Console.WriteLine("Position is error");
                return null;
            }
            for (int i = 0; i < index; ++i)
            {
                s1[i] = this[i];
            }
            for (int i = index; i < index+len; ++i)
            {
                s1[i] = s[i - index];
            }
            for (int i = index + len; i < len2; ++i)
            {
                s1[i] = this[i - len];
            }
            return s1;
        }
        /// <summary>
        /// 求子串，从index开始找长度为len的子串
        /// </summary>
        /// <param name="index">开始索引</param>
        /// <param name="len">子串长度</param>
        /// <returns>子串</returns>
        public SeqString SubString(int index, int len)
        {
            if ((index < 0) || (index > this.GetLength() - 1) || (len <= 0) || (len > this.GetLength() - index))
            {
                Console.WriteLine("Position or Length is error");
                return null;
            }

            SeqString s = new SeqString(len);
            for (int i = 0; i < len; i++)
            {
                s[i] = this[i + index];
            }
            return s;
        }

        public override string ToString()
        {
            return new String(data);
        }
    }
}
