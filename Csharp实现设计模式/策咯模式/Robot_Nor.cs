using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 一般机器人类
    /// </summary>
   public class Robot_Nor:Robot
    {
        public override void Say(string s)
        {
            Console.WriteLine("一般机器人说:"+s);
        }
    }
}
