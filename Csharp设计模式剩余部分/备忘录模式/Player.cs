using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    class Player
    {
        public string Name { get; set; }
        public int Level { get; private set; }
        public int Hp { get; private set; }
        public int Attack { get; private set; }

        /// <summary>
        /// c初始化
        /// </summary>
        public void Initialize()
        {
            this.Level = 1;
            this.Hp = 100;
            this.Attack = 10;
        }
        /// <summary>
        /// 显示状态信息
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("-------角色当前状态信息-----");
            Console.WriteLine("玩家名："+this.Name);
            Console.WriteLine("当前等级："+this.Level);
            Console.WriteLine("攻击力："+this.Attack);
            Console.WriteLine("生命值："+this.Hp);
            Console.WriteLine();
        }

        /// <summary>
        /// 升级
        /// </summary>
        public void UpLevel()
        {
            this.Level++;
            this.Attack += 2;
            this.Hp += 10;
        }


        /// <summary>
        /// 存储
        /// </summary>
        /// <returns>存储盒子</returns>
        public StorageBox Save()
        {
            
            return (new StorageBox() { Name = this.Name,Attack=this.Attack,Level=this.Attack,Hp=this.Attack });
        }

        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="storageBox">存储盒子</param>
        public void Load(StorageBox storageBox)
        {
            this.Name = storageBox.Name;
            this.Level = storageBox.Level;
            this.Attack = storageBox.Attack;
            this.Hp = storageBox.Hp;

        }
    }
}
