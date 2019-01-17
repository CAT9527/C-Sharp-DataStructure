using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_数据结构CSharp版_二叉树
{
    /// <summary>
    /// 在二叉树中，如果一个结点的左子结点永远小于该结点的值，右子结点永远大于该结点的值，这样的二叉树叫做二叉搜索树
    /// 用“二叉搜索树”解决快速搜索磁盘文件记录的问题
    /// </summary>
    
    public struct indexNode
    {
        private int key;
        private int offset;
        public indexNode(int key,int offset)
        {
            this.key = key;
            this.offset = offset;
        }
    }
    class LinkBiSearchTree
    {
    }
}
