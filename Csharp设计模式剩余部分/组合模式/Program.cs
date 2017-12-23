using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.12.17-18
         * 组合模式：将对象组合成树形结构以表示‘部分-整体’的层次结构。
         * 组合模式使得用户对单个对象和组合对象的使用具有一致性。
         * 
         */
        static void Main(string[] args)
        {
            //1.执行组合模式原型
            //StartExample();
            //执行组合模式实例

            /*2.
             *现在我们写一个连锁公司管理系统
             * 这些公司都使用同一套管理系统，并且根据层级不同选择不同的行为
             */
            StartExample1();
           



        }


       public static void StartExample()
        {
            /*
            * 组合模式原型
            * 
            */
            //定义一个根节点
            Composite root = new Composite() { Name = "root根节点" };
            root.Add(new Leaf() { Name = "root 叶子节点A" });
            root.Add(new Leaf() { Name = "root 叶子节点B" });

            //定义一个枝结点
            Composite composite = new Composite() { Name = "root枝节点A" };
            composite.Add(new Leaf() { Name = "composite 叶子节点A" });
            composite.Add(new Leaf() { Name = "composite 叶子节点B" });

            //定义一个枝结点
            Composite composite1 = new Composite() { Name = "root枝节点B" };
            composite1.Add(new Leaf() { Name = "composite1 叶子节点A" });
            composite1.Add(new Leaf() { Name = "composite1 叶子节点B" });


            //为根节点添加枝结点
            root.Add(composite);
            root.Add(composite1);

            //为根节点添加叶子节点
            root.Add(new Leaf() { Name = "root 叶子节点C" });
            root.Add(new Leaf() { Name = "root 叶子节点D" });

            //显示树形结构
            root.DisPlay(1);
        }
        public static void StartExample1()
        {
            /*
             * 注：这里的CompanyComponent1 2 3表示3种具有不同职责和功能的部门（组件）
             */
            ICompany root = new ConcreteCompany() { Name = "上海总公司" };
            root.Add(new CompanyComponent1() { Name = "总公司人力资源部" });
            root.Add(new CompanyComponent2() { Name = "总公司财务部" });
            root.Add(new CompanyComponent3() { Name = "总公司宣传部" });

            ICompany company = new ConcreteCompany() { Name = "云南分公司" };
            company.Add(new CompanyComponent1() { Name = "云南分公司人力资源部" });
            company.Add(new CompanyComponent2() { Name = "云南分公司财务部" });
            company.Add(new CompanyComponent3() { Name = "云南分公司宣传部" });

            ICompany company1 = new ConcreteCompany() { Name = "祥云支公司" };
            company1.Add(new CompanyComponent1() { Name = "祥云支公司人力资源部" });
            company1.Add(new CompanyComponent2() { Name = "祥云支公司财务部" });
            company1.Add(new CompanyComponent3() { Name = "祥云支公司宣传部" });

            //加入已经没有宣传部了
            ICompany company2 = new ConcreteCompany() { Name = "祥城镇办事处" };
            company2.Add(new CompanyComponent1() { Name = "祥城镇办事处人力资源部" });
            company2.Add(new CompanyComponent2() { Name = "祥城镇办事处财务部" });

            //将各个节点连接起来
            root.Add(company);
            company.Add(company1);
            company1.Add(company2);

            //显示结构图
            root.DisPlay(1);

        }


    }
}
