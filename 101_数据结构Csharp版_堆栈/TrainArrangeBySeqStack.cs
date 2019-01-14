using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_数据结构Csharp版_堆栈
{
    /// <summary>
    /// 用顺序栈解决火车车厢重排问题
    /// </summary>
    class TrainArrangeBySeqStack
    {
        //车厢重排算法。K个缓冲铁轨，车厢初始排序存放在p中
        bool Railroad(int[] p, int n, int k)
        {
            //如果重排成功,返回true，否则返回false
            //创建与缓冲铁轨对应的堆栈
            SeqStack<int>[] H;
            H = new SeqStack<int>[k + 1];
            for (int i = 1; i <= k; i++)
                H[i] = new SeqStack<int>(p.Length);

            int NowOut = 1;             //下一次要输出的车厢
            int minH = n + 1;            //缓冲铁轨中编号最小的车厢
            int minS = 0;                  //minH车厢对应的缓冲铁轨

            //车厢重排
            for (int i = 0; i < n; i++)
                if (p[i] == NowOut)
                {
                    Console.WriteLine("Move Car {0} from input to output", p[i]);
                    NowOut++;

                    //从缓冲铁轨中输出
                    while (minH == NowOut)
                    {
                        OutPut(ref minH, ref minS, ref H, k, n);
                        NowOut++;
                    }
                }
                else
                {
                    //将p[i]送入某个缓冲铁轨
                    if (!Hold(p[i], ref minH, ref minS, ref H, k, n))
                        return false;
                }
            return true;
        }

        //把车厢从缓冲铁轨送至出轨处，同时修改minS和minH
        void OutPut(ref int minH, ref int minS, ref SeqStack<int>[] H, int k, int n)
        {
            int c;                //车厢索引
            //从堆栈minS中删除编号最小的车厢minH
            c = H[minS].Pop();
            Console.WriteLine("Move Car {0} from holding track {1} to output", minH, minS);

            //通过检查所有的栈顶，搜索新的minH和minS
            minH = n + 2;
            for (int i = 1; i <= k; i++)         
                if (!H[i].isEmpty() && (H[i].GetTop()) < minH)
                {
                    minH = c;
                    minS = i;
                }       
        }

        //在一个缓冲铁轨中放入车厢C
        bool Hold(int c, ref int minH, ref int minS, ref SeqStack<int>[] H, int k, int n)
        {
            //如果没有可用的缓冲铁轨，则返回false
            //否则返回true
            //为车厢c寻找最优的缓冲铁轨
            //初始化

            int BestTrack = 0;                   //目前最优的铁轨
            int BestTop = n + 1;                 //最优铁轨上的头辆车厢
            int x;

            //扫描缓冲铁轨
            for (int i = 1; i <= k; i++)
                if (!H[i].isEmpty())
                {
                    //铁轨i不空
                    x = H[i].GetTop();
                    if (c < x && x < BestTop)
                    {
                        //铁轨i顶部的车厢编号最小
                        BestTop = x;
                        BestTrack = i;
                    }
                }
                else
                {
                    //铁轨i为空
                    if (BestTrack == 0) BestTrack = i;
                    break;
                }
                if (BestTrack == 0) return false;

                //把车厢c送入缓冲铁轨
                H[BestTrack].Push(c);
                Console.WriteLine("Move Car {0} from input to holding track {1}", c, BestTrack);

                //必要时修改minH和minS
                if (c < minH)
                {
                    minH = c;
                    minS = BestTrack;
                }
            return true;
        }

        //调用火车车厢重排算法Railroad()重排车厢
        public static void Main2()
        {
            int[] p = new int[] { 5,8,1,7,4,2,9,6,3 };
            int k = 3;

            TrainArrangeBySeqStack ta = new TrainArrangeBySeqStack();
            bool result;
            result = ta.Railroad(p, p.Length, k);

            do
            {
                if (result == false)
                {
                    Console.WriteLine("need more holding track,please enter additional number:");
                    k = k + Convert.ToInt32(Console.ReadLine());
                    result = ta.Railroad(p, p.Length, k);
                }
            } while (result == false);
            Console.ReadLine();
        }
    }
}
