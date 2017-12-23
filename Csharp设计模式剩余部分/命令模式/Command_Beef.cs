using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 牛肉命令类
    /// </summary>
    class Command_Beef : Command
    {
        public override void Excute()
        {
            chef.Beef();
        }
    }
}
