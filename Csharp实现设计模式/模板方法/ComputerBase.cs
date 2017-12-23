using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法
{
    /// <summary>
    /// 抽象电脑基类
    /// </summary>
   abstract class ComputerBase
    {
        public string Name { get; set; }

        /// <summary>
        /// 装配方法，提供一个固定的算法顺序
        /// </summary>
        public void Assemble()
        {
            this.AddCpu();
            this.AddCrate();
            this.AddGpu();
            this.AddMemory();
        }

        /// <summary>
        /// 添加CPU
        /// </summary>
        protected abstract void AddCpu();

        /// <summary>
        /// 添加GPU显卡
        /// </summary>
        protected abstract void AddGpu();

        /// <summary>
        /// 添加存储
        /// </summary>
        protected abstract void AddMemory();

        /// <summary>
        /// 添加机箱
        /// </summary>
        protected abstract void AddCrate();


    }
}
