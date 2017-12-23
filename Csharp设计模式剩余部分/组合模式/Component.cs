using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    /// <summary>
    /// 组件类（枝类）
    /// </summary>
    abstract class Component
    {
        public string Name { get; set; }

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public abstract void DisPlay(int depth);

    }
}
