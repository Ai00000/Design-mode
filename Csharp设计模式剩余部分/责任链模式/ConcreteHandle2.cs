using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 责任链模式
{
    class ConcreteHandle2 : Handler
    {
        public override void HandleRequst(int requst)
        {
            if (requst >= MinHandle && requst < MaxHandle)
            {
                Console.WriteLine(Name + "处理了请求！");
                Console.WriteLine("------------------------------");
            }
            else
            {
                //交给下一个管理者
                Console.WriteLine("请求错误，无法处理");
                
            }
        }
    }
}
