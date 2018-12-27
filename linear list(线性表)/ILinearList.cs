using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_list_线性表_
{
    /// <summary>
    /// 线性表的基础定义
    /// </summary>
    /// <typeparam name="T">数据类型</typeparam>
    /// 

    interface ILinearList<T>
    {
        void InsertNode(T a, int i);    //插入操作，在位置i插入值为a的新元素
        void DeleteNode(int i);          //删除操作，删除位置为i的元素
        T SearchNode(int i);              //取表元素，返回第i个数据元素
        T SearchNode(T value);        //定位元素，返回value的数据元素的序号，如果没有，则返回一个特殊值表示返回失败
        int GetLength();                     //求表长度
        void Clear();                           //清空操作，清除所有表数据
        bool IsEmpty();                       //判断线性表是否为空
    }
}
