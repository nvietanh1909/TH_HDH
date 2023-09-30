using System;
using System.Threading;
namespace _22DH110144_NguyenVietAnh;
class Program
{
    static void Main()
    {
       for(var i = 1; i <= 5; i++)
        {
            var tmp = i;
            Thread t = new Thread(() =>
            {
                DemoThread("Thread" + tmp);
            });
            t.Start();
        }
    }
    static void DemoThread()
    {
        for(var i = 0; i < 5; i++)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine(i);
        }
    }
    static void DemoThread(string threadIndex)
    {
        for(var i = 0; i < 5; i++)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine($"{threadIndex} - {i}");
        }
    }
}