using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    /// <summary>
    /// 枝节点类，用来存储子部件
    /// </summary>
    class Composite:Component
    {
        /// <summary>
        /// 子部件集合
        /// </summary>
        List<Component> children = new List<Component>();

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void DisPlay(int depth)
        {
            Console.WriteLine(new String('-',depth)+Name);
            foreach (Component item in children)
            {
                item.DisPlay(depth+2);
            }
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}
