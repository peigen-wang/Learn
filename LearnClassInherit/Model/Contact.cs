using System;
using System.IO;

namespace LearnClassInherit.Model
{
    /// <summary>
    /// 单继承基类 多继承接口
    /// </summary>
    public class Contact:PdaItem,IPerson
    {
        public Contact(string name) : base(name)
        {
            Name = name;
        }

        //聚合解决单继承
        private Person PersonOne { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        void Save()
        {
            FileStream fs = System.IO.File.OpenWrite(ObjectKey + "dat");
        }

        void Load(PdaItem padItem)
        {
            Contact contact = padItem as Contact;
            if (contact != null)
            {
                contact.ObjectKey = new System.Guid();
            }
        }

        public override string CreateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string GetSummary()
        {
            return $"FirstName:{FirstName}"
                + $"LastName:{LastName}"
                + $"Address:{Address}"
;        }
    }

    public class A
    {
        public virtual void Method() { }
    }

    public class B : A
    {
        public sealed override void Method()
        {
            
        }
    }

    public class C : B
    {
        
    }
}
