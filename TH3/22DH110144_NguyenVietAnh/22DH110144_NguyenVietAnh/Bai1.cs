using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22DH110144_NguyenVietAnh
{
    internal class Bai1
    {
        static void Main()
        {
            DemoThread();
            DemoThread();
            DemoThread();
        }
        static void DemoThread()
        {
            for(var i = 0; i < 5; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(i);
            }
        }
    }
}
