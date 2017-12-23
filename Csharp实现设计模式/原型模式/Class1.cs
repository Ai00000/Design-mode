using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    /// <summary>
    /// 附加信息类
    /// </summary>
    /// 
    //也要实现ICloneable接口
    class Class1 :ICloneable
    {
       public int Id { get; set; }
        public string Info { get; set; }

        public object Clone()
        {
            //返回当前对象的克隆
            return this.MemberwiseClone() as Class1;
        }
    }
}
