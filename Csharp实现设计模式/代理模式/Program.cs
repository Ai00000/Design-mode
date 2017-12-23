using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.11.29
         * 代理模式
         * 
         * 代理模式能够将调用用于真正被调用的对象隔离，在一定程度上降低了系统的耦合度；
         * 代理对象在客户端和目标对象之间起到一个中介的作用，这样可以起到对目标对象的保护。代理对象可以在对目标对象发出请求之前进行一个额外的操作，例如权限检查等。
         */
        static void Main(string[] args)
        {
            //有一个女孩（被追求者）
            Girl girl = new Girl();

            //这个女孩的名字
            girl.name = "小红";

            //有一个喜欢小红但不敢说的人（追求者）0

            pursuer pursuer = new pursuer();

            //于是找来一个开朗大方的人（代理者）
            Proxy proxy = new Proxy();

            //追求者告诉代理者他要追的女生
            pursuer.girl = girl;

            //代理者被那个追求者委托
            proxy.pursuer = pursuer;

            //代理者开始送礼物（礼物是追求者的哦）
            proxy.GiveFlower();
            proxy.GiveChocolate();

        }
    }
}
