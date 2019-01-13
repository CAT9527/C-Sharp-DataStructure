using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_数据结构CSharp版_二叉树
{
    class HuffmanTree
    {
        private HNode[] data;     //结点数目
        private int leafNum;        //叶子结点数目

        //索引器
        public HNode this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //叶子结点数目属性
        public int LeafNum
        {
            get { return leafNum; }
            set { leafNum = value; }
        }

        //构造器
        public HuffmanTree(int n)
        {
            data = new HNode[2 * n - 1];
            for (int i = 0; i < 2 * n - 1; i++)
                data[i] = new HNode();
            leafNum = n;
        }

        //创建哈夫曼树
        public void Create()
        {
            int m1, m2, x1, x2;

            //输入n个叶子结点的权值
            for(int i = 0; i < this.leafNum; ++i)
            {
                data[i].Weight = Convert.ToInt32(Console.ReadLine());
            }

            //处理n个叶子结点，建立哈夫曼树
            for(int i = 0; i < this.leafNum - 1; ++i)
            {
                m1 = m2 = Int32.MaxValue;
                x1 = x2 = 0;

                //在全部结点中寻找权值最小的两个结点
                for (int j = 0; j < this.leafNum + 1; ++j)
                {
                    if ((data[j].Weight < m1) && (data[j].Parent == -1))
                    {
                        m2 = m1;
                        x2 = x1;
                        m1 = data[j].Weight;
                        x1 = j;
                    }else if ((data[j].Weight < m2) && (data[j].Parent == -1))
                    {
                        m2 = data[j].Weight;
                        x2 = j;
                    }
                }
                data[x1].Parent = this.leafNum + i;
                data[x2].Parent = this.leafNum + i;
                data[this.leafNum + i].Weight = data[x1].Weight + data[x2].Weight;
                data[this.leafNum + i].LChild = x1;
                data[this.leafNum + i].RChild = x2;
            }
        }
    }
}
