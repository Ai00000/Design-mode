using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp设计模式剩余部分
{
    /*
     * 作者：Ai
     * 时间：2017.12.16
     * 
     * 适配器模式
     * 适配器模式：将一个类的接口转化为客户希望的另一个接口，
     * 适配器模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作
     * 使用场景：
     * 系统的数据和行为都正确，但接口不符时我们应该使用适配器
     * 目的是是，接口控制范围之外的一个原有对象与某个接口匹配，
     * 
     * 注意：适配器模式属于亡羊补牢的方法，大多是在后期进行维护中使用的。
     * 不过也可以在使用第三方库时用于统一接口。
     * 
     * 好处：
     * 可以使客户端调用统一的接口
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 举个例子：英国人，美国人，中国人一起到法国旅行
             * 他们劳累了一天了，到一家酒店准备住下
             * 服务员分别给他们发了钥匙然后告诉他们房间在哪
             * 然而中国人并听不懂英语
             */

            //创建一个美国人Alice，并开门
            new American("Alice").OpenTheDoor();
            //创建一个英国人Borl，并开门
            new British("Borl").OpenTheDoor();
            //创建一个翻译，然后让翻译告诉中国人小民房间在哪，然后开门
            new Translator("小民").OpenTheDoor();


            //因为小民只懂中文，所以他只知道这样开门
            new Chinese() { Name = "小民" }.开门();

            //翻译的作用就是统一了接口，就是不论是谁来住店，服务员都可以讲同样的英文（不必学习其他语言）
            //而由翻译来指挥顾客
        }
    }
}
