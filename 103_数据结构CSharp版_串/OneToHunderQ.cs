using System;
using System.Collections;
using System.IO;
using System.Text;

namespace _103_数据结构CSharp版_串
{
    //编写题库列表类
    class OneToHunderQ
    {
        ArrayList questionList = new ArrayList();
        //初始化列表类
        public OneToHunderQ()
        {
            FileStream fs = new FileStream("question.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("gb2312"));
        }
    }
}
