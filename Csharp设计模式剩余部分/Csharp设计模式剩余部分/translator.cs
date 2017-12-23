using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp设计模式剩余部分
{
    /// <summary>
    /// 翻译者类
    /// </summary>
    class Translator:Person
    {
        //需要翻译的对象
        Chinese chinese = new Chinese();

        public Translator(string name) : base(name)
        {
            chinese.Name = name;
        }

        /// <summary>
        /// 翻译者开门方法
        /// </summary>
        public override void OpenTheDoor()
        {
            //调用中国人能听懂的方法
            chinese.开门();
        }
    }
}
