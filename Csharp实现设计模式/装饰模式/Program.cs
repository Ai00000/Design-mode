using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.11.29
         * 
         * 装饰模式：动态的给一个对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更加灵活
         * 装饰模式就是在不改变基础功能的条2件下动态的添加功能
         * 优点：
         *  装饰模式和继承的目的都是扩展对象的功能，但装饰者模式比继承更灵活
         *  通过使用不同的具体装饰类以及这些类的排列组合，设计师可以创造出很多不同行为的组合
         *  装饰者模式有很好地可扩展性
         * 缺点：装饰者模式会导致设计中出现许多小对象，如果过度使用，会让程序变的更复杂。并且更多的对象会使得查错变得困难，特别是这些对象看上去都很像。
         * 
         */
        static void Main(string[] args)
        {
            /*
             * 通过调试可以看出，每次装饰都是在原来的基础上进行扩展
             */

            //我买了一个苹果手机
            Phone phone = new ApplePhone();

            phone.Show();
            Console.WriteLine("---------------------------------------------------------");
            //我想给手机加个外壳
            Decorator decorator = new PhoneShell(phone);
            //扩展外壳方法
            decorator.Show();
            Console.WriteLine("---------------------------------------------------------");

            //我想给手机加个挂饰
            Decorator decorator1 = new PhoneAccessories(phone);

            //扩展挂饰方法
            decorator1.Show();
            


        }
    }
}
