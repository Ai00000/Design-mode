using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    /// <summary>
    /// 公司接口
    /// </summary>
    /// 为了和之前的原型区分，我特意写成了接口
    interface ICompany
    {
       
        string Name { get; set; }

        void Add(ICompany company);

        void Remove(ICompany company);

        void DisPlay(int depth);

        //工作
        void Work();
         
    }
}
