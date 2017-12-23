using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    /// <summary>
    /// 玩家类
    /// </summary>
    class Player
    {
        public string Name { get; set; }
        //当前状态
        public StateBase.State currState { get; set; }
        //将来状态
        public StateBase.State state { get; set; }

        StateBase state1;
        //玩家行为

        public void Idel()
        {
            Console.WriteLine("待机");
        }
        public void Attack()
        {
            Console.WriteLine("攻击");
        }
        public void Walk()
        {
            Console.WriteLine("移动");
        }
        
        /// <summary>
        /// 获得状态类型
        /// </summary>
        /// <returns></returns>
        public void GetState(StateBase.State state2)
        {
            
            switch (state2)
            {
                case StateBase.State.待机:
                    state1 = new Idel(this);
                    break;
                case StateBase.State.移动:
                    state1 = new Walk(this);
                    break;
                case StateBase.State.攻击:
                    state1 = new Attack(this);
                    break;
                case StateBase.State.死亡:
                    //同上，不写了
                    break;
                default:
                    state1 = null;
                    break;
            }
            
        }
        public void Execute()
        {
            this.GetState(currState);
            if (currState!=state)
            {
                              
                //退出
                state1.ExitState();
                //进入
                this.GetState(state);
                state1.EnterState();
                //同步
                this.currState = state;
               
             
            }
            else
            {
                state1.UpdateState();
            }
        }
    }
}
