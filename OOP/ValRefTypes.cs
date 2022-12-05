using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public struct EvilStruct
    {
        public int X;
        public int Y;

        public PointRef PointRef { get; internal set; }
    }
    public struct PointVal
    {
        public int X;
        public int Y;

        public void LogValues()
        {
          Console.WriteLine($"X={X}; Y={Y}");   
        }
    }

    public class PointRef
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X={X}; Y={Y}");
        }
    }
}
