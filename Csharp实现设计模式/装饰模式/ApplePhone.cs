using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// 苹果手机类
    /// </summary>
    class ApplePhone : Phone
    {
        public override void Show()
        {
            Console.WriteLine("这里是苹果手机");
        }
    }
}
