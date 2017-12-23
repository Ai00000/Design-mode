using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 责任链模式
{
    class ConcreteHandle1 : Handler
    {
        public override void HandleRequst(int requst)
        {
            if (requst >= MinHandle && requst < MaxHandle)
            {
                Console.WriteLine(Name + "处理了请求！");
                Console.WriteLine("------------------------------");
            }
            //判断是否存在后继者
            else if (successor != null)
            {
                //交给下一个管理者
                Console.WriteLine(Name + "无权处理，交给下一级管理者");
                successor.HandleRequst(requst);

            }
        }
    }
}
