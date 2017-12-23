using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp设计模式剩余部分
{
    /// <summary>
    /// 中国人类
    /// </summary>
    class Chinese 
    {
       public string Name { get; set; }

        /// <summary>
        /// 开门
        /// </summary>
        public void 开门()
        {
            Console.WriteLine("中国人"+this.Name+"开门");
        }
    }
}
