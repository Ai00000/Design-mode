using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class Walk : StateBase
    {
        public Walk(Player player) : base(player)
        {
        }

        public override void EnterState()
        {
            Console.WriteLine("进入移动状态");
        }

        public override void ExitState()
        {
            Console.WriteLine("退出移动状态");
        }

        public override void UpdateState()
        {
            Player.Walk();
            Console.WriteLine("更新移动状态");
        }
    }
}
