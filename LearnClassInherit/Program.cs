using LearnClassInherit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassInherit
{
    /// <summary>
    /// 继承类学习
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            //Contact contact = new Contact("");
            //contact.Name = "培根";

            ////隐式转换
            //PdaItem item = contact;

            ////显示转换
            //contact = (Contact)item;


            #region 多态性
            PdaItem[] pda = new PdaItem[3];

            Contact contact = new Contact("培根");
            contact.Address = "九洲芳园";
            pda[0] = contact;


            #endregion

        }

        public static void Save(object data)
        {
            if(data is string)
            {
                //data = Encrypt((string)data);
            }
        }
    }
}
