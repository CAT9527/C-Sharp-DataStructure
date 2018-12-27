using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siki
{
    /// <summary>
    /// 顺序表的接口
    /// </summary>
    /// <typeparam name="T">泛型</typeparam>
    interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(T item, int index);
        T Delete(int index);
        T this[int index] { get; }
        T GetEle(int index);
        int Locate(T value);
    }
}
