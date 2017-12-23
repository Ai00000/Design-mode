using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猫抓老鼠观察者模式
{
    /*
     * 作者：Ai
     * 时间：2017.11.27
     * 
     * 观察者模式要点：
     * 1.需要在被观察对象中声明一个事件
     * 2.将该事件绑定到观察者的响应方法上
     * 3.当被观察者事件（）时会自动调用观察者的响应方法
     * 
     * 观察者模式使用情景：
     * 1.需要对一个对象进行持续监听时
     * 2.需要在一个对象状态改变时改变另外一些对象的状态时
     * 
     * 涉及知识点：事件，委托，Action（.net内置无参无返回值委托）
     */
    class Program
    {
        static void Main(string[] args)
        {
            //创建被观察者对象
            Cat cat = new Cat("大猫", "黄色");
            //创建观察者对象，并指定被观察者对象
            Mouse mouse1 = new Mouse("老鼠1", "蓝色",cat);
            Mouse mouse2 = new Mouse("老鼠2", "红色", cat);
            Mouse mouse3 = new Mouse("老鼠3", "红色", cat);
            //改变被观察者的对象
            cat.CatComing(1);            
        }
    }
    class Cat
    {
        string name;
        string color;

        //定义一个事件，用于封装观察者对象的状态响应方法
        public event Action CatCom;
        public Cat(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
        public void CatComing(int a)
        {
            Console.WriteLine("{0}，{1}来了，喵喵喵~~",color,name);
            //调用
            CatCom();
        }
    }
    class Mouse
    {
        string name;
        string color;

        public Mouse(string name,string color,Cat cat)
        {

            this.name = name;
            this.color = color;
            //将事件绑定到方法
            cat.CatCom += this.MouseRun;
        }
        public void MouseRun()
        {
            Console.WriteLine("{0},{1}快跑!!",color,name);
        }

    }
}
