using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_list_线性表_
{
    class SeqListApp
    {
        private static void Main()
        {
            ILinearList<StuNode> stuList = null;
            Console.WriteLine("请使用存储结构的类型：1.顺序表  2.单链表  3.双链表  4.循环链表");
            char seleFlag = Convert.ToChar(Console.ReadLine());
            switch (seleFlag)
            {
                //初始化线性表
                case '1':
                    Console.WriteLine("请输入学生数");
                    int maxsize = Convert.ToInt32(Console.ReadLine());
                    stuList = new SeqList<StuNode>(maxsize);
                    break;
            }
        }

    }
    class StuNode
    {
        private string stu_no;
        private string stu_name;
        private int stu_score;
        public string stu_No
        {
            get
            {
                return stu_no;
            }
            set
            {
                stu_no = value;
            }
        }
        public string stu_Name
        {
            get
            {
                return stu_name;
            }
            set
            {
                stu_name = value;
            }
        }
        public int stu_Score
        {
            get
            {
                return stu_score;
            }
            set
            {
                stu_score = value;
            }
        }

        public StuNode(string no,string name,int score)
        {
            this.stu_no = no;
            this.stu_name = name;
            this.stu_score = score;
        }

        public override string ToString()
        {
            return stu_no + stu_name;
        }
    }
}
