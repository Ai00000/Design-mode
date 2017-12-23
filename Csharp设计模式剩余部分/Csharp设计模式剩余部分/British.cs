using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp设计模式剩余部分
{
    /// <summary>
    /// 英国人类
    /// </summary>
    class British : Person
    {
        public British(string name) : base(name)
        {
        }

        /// <summary>
        /// 开门
        /// </summary>
        public override void OpenTheDoor()
        {
            Console.WriteLine("British---"+this.name+"-OpenTheDoor");
        }
    }
}
