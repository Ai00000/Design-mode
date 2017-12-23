using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    /// <summary>
    /// 外观类
    /// </summary>
    class Facade
    {
        //外观类需要知道所有模块类,但外部并不需要知道这些对象
        private Class1 class1;
        private Class2 class2;
        private Class3 class3;

        public Facade()
        {
            //初始化
            class1 = new Class1();
            class2 = new Class2();
            class3 = new Class3();
        }
        
        public void FunctionA()
        {
            Console.WriteLine("调用方法A");
            class1.Say();
            class2.Say();
            class3.Say();
        }
        public void FunctionB()
        {
            Console.WriteLine("调用方法B");
            class3.Say();
            class2.Say();
            class3.Say();
        }
        public void FunctionC()
        {
            Console.WriteLine("调用方法B");
            class2.Say();
            class1.Say();
        }
    }
}
