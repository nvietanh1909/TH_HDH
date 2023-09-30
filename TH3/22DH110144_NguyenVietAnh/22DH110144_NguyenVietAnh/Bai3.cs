using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22DH110144_NguyenVietAnh
{
    internal class Bai3
    {
        static void Main()
        {
            Thread t = new Thread(() =>
            {
                DemoThread("Thread 1");
            });
            t.Start();
            Thread t2 = new Thread(() =>
            {
                DemoThread("Thread 2");
            });
            t2.Start();
            Thread t3 = new Thread(() =>
            {
                DemoThread("Thread 3");
            });
            t3.Start();
        } 
        static void DemoThread(string threadIndex)
        {
            for(var i = 0; i < 100; i++)
            {
                Console.WriteLine(threadIndex + " - " + i);
            }
        }
    }
}
