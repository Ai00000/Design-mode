using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 给礼物的接口
    /// </summary>
    interface IGiveGift
    {
        /// <summary>
        /// 送鲜花
        /// </summary>
        void GiveFlower();
        /// <summary>
        /// 送巧克力
        /// </summary>
        void GiveChocolate();
    }
}
