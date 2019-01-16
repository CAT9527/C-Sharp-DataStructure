using System;
using System.Collections.Generic;

namespace _105_数据结构CSharp版_二叉树
{
    /// <summary>
    /// 不带头节点的二叉树的二叉树链表类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkBiTree<T>
    {
        private Node<T> head;        //头引用
        //头引用属性
        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        //构造函数
        public LinkBiTree()
        {
            head = null;
        }
        public LinkBiTree(T val)
        {
            Node<T> p = new Node<T>(val);
            head = p;
        }
        public LinkBiTree(T val, Node<T> lp,Node<T> rp)
        {
            Node<T> p = new Node<T>(val,lp,rp);
            head = p;
        }

        /// <summary>
        /// 判断是否是空二叉树
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得根结点
        /// </summary>
        /// <returns></returns>
        public Node<T> Root()
        {
            return head;
        }

        /// <summary>
        /// 获取左孩子结点
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Node<T> GetLChild(Node<T> p)
        {
            if (p.LChild == null) return null;
            else return p.LChild;
        }

        /// <summary>
        /// 获得右孩子结点
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Node<T> GetRChild(Node<T> p)
        {
            if (p.RChild == null) return null;
            else return p.RChild;
        }

        /// <summary>
        /// 将结点p的左子树插入值为val的新结点。原来的左子树成为新结点的左子树
        /// </summary>
        /// <param name="val">值为val的新结点</param>
        /// <param name="p">结点p</param>
        public void InsertL(T val,Node<T> p)
        {
            Node<T> tmp = new Node<T>(val);
            tmp.LChild = p.LChild;
            p.LChild = tmp;
        }

        /// <summary>
        /// 将结点p的右子树插入值为val的新结点。原来的右子树成为新结点的右子树
        /// </summary>
        /// <param name="val">值为val的新结点</param>
        /// <param name="p">结点p</param>
        public void InsertR(T val,Node<T> p)
        {
            Node<T> tmp = new Node<T>(val);
            tmp.RChild = p.RChild;
            p.RChild = tmp;
        }

        //若p非空，删除p的左子树
        public Node<T> DelectL(Node<T> p)
        {
            if (p == null || p.LChild == null)
            {
                return null;
            }
            Node<T> tmp = p.LChild;
            p.LChild = null;
            return tmp;
        }
        //若p非空，删除p的右子树
        public Node<T> DelectR(Node<T> p)
        {
            if (p == null || p.RChild == null)
            {
                return null;
            }
            Node<T> tmp = p.RChild;
            p.RChild = null;
            return tmp;
        }

        //编写算法，在二叉树中查找值为value的结点
        public Node<T> Search(Node<T> root, T value)
        {
            Node<T> p = root;
            if (p == null)
                return null;
            if (!p.Data.Equals(value))
                return p;

            if (p.LChild != null)
                return Search(p.LChild, value);

            if (p.RChild != null)
                return Search(p.RChild, value);

            return null;
        }

        //判断是否是叶子结点
        public bool IsLeaf(Node<T> p)
        {
            if ((p != null) && (p.LChild == null) && (p.RChild == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //中序遍历   LDR
        //中序遍历根节点的左子树
        //访问根结点
        //中序遍历根结点的右子树
        public void InOrder(Node<T> ptr)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Tree is empty  !!!");
                return;
            }
            if (ptr != null)
            {
                InOrder(ptr.LChild);
                Console.Write(ptr.Data+" ");
                InOrder(ptr.RChild);
            }
        }

        //先序遍历      DLR
        public void PreOrder(Node<T> ptr)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Tree is empty  !!!");
                return;
            }
            if (ptr != null)
            {
                Console.Write(ptr.Data + "  ");
                PreOrder(ptr.LChild);
                PreOrder(ptr.RChild);
            }
        }

        //后序遍历        LRD
        public void PostOrder(Node<T> ptr)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Tree is empty  !!!");
                return;
            }
            if (ptr != null)
            {
                PostOrder(ptr.LChild);
                PostOrder(ptr.RChild);
                Console.Write(ptr.Data+"   ");
            }
        }


        //层次遍历
        public void LevelOrder(Node<T> root)
        {
            //根结点为空
            if (root == null)
            {
                return;
            }
            Queue<Node<T>> sq = new Queue<Node<T>>(50);
            //设置一个队列保存层次遍历的结点
            //根结点入队
            sq.Enqueue(root);

            //队列非空，结点还没有处理完成
            while (sq.Count != 0)
            {
                //结点出队
                Node<T> tmp = sq.Dequeue();
                //处理当前结点
                Console.Write("{0}",tmp);

                //将当前结点的左孩子结点入队
                if (tmp.LChild != null)
                {
                    sq.Enqueue(tmp.LChild);
                }

                //将当前结点的右孩子结点入队
                if (tmp.RChild != null)
                {
                    sq.Enqueue(tmp.RChild);
                }
            }
        }
    }
}
