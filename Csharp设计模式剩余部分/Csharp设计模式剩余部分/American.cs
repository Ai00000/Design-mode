using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp设计模式剩余部分
{
    /// <summary>
    /// 美国人类
    /// </summary>
    class American : Person
    {
        
        public American(string name) : base(name)
        {
        }

        /// <summary>
        /// 开门
        /// </summary>
        public override void OpenTheDoor()
        {
            Console.WriteLine("American   "+this.name + "OpenTheDoor");
        }
    }
}
