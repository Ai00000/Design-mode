using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    class CompanyComponent2:ICompany
    {
        public string Name { get; set; }

        public void Add(ICompany company)
        {
            Console.WriteLine("不能添加");
        }

        public void DisPlay(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }

        public void Remove(ICompany company)
        {
            Console.WriteLine("不能删除");
        }

        public void Work()
        {
            Console.WriteLine(Name + "开始工作");
        }
    }
}
