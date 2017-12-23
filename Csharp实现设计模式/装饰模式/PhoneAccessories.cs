using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// 手机挂件，装饰者类
    /// </summary>
    class PhoneAccessories : Decorator
    {
        public PhoneAccessories(Phone phone) : base(phone)
        {
        }
        
        public override void Show()
        {
            base.Show();
            //添加新行为
            addAccessories();
        }

        public void addAccessories()
        {
            Console.WriteLine("现在手机有可爱的挂饰了");
        }
    }
}
