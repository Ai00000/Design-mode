using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 责任链模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.12.19
         * 
         * 责任链模式：
         * 使多个对象都有机会处理请求，从而避免请求的发生者和接受者之间的耦合关系
         * 将这个对象连成一条链，并沿着这条链传递该请求，
         * 直到有一个对象处理他为止.
         * 
         * 责任链模式：解除了请求者和处理者之间，处理者和处理者之前的耦合，
         * 使他们不用了解具体是谁处理了请求。
         * 
         * 
         */

            /// <summary>
            /// 请求类型
            /// </summary>
        enum RequestType
        {
            请假=3,
            加薪=16,
            辞职=22
        }
        static void Main(string[] args)
        {
            

            /*创建管理者对象，并赋予他们权限级别(范围)*/
            Handler handler = new ConcreteHandle() { Name = "主管", MinHandle = 0, MaxHandle = 10 };
            
            Handler handler1 = new ConcreteHandle1() { Name = "部门经理", MinHandle = 10, MaxHandle = 20 };
            
            Handler handler2 = new ConcreteHandle2() { Name = "总经理", MinHandle = 20, MaxHandle = 30 };

            /*设置请求递交的管理级别*/
            handler.SetSuccessor(handler1);
            handler1.SetSuccessor(handler2);

            //1.通过数字请求(更灵活)
            //递交的请求集合
            int[] requst = { 0, 3, 10, 15, 18, 22, 28, 33 };
            //处理请求
            for (int i = 0; i < requst.Length; i++)
            {
                //handler.HandleRequst(requst[i]);
            }

            //2.枚举请求(更规范，直观)
            handler.HandleRequst((int)RequestType.请假);
            handler.HandleRequst((int)RequestType.加薪);
            handler.HandleRequst((int)RequestType.辞职);

        }
    }
}
