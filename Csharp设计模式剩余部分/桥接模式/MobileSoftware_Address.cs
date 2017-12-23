using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式
{
    /// <summary>
    /// 手机软件通讯录类
    /// </summary>
    class MobileSoftware_Address : MobileSoftware
    {
        public override void Run()
        {
            Console.WriteLine("运行"+Name+"系统的通讯录功能");
        }
    }
}
