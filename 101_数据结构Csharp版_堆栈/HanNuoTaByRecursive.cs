using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_数据结构Csharp版_堆栈
{
    /// <summary>
    /// 使用递归解决汉诺塔问题
    /// </summary>
    class HanNuoTaByRecursive
    {
        public void hanoi(int n ,string x,string y,string z)
        {
            if(n==1)
                Console.WriteLine("{0}--->{1}",x,z);
            else
            {
                hanoi(n - 1, x, z, y);
                Console.WriteLine("{0}--->{1}", x, z);
                hanoi(n - 1, y, x, z);
            }
        }

        static void Main()
        {
            HanNuoTaByRecursive ha = new HanNuoTaByRecursive();
            int m;
            Console.WriteLine("Input number:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("moving {0} diskes",m);
            ha.hanoi(m, "a", "b", "c");
            Console.ReadKey();
        }
    }
}
