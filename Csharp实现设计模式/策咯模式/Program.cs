using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.11.27
         * 
         * ps:策略方法讲求的是对策略层的控制和封装，简单工厂模式讲求的是对对象的管理（笑,感觉没差太多）
         * 
         * 策咯模式是一种定义了一系列算法的方法
         * 完成相同工作但实现不同
         * 用于封装业务规则，变化的可能性
         * 便于进行单元检测（设计模式的解耦合都方便单元测试）
         */
        static void Main(string[] args)
        {
            //策略方法封装了具体的策略
            //策略方法把判断放在了策略层去处理
            //策略模式时用户无需了解策略层的结构（就好像这里用户都不知道其实内部实例化的是什么对象）
            new Strategies(Strategies.RobotType.Robot_Hig).say("策略方法");
       
        }
    }
}
