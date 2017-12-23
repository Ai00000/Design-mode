using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    /// <summary>
    /// 公司实体类,枝节点
    /// </summary>
    class ConcreteCompany : ICompany
    {
        public string Name { get; set; }

        public List<ICompany> children = new List<ICompany>();

        public void Add(ICompany company)
        {
            children.Add(company);
        }

        public void DisPlay(int depth)
        {
            Console.WriteLine(new String('-',depth)+Name);

            foreach (ICompany item in children)
            {
                item.DisPlay(depth + 2);
            }
        }

        public void Remove(ICompany company)
        {
            children.Remove(company);  
        }

        public void Work()
        {
            foreach (ICompany item in children)
            {
                item.Work();
            }
        }
    }
}
