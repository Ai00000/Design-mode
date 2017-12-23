using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式
{
    class Program
    {
        /*
         * 时间：2017.12.18
         * 作者：Ai
         * 单例模式：让时刻只能获取到唯一仅有的一个对象
         */
        static void Main(string[] args)
        {
            //获得实例对象
            World world =World.GetWorld() ;

            world.Name = "美好世界";
            //
            Console.WriteLine("---------对象world----" );
            world.Show();          
            Console.WriteLine("对象名为："+world.ToString());
            //


            //重新获取对象

            World world1 = World.GetWorld();
            Console.WriteLine("---------对象world1----");
            world1.Show();

            Console.WriteLine("对象名为：" + world1.ToString());


            //然后我们发现。输出都一样。而且是同一个对象
        }
    }

    class World
    {
        //给个对象引用
        private static World world;

        //加个测试属性
        public String Name { get; set; }

        

        //私有化构造
        private World() { }

        //提供个接口
        public static World GetWorld()
        {
            if (world==null)
            {
                world = new World();
            }
            return world;
        }

        public void Show()
        {
            Console.WriteLine("我们的世界"+Name);
        }

    }
}
