using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.11.30
         * 
         * 模板方法：定义一个操作中算法的骨架，而将一些步骤延迟到子类中。
         * 模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤
         * 
         */
        static void Main(string[] args)
        {
            /*
             * 假设我们现在要组装一台简易电脑
             * 且电脑=处理器+显卡+存储+机箱
             */

            //我买了一台Inter电脑
            ComputerBase computer = new ComputerInter();
            computer.Name = "Inter电脑";
            Console.WriteLine(computer.Name);
            Console.WriteLine("--------------------------");
            //进行装配
            computer.Assemble();

            Console.WriteLine();
            Console.WriteLine("========我是分割线=============\n");

            //我买了一台AMD电脑
            computer = new ComputerAmd();
            computer.Name = "AMD电脑";
            Console.WriteLine(computer.Name);
            Console.WriteLine("--------------------------");
            //进行装配
            computer.Assemble();
        }
    }
}
