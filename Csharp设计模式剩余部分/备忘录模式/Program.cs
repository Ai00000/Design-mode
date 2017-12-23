using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 备忘录模式
{
    class Program
    {
        /*
         * 作者：Ai
         * 时间：2017.12.17
         * 备忘录模式：在不破坏封装性的前提下，捕获一个对象的内部状态，
         * 并在该对象之外保存这个状态。这样以后就可以将该对象恢复到原先保存的状态
         */
        static void Main(string[] args)
        {
            /*下面开始模拟制作一个游戏的存档系统*/

            Player player = new Player() { Name = "Ai" };
            //进行初始化
            player.Initialize();
            //显示信息
            Console.WriteLine("玩家基础数据");
            player.ShowInfo();

           
            //存个档
            //这样客户端无需知道存储了那些数据，也不用操作这些数据
            StorageAdmin storageAdmin = new StorageAdmin();//创建一个存档管理器
            storageAdmin.Storagebox= player.Save();//将玩家信息存放在存档管理器中的存档盒子中

            //升级啦
            Console.WriteLine("玩家升级后数据");
            player.UpLevel();

            //显示信息
            player.ShowInfo();

            //读取
            Console.WriteLine("玩家恢复后的数据");
            player.Load(storageAdmin.Storagebox);//从存档管理器的存档盒子中取出存档并恢复

            player.ShowInfo();

        }
    }
}
