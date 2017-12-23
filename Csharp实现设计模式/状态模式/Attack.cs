using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class Attack : StateBase
    {
        public Attack(Player player) : base(player)
        {
        }

        public override void EnterState()
        {
            Console.WriteLine("进入攻击状态");
        }

        public override void ExitState()
        {
            Console.WriteLine("退出攻击状态");
        }

        public override void UpdateState()
        {
            Player.Attack();
            Console.WriteLine("更新待机状态");
        }
    }
}
