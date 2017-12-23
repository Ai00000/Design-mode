using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.11.30
         * 状态模式：允许一个对象在其内部状态改变时自动改变其行为，对象看起来就像是改变了它的类。
         */
        static void Main(string[] args)
        {
            /*
             * 1.这里我就以我在写游戏时遇到的一个具体问题来描述状态模式。
             * 2.我在写某游戏时，我需要在玩家状态改变时发生变化
             * 3.例如，在玩家进入攻击状态时，改变玩家单位模型的动画为攻击，在退出时收刀
             * 4.在进入移动时播放跑步动画，在退出时播放退出动画等。。。
             */

            //初始化一个玩家
            Player player = new Player() { Name = "小行星",currState=StateBase.State.待机 };

            //更新状态
            player.state = StateBase.State.攻击;

            //执行对应方法
            player.Execute();


        }
    }
}
