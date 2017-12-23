using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.11.27
         * 
         * 实现工厂模式要点：
         * 1.通过一个工厂类来创建相应（实例化）的对象
         * 2.需要在工厂内部提供一个所需实例化的基类的对象
         * 3.通过工厂控制对象的创建
         * 
         * 工厂模式使用情景：
         * 1.需要解耦合时
         * 2.需要对对象的生成进行统一管理和控制时
         * 3.需要动态生成对象时
         * 
         * 涉及知识点：封装，继承，多态
         */
        static void Main(string[] args)
        {
            //创建一个工厂用于创建实例
            Factory factory = new Factory();
            //通过工厂来创建实例
            //通过as来实现类型的强转转换
            Robot robot= factory.GetRobot(Factory.RobotType.Robot);            
            Robot_Nor robot_Nor = factory.GetRobot(Factory.RobotType.Robot_Nor)as Robot_Nor;
            Robot_Hig robot_Hig = factory.GetRobot(Factory.RobotType.Robot_Hig) as Robot_Hig;
            //调用这些实例的方法
            robot.Say("Hi");
            robot_Nor.Say("你好");
            robot_Hig.Say("你好呀，你在干什么呢~");
            //非父类（Robot）类中的方法也能够调用
            robot_Hig.SayHigh();

        }
    }
    
}
