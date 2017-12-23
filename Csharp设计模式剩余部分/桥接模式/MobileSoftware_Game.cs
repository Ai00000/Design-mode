using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式
{
    /// <summary>
    /// 手机软件游戏类
    /// </summary>
    class MobileSoftware_Game : MobileSoftware
    {
        public override void Run()
        {
            Console.WriteLine("运行" + Name + "系统的游戏功能");
        }
    }
}
