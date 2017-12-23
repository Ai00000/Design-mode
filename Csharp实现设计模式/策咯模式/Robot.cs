using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 机器人类 
    /// </summary>
   public class Robot
    {
    
        public  virtual void Say(string s)
        {
       
            Console.WriteLine("机器人说："+s);
        }
    }
}
