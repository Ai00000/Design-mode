using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式
{
    /// <summary>
    /// 手机软件抽象类
    /// </summary>
    abstract class MobileSoftware
    {
        public string Name { get; set; }
        public abstract void Run();
    }
}
