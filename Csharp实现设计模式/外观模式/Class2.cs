using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Class2
    {
        public void Say()
        {
            Console.WriteLine("执行" + this.ToString() + "的Say方法");
        }
    }
}
