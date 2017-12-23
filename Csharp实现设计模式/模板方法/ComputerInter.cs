using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法
{
    class ComputerInter : ComputerBase
    {
        protected override void AddCpu()
        {
            Console.WriteLine("搭载英特尔I7-7700HQ处理器");
        }

        protected override void AddCrate()
        {
            Console.WriteLine("配备蓝色机箱");
        }

        protected override void AddGpu()
        {
            Console.WriteLine("添加GTX-1080Ti显卡");
        }

        protected override void AddMemory()
        {
            Console.WriteLine("16g海盗船内存条");
        }
    }
}
