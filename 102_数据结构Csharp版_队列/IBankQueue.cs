﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_数据结构Csharp版_队列
{
    interface IBankQueue:IQueue<int>
    {
        int GetCallnumber();                //获得服务号码
    }
}
