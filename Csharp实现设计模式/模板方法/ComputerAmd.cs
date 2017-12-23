using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法
{
    class ComputerAmd : ComputerBase
    {
        protected override void AddCpu()
        {
            Console.WriteLine("搭载AMD高性能处理器");
        }

        protected override void AddCrate()
        {
            Console.WriteLine("配合黑色机箱");
        }

        protected override void AddGpu()
        {
            Console.WriteLine("搭配AMD R9-270蓝宝石独立显卡");
        }

        protected override void AddMemory()
        {
            Console.WriteLine("海力士16g内存");
        }
    }
}
