using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_数据结构Csharp版_线性表
{
    /// <summary>
    /// 编写程序实现学生成绩管理系统中要求的各种功能
    /// </summary>
    /// 
    class StuNode
    {
        private string stu_no;
        private string stu_name;
        private int stu_score;
        public string Stu_no
        {
            get { return stu_no; }
            set { stu_no = value; }
        }
        public string Stu_name
        {
            get { return stu_name; }
            set { stu_name = value; }
        }
        public int Stu_score
        {
            get { return stu_score; }
            set { stu_score = value; }
        }

        public StuNode(string stu_no,string stu_name,int stu_score)
        {
            this.stu_no = stu_no;
            this.stu_name = stu_name;
            this.stu_score = stu_score;
        }

        public override string ToString()
        {
            return stu_no + stu_name;
        }
    }
    class SeqListApp
    {
        public static void Main()
        {
            IlinarList<StuNode> stuList = null;
            Console.Write("请选择存储数据的类型：1.顺序表 2.单链表 3.双向链表 4.循环链表：");
            char seleflag = Convert.ToChar(Console.ReadLine());
            switch (seleflag)
            {
                /*初始化顺序表*/
                case '1':
                    Console.Write("请输入学生数：");
                    int maxsize = Convert.ToInt32(Console.ReadLine());
                    stuList = new SeqList<StuNode>(maxsize);
                    break;

            }

            while (true)
            {
                Console.WriteLine("请输入操作选项：");
                Console.WriteLine("1.添加学生成绩：");
                Console.WriteLine("2.删除学生成绩：");
                Console.WriteLine("3.按名字查询学生成绩：");
                Console.WriteLine("4.按学号查询学生成绩：");
                Console.WriteLine("5.按升序显示所有学生成绩");
                Console.WriteLine("6.按降序显示所有学生成绩");
                Console.WriteLine("7.退出");
                seleflag = Convert.ToChar(Console.ReadLine());
            }

            switch (seleflag)
            {
                /*添加学生成绩*/
                case '1':
                    {
                        char flag;
                        do
                        {
                            string stu_no;
                            string stu_name;
                            int stu_score;
                            Console.Write("请输入学号");
                            stu_no = Console.ReadLine();
                            Console.WriteLine("请输入姓名");
                            stu_name = Console.ReadLine();
                            Console.WriteLine("请输入学生成绩");
                            stu_score = Convert.ToInt32(Console.ReadLine());

                            //创建新结点，结点类型为StuNode
                            StuNode newNode = new StuNode(stu_no, stu_name, stu_score);
                           
                            if (stuList.GetLength() == 0)                         
                            {
                                //如果顺序表为空，直接把新结点放在第一位
                                stuList.InsertNode(newNode, 1);
                            }
                            else if (newNode.Stu_score > stuList.SearchNode(stuList.GetLength()).Stu_score)   
                            {
                                //如果新结点成绩大于列表最后一个结点的成绩，则把新结点放在最后一个结点之后
                                stuList.InsertNode(newNode, stuList.GetLength() + 1);
                            }
                            else
                            {
                                //如果前两种情况都不是，那么遍历顺序表结点，当新结点成绩小于当前结点，则将新结点放在当前结点位置
                                for (int i = 1; i <= stuList.GetLength(); i++)
                                {
                                    if (newNode.Stu_score <= (stuList.SearchNode(i).Stu_score))
                                    {
                                        stuList.InsertNode(newNode, i);
                                        break;
                                    }
                                }
                            }
                            Console.Write("还有学生的成绩需要输入吗？（Y/N）");
                            flag = Convert.ToChar(Console.ReadLine());
                        } while (flag == 'Y');
                        break;
                    }

                /*按学号删除学生成绩*/
                case '2':
                    {
                        StuNode temp;
                        Console.Write("请输入要删除的学生的学号：");
                        string stu_no = Console.ReadLine();
                        for(int i = 1; i < stuList.GetLength(); i++)
                        {
                            temp = stuList.SearchNode(i);
                            if (temp.Stu_no == stu_no)
                            {
                                stuList.DeleteNode(i);
                                break;
                            }
                        }
                        break;
                    }
                /*按姓名查询学生成绩*/
                case '3':
                    {
                        StuNode temp;
                        Console.Write("请输入要查询的学生的姓名：");
                        string stu_name = Console.ReadLine();
                        for(int i = 1; i < stuList.GetLength(); i++)
                        {
                            temp = stuList.SearchNode(i);
                            if (temp.Stu_name == stu_name)
                            {
                                Console.WriteLine("姓名为{0}的学生成绩是{1}",stu_name,temp.Stu_score);
                                break;
                            }
                        }
                        break;
                    }
                /*按学号查询学生成绩*/
                case '4':
                    {
                        StuNode temp;
                        Console.Write("请输入要查询的学生的学号：");
                        string stu_no = Console.ReadLine();
                        for(int i = 1; i < stuList.GetLength(); i++)
                        {
                            temp = stuList.SearchNode(i);
                            if(temp.Stu_no == stu_no)
                            {
                                Console.WriteLine("学号为{0}的学生成绩是{1}", stu_no, temp.Stu_score);
                                break;
                            }
                        }
                        break;
                    }
                /*按升序显示所有学生成绩，本来就是升序排列*/
                case '5':
                    {
                        StuNode temp = null;
                        for(int i = 1; i < stuList.GetLength(); i++)
                        {
                            temp = stuList.SearchNode(i);
                            Console.WriteLine("t{0}\t{1}\t{2}",temp.Stu_no,temp.Stu_name,temp.Stu_score);
                        }
                        break;
                    }
                /*按降序显示所有学生成绩*/
                case '6':
                    {
                        StuNode temp = null;
                        for (int i = stuList.GetLength(); i >0; i--)
                        {
                            temp = stuList.SearchNode(i);
                            Console.WriteLine("t{0}\t{1}\t{2}", temp.Stu_no, temp.Stu_name, temp.Stu_score);
                        }
                        break;
                    }
                /*退出程序*/
                case '7':
                    {
                        return;
                    }
            }
            Console.Write("按任意键继续....");
            Console.ReadLine();
        }
    }
}
