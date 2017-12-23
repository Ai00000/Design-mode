using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 鸡翅命令类
    /// </summary>
    class Command_Chicken : Command
    {
        public override void Excute()
        {
            chef.Chicken();
        }
    }
}
