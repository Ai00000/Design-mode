using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    /// <summary>
    /// 简历类
    /// </summary>
    class Resume : ICloneable
    {
       public string Name { get; set; }

       public string Title { get; set; }

       public int Age { get; set; }

        //对象引用（浅表复制无法克隆，或者说克隆的只是该对象的引用地址）
        private Class1 class1;


        public Resume()
        {
            class1 = new Class1();
        }

        /// <summary>
        /// 私有构造，内部克隆
        /// </summary>
        /// <param name="class1"></param>
        private Resume(Class1 class1)
        {

            this.class1 = class1.Clone() as Class1;
        }
        /// <summary>
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //克隆
            // return (object)this.MemberwiseClone();

            //创建一个新对象，并手动设置属性
            Resume resume = new Resume(this.class1);
            resume.Age = this.Age;
            resume.Title = this.Title;
            resume.Name = this.Name;

            return resume;

        }


        /// <summary>
        /// 显示
        /// </summary>
        public void Show()
        {
            Console.WriteLine("标题：{0}  姓名：{1} 年龄{2}",Title,Name,Age);
            Console.WriteLine("id:{0}  info{1}",class1.Id,class1.Info);
        }
        /// <summary>
        /// 设置额外信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="info"></param>
        public void SetInfo(int id,string info)
        {
            class1.Id = id;
            class1.Info = info;
        }
    }
}
