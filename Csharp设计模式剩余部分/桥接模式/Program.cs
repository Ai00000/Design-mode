using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.12.19
         * 桥接模式：将抽象部分与它的实现部分分离，使他们都可以独立的变化.
         * 
         * 就如同我下面的例子我把手机和手机软件分离开，
         * 使手机的品牌和手机软件的类型的增加不互相影响，
         * 通过在手机类下的【软件对象引用】和提供的一个SetSoftware的【接口】
         * 在手机类和手机软件类之间建立一座【桥梁】,这就是【桥接模式】
         * 
         * 注：将抽象部分与它的实现部分分离，可以理解为：
         * 实现系统有多角度分类，每一种分类都有可能变化，
         * 那么就ba这种多角度分离出来让他们独立变化，
         * 减少他们之间的耦合。
         */
        static void Main(string[] args)
        {
            //我有一个三星手机
            MobilePhone phone = new MobilePhone_A() { Name = "三星" };
            phone.SetSoftware(new MobileSoftware_Game() { Name = "Android" });
            phone.Run();

            //我有一个苹果手机
            MobilePhone phone1 = new MobilePhone_B() { Name = "苹果" };
            phone1.SetSoftware(new MobileSoftware_Game() { Name = "IOS" });
            phone1.Run();

            phone1.SetSoftware(new MobileSoftware_Address() { Name = "IOS" });
            phone1.Run();
        }
    }
}
