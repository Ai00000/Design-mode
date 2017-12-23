using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式
{
    /// <summary>
    /// 手机类
    /// </summary>
    abstract class MobilePhone
    {
        public String Name { get; set; }

        /// <summary>
        /// 手机软件引用对象
        /// </summary>
        protected MobileSoftware software;

        public void SetSoftware(MobileSoftware software)
        {
            this.software = software;
        }

        public void Run()
        {
            software.Run();
        }
    }
}
