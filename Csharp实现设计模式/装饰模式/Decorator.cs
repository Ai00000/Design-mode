using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    /// <summary>
    /// 装饰类，因为要完全实现取代抽象组件，所以必须继承于Phone
    /// </summary>
   abstract class Decorator : Phone
   {
        //提供一个手机对象（装饰对象）
        private Phone phone;

        public Decorator(Phone phone)
        {
            this.phone = phone;
        }

        //其实调用的是装饰对象的方法
        public override void Show()
        {
            if (this.phone!=null)
            {
                phone.Show();
            }
        }
   }
}
