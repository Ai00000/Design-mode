using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 解释器模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.12.19-20
         * 
         * 解释器模式（interpreter）：
         * 给定一个语言，定义它的文法中的一种表示，
         * 并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
         * 
         * 解释器模式需要解决的是，如果一种特定类型的问题发生的频率足够高，
         * 那么可能就值得将该问题的各个实例表述一个简单语言中的句子。
         * 这样就可以构建一个解释器，该解释器通过解释这些句子来解决该问题。
         * 
         * 注：*正则表达式就是解释器模式的应用之一。
         *      *浏览器解析HTML也是使用了类似解释器模式的东西。
         *      *运用解释器模式可以自己开发编程语言。
         * 
         */
        static void Main(string[] args)
        {
        }
    }
}
