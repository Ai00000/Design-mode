using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.11.30
         * 
         * 外观模式:为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口。这个接口使得这一子系统更加容易使用。
         * 
         * 1.常用于维护老系统，为老系统定义一个接口来管理其功能
         * 2.使客户端不必知道底层的具体对象实现 
         */
        static void Main(string[] args)
        {
            //创建一个外观对象
            Facade facade = new Facade();
            //调用相应方法
            facade.FunctionA();
            facade.FunctionB();
            facade.FunctionC();
        }
    }
}
