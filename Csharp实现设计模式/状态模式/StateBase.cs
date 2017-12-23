using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
   abstract class StateBase
    {
        protected Player Player;

        public StateBase(Player player)
        {
            this.Player = player;
        }

        public enum State
        {
            待机,
            移动,
            攻击,
            死亡
        }
       public abstract void EnterState();
        public abstract void UpdateState();
        public abstract void ExitState();
    }
}
