using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    /// <summary>
    /// 服务员类
    /// </summary>
    class Waiter
    {
        public enum Com
        {
            Beef,
            Chicken
        }

        //记录
        List<Command> orders = new List<Command>();

        //添加
        public void AddOrder(Com command)
        {
            switch (command)
            {
                case Com.Beef:
                    orders.Add(new Command_Beef() { Name="烤牛肉"});
                    break;
                case Com.Chicken:
                    orders.Add(new Command_Chicken() {Name="烤鸡翅" });
                    break;
                default:
                    break;
            }
            Console.WriteLine("你下单了"+command+"   时间为："+DateTime.Now);

        }
        //撤销
        //这里我使用了Linq来查询List
        public void RemoveOrder(Com com)
        {
            List<Command> list;       
            switch (com)
            {
                case Com.Beef:
                    list = (from q in orders where q.Name == "烤牛肉" select q).ToList<Command>();
                    break;
                case Com.Chicken:
                    list = (from q in orders where q.Name == "烤鸡翅" select q).ToList<Command>();
                    break;
                default:
                    list = null;
                    break;
            }
            orders.Remove(list[0]);
            Console.WriteLine("你取消了" + com + "   时间为：" + DateTime.Now);
        }
        //执行
        public void Excute(Chef chef)
        {
            foreach (var item in orders)
            {
                item.chef = chef;
                item.Excute();
            }
        }
    }
}
