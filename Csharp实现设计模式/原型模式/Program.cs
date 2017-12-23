using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.11.29-30
         * 
         * 原型模式：用原型实例指定创建对象的种类，并且通过拷贝创建新的对象
         * 
         * 1.用于一个对象的构造方法比较复杂或该对象与某对象极为相似时。
         * 2.通过Clone实现的对象，可以不调用构造方法而把一个对象的信息完全复制给另一个对象。
         * 
         * 1.浅表复制：通过实现ICloneable接口，重写Clone方法，调用方法实现克隆（不能复制对象引用）
         * 2.深复制：其实就是在重写Clone方法时，创建一个新的对象，并绑定给克隆的对象（解决了对象引用问题）
         * 
         * 
         */
        static void Main(string[] args)
        {
            //我现在要写一份求职信
            //写基本信息
            Resume resume = new Resume() { Title = "求职信1", Name = "小A", Age = 17 };
            //添加额外信息
            resume.SetInfo(0, "云南开放大学");
            
            //发现之前那个求职信年龄写错了
            //所以重写一份
            //但大部分信息和之前那份一样，所以就抄了一份（根据一个对象Clone一个对象）
            Resume resume1 = resume.Clone()as Resume;
            //改标题
            resume1.Title = "求职信2";  
            //改年龄
            resume1.Age = 18;

            //又抄了一份原版的只是改了标题
            Resume resume2 = resume.Clone() as Resume;
            resume2.Title = "求职信3";

            //分别显示
            resume.Show();
            Console.WriteLine("------------------------------");
            resume1.Show();
            Console.WriteLine("------------------------------");
            resume2.Show();
        }
        
    }
}
