using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/// <summary>
/// 数学魔术游戏（有错误）
/// </summary>
namespace _104_数据结构Csharp版_数组
{
    class GuessNumber
    {
        public static void Main()
        {
            int[,] num = new int[5, 6];           //存储卡片上的数字
            int[] len = new int[5];               //动态添加卡片上的数字，统计每张卡片上数字的个数
            char[] bit;
            for (int i = 1; i <= 31; i++)
            {
                bit = ToBinary(i);
                for (int j = 0; j < bit.Length; j++)
                    if (bit[j] == '1')
                        num[j, len[j]++] = i;
            }

            //随机产生一个1到31之间的整数
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int numrand = ra.Next(1, 31);
            bit = ToBinary(numrand);
            string cardrand = "";
            for (int i = 0; i < bit.Length; i++)
                if (bit[i] == '1')
                    cardrand = cardrand + (i + 1) + ",";
            Console.Write("在卡片：{0}都存在的数是：", cardrand);
            int guessnum = Convert.ToInt32(Console.ReadLine());
            if (guessnum == numrand)
                Console.WriteLine("恭喜你，猜对了");
            else
                Console.WriteLine("猜错了，该数应该是{0}，再试一次！", numrand);

            //列出随即数据在卡片上的数字
            Console.WriteLine("{0}在卡片上的数字为：", numrand);
            for (int i = 0; i < bit.Length; i++)
            {
                if (bit[i] == '1')
                {
                    Console.Write("卡片{0}：", (i + 1));
                    for (int j = 0; j < 16; j++)
                    {
                        Console.WriteLine(num[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //将一个十进制数转换成二进制数并将其存放在字符数组中
        public static char[] ToBinary(int x)
        {
            char temp;               //实现bit反转时用
            char[] bit = new char[5];
            bit = Convert.ToString(x, 2).ToCharArray();
            for (int j = 0; j < bit.Length / 2; j++)
            {
                temp = bit[j];
                bit[j] = bit[bit.Length - 1 - j];
                bit[bit.Length - 1 - j] = temp;
            }
            return bit;
        }
    }
}
