using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 代理类，就是帮人送礼物的人咯
    /// </summary>
    class Proxy : IGiveGift
    {
        /// <summary>
        /// 委托者
        /// </summary>
       public pursuer pursuer { get; set; }

        public void GiveChocolate()
        {
            //调用追求者的方法
            pursuer.GiveChocolate();
        }

        public void GiveFlower()
        {
            //调用追求者的方法
            pursuer.GiveFlower();
        }
    }
}
