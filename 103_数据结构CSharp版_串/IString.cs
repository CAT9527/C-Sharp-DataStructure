using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_数据结构CSharp版_串
{
    /// <summary>
    /// 串的基本操作接口类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IString<T>
    {
        int Compare(T s);                     //串比较
        T SubString(int index, int len);      //求子串
        int GetLength();                      //求串的长度
        T Concat(T s);                        //串连接
        int indexOf(T s, int startpos);       //串定位
        T Insert(int index, T s);             //串插入
        T Delete(int index, int len);         //串删除
    }
}
