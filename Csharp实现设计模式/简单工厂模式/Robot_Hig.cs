using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
   public class Robot_Hig:Robot
    {
        public override void Say(string s)
        {
            Console.WriteLine("高级机器人说："+s);
        }
        public void SayHigh()
        {
            Console.WriteLine("今天是："+DateTime.Now);
        }
    }
}
