using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp设计模式剩余部分
{
    //人类
    abstract class Person
    {
        protected string name;
        public Person(string name)
        {
            this.name = name;
        }

        //开门
        public abstract void OpenTheDoor();
        

        
    }
}
