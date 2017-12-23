using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 追求者
    /// </summary>
    class pursuer : IGiveGift
    {

        /// <summary>
        /// 要送礼物的人
        /// </summary>
        public Girl girl { get; set; }
        public void GiveChocolate()
        {
            Console.WriteLine(girl.name + "送你巧克力"); 
        }

        public void GiveFlower()
        {
            Console.WriteLine(girl.name + "送你鲜花");
        }
    }
}
