using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    /// <summary>
    /// 叶子结点类，没有子节点
    /// </summary>
    class Leaf : Component
    {
        public override void Add(Component component)
        {
            Console.WriteLine("不能在叶子节点添加子节点");
        }

        public override void DisPlay(int depth)
        {
            Console.WriteLine(new String('-',depth)+Name);
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("不能移除叶子节点");
        }
    }
}
