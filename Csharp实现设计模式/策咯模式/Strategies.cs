using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 策略类
    /// </summary>
    class Strategies
    {
        Robot robot;
        public enum RobotType
        {
            Robot,
            Robot_Nor,
            Robot_Hig
        }
        public Strategies(RobotType type)
        {
            switch (type)
            {
                case RobotType.Robot:
                    robot = new Robot();
                    break;
                case RobotType.Robot_Nor:
                    robot = new Robot();
                    break;
                case RobotType.Robot_Hig:
                    robot = new Robot_Hig();
                    break;
                default:
                    Console.WriteLine("错误");
                    break;
            }
        }
        //添加了行为方法
        public void say(string s)
        {
            this.robot.Say(s);
        }
    }
}
