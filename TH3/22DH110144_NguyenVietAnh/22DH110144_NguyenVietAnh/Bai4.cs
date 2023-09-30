using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22DH110144_NguyenVietAnh
{
    internal class Bai4
    {
        static void Main()
        {
            for (var i = 0; i < 5; i++)
            {
                var tmp = i;
                Thread t = new Thread(() =>
                {
                    DemoThread("Thread " + tmp);
                });
                t.Start();
            }
        }
        static void DemoThread(string threadIndex)
        {
            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine(threadIndex + " - " + i);
            }
        }
    }
}
