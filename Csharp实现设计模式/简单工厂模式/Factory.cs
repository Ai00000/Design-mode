using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    /// <summary>
    /// 工厂类，用于生成对象
    /// </summary>
    class Factory
    {
        //提供一个实例对象
        Robot robot=null;
        //枚举来增强代码的可读性，并用于选择实例化的类型
        public enum RobotType
        {
            Robot,
            Robot_Nor,
            Robot_Hig
        }
        
        /// <summary>
        /// 获得一个实例
        /// </summary>
        /// <param name="robot">所需创建的实例类型</param>
        /// <returns>对应实例</returns>
        public Robot GetRobot(RobotType robot)
        {
            //通过Swit判断要实例化的类型
            switch (robot)
            {
                case RobotType.Robot:
                    this.robot = new Robot();
                    break;
                case RobotType.Robot_Nor:
                    this.robot = new Robot_Nor();
                    break;
                case RobotType.Robot_Hig:
                    this.robot = new Robot_Hig();
                    break;
                default:
                    //处理异常情况
                    Console.WriteLine("参数错误，无法创建对象");
                    break;
            }
            //返回实例
            return this.robot;
        }
    }
}
