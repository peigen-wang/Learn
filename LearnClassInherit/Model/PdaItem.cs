using System;

namespace LearnClassInherit.Model
{
    /// <summary>
    /// 所有的类都是从object派生  
    /// abstract抽象类 不需要实例化
    /// </summary>
    public abstract class PdaItem:object
    {
        public PdaItem(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public DateTime LastUpdateId { get; set; }
        protected Guid ObjectKey { get; set; }

        //virtual 提供重写属性
        public virtual string CreateId { get; set; }
        /// <summary>
        /// 抽象成员
        /// </summary>
        /// <returns></returns>
        public abstract string GetSummary();
        
    }
}
