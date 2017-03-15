using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    public partial class Program
    {
        private class CommandLine
        {
            /// <summary>
            /// 嵌套类
            /// </summary>
            /// <param name="arguments"></param>
            public CommandLine(string[] arguments)
            {
                for (int argumentCounter = 0; argumentCounter < arguments.Length; argumentCounter++)
                {
                    switch (argumentCounter)
                    {
                        case 0:
                            Action = arguments[argumentCounter].ToLower();
                            break;
                        case 1:
                            Id = arguments[1];
                            break;
                        case 2:
                            FirstName = arguments[2];
                            break;
                        case 3:
                            LastName = arguments[3];
                            break;
                        default:
                            break;
                    }
                }
            }

            public string Action;
            public string Id;
            public string FirstName;
            public string LastName;
        }

        static void Main(string[] args)
        {
            CommandLine commandLine = new CommandLine(args);
            switch (commandLine.Action)
            {
                case "new":
                    //实例员工的对象
                    break;
                case "update":
                    //更改员工对象的信息
                    break;
                case "delete":
                    //删除这个存在的员工对象
                    break;
                default:
                    Console.WriteLine("Employee.exe " + "new|update|delete <id> [firstName] [lastName]");
                    break;
            }
        }
    }
}
