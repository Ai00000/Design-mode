using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// 手机壳类，装饰者类
    /// </summary>
    class PhoneShell : Decorator
    {
        public PhoneShell(Phone phone) : base(phone)
        {

        }

        public override void Show()
        {
            base.Show();
            //添加新的行为
            addShell();

        }
        public void addShell()
        {
            Console.WriteLine("现在手机有漂亮的手机壳了");
        }
    }
}
