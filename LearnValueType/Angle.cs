using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnValueType
{
    /// <summary>
    /// 定义值类型 结构
    /// </summary>
    public struct Angle
    {
        public Angle(int degress,int minutes,int seconds)
        {
            Degress = degress;
            Minutes = minutes;
            Seconds = seconds;
        }
        /// <summary>
        /// default 传递默认值作为实参
        /// </summary>
        /// <param name="degress"></param>
        /// <param name="minutes"></param>
        public Angle(int degress, int minutes) : this(degress, minutes, default(int))
        {

        }
        public int Degress { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Angle Move(int degress, int minutes, int seconds)
        {
            return new Angle(Degress + degress, Minutes + minutes, Seconds + seconds);
        }
    }

    public class State
    {
        enum ConnectionState : short
        {
            Disconnected,
            Connecting=10,
            Connected,
            Joined=Connected,
            Disconnecting,
        }
    }
}
