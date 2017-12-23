using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 责任链模式
{
    /// <summary>
    /// 管理者类
    /// </summary>
    abstract class Handler
    {
        public string Name { get; set; }
        public int MinHandle { get; set; }
        public  int MaxHandle { get; set; }
        /// <summary>
        /// 继承者
        /// </summary>
        protected Handler successor;

        /// <summary>
        /// 设置继承者
        /// </summary>
        /// <param name="handler">继承者</param>
        public void SetSuccessor(Handler handler)
        {
            successor = handler;
        }

        /// <summary>
        /// 处理请求
        /// </summary>
        /// <param name="requst">请求的级别</param>
        public abstract void HandleRequst(int requst);
        
    }
}
