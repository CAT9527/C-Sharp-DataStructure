using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_数据结构CSharp版_二叉树
{
    class HNode
    {
        private int weight;                  //结点权值
        private int lChild;                    //左孩子结点
        private int rChild;                   //右孩子结点
        private int parent;                  //父节点

        //结点权值属性
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int LChild
        {
            get { return lChild; }
            set { lChild = value; }
        }
        public int RChild
        {
            get { return rChild; }
            set { rChild = value; }
        }
        public int Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public HNode()
        {
            weight = 0;
            lChild = -1;
            rChild = -1;
            parent = -1;
        }
    }
}
