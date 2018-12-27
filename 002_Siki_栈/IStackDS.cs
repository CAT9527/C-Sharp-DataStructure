using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 栈的接口实现类
/// </summary>
namespace _002_Siki_栈
{
    interface IStackDS<T>
    {
        int Count { get; }   //用来取得数据的个数
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Push(T item);
        T Pop();
        T Peek();
    }
}
