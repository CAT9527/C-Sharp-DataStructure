using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    /// <summary>
    /// 线性表的基本操作的定义接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IlinarList<T>
    {
        void InsertNode(T a, int i);    //插入操作 （在索引i上插入a值）
        void DeleteNode(int i);          //删除操作 (删除某个索引i上的值)
        T SearchNode(int i);             //查找操作
        T SearchNode(T value);       //定位元素
        int GetLength();                    //求表长度
        void Clear();                         //清空操作
        bool IsEmpty();                    //判断线性表是否为空
    }
}
