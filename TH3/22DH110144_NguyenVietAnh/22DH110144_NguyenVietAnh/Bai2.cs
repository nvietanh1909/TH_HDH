using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22DH110144_NguyenVietAnh
{
    internal class Bai2
    {
        static void Main()
        {
            Thread t = new Thread(() => {DemoThread("Thread 1"); });
            t.Start();
            Thread t2 = new Thread(() => {DemoThread("Thread 2"); });
            t2.Start();
            Thread t3 = new Thread(() => {DemoThread("Thread 3"); });
            t3.Start();
        }
        static void DemoThread(string threadIndex)
        {
            for(var i = 0; i < 5; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(threadIndex + " - " + i);
            }
        }
    }
}
