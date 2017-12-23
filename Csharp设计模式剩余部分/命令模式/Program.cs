using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.12.19
         * 命令模式：
         * 将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化，
         * 对请求排队或记录请求日志，以及支持可撤销的操作。
         * 
         */
        static void Main(string[] args)
        {
            /*下面写一个烧烤店的服务流程*/

            //服务员
            Waiter waiter = new Waiter();
            //厨师
            Chef chef = new Chef();

            //来盘烤牛肉
            waiter.AddOrder(Waiter.Com.Beef);
            waiter.AddOrder(Waiter.Com.Beef);
            waiter.AddOrder(Waiter.Com.Beef);
            //再来盘烤鸡翅
            waiter.AddOrder(Waiter.Com.Chicken);

            //发现点多了，取消一盘牛肉
            waiter.RemoveOrder(Waiter.Com.Beef);

            Console.WriteLine("----------------您的菜单如下------------");
            //服务员让指定的厨师去做 
            waiter.Excute(chef);


        }
    }
}
