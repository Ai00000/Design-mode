using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 命令抽象类
    /// </summary>
     abstract class Command
    {
        public String Name { get; set; }
        public Chef chef;
        public abstract void Excute();
    }
}
