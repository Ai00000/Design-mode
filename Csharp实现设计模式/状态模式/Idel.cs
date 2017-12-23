using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class Idel : StateBase
    {
        public Idel(Player player) : base(player)
        {
            
        }

        public override void EnterState()
        {
            Console.WriteLine("进入待机状态");
        }

        public override void ExitState()
        {
            Console.WriteLine("退出待机状态");
        }

        public override void UpdateState()
        {
            Player.Idel();
            Console.WriteLine("更新待机状态");
        }
    }
}
