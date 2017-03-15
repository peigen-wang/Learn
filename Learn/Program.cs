using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Learn
{
    class Program
    {
        public const int Repetition = 1000;
        static void Main(string[] args)
        {
            /*
             测试
             你的名字
             */
            //string Name;
            //Console.WriteLine("HeyYou");
            //Console.Write("输入您的名字：");
            //Name = Console.ReadLine();
            //Console.WriteLine($"您的名字是{Name}哦！");
            Console.WriteLine("开始执行");

            ThreadStart threadStart = DoWork;
            Thread thread = new Thread(threadStart);
            thread.Start();
            for (int i = 0; i < Repetition; i++)
            {
                Console.Write("-");
            }
            thread.Join();


            Console.Read();
        }

        public static void DoWork()
        {
            for(int count = 0; count < Repetition; count++)
            {
                Console.Write("+");
            }
        }

        //表达式主体方法 用lambda表达式=>
        public static string GetFullName() => "王根培";

        //Tuple 元祖类型
        public static Tuple<int, string> GetResult(int args) => new Tuple<int, string>(1, "1");


        public static string Combine(params string[] paths)
        {
            string result = string.Empty;
            foreach (var path in paths)
            {
                result = System.IO.Path.Combine(result, path);
            }
            return result;
        }
    }
}
