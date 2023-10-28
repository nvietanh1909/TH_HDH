using System;
using static _22DH110144_NguyenVietAnh.GFG;
namespace _22DH110144_NguyenVietAnh;
class Program
{
    static void Main(string[] args)
    {
        //Câu 1
        //int[] processes = { 1, 2, 3, 4 };
        //int n = processes.Length;
        //int[] burst_time = { 21, 3, 6, 2 };
        //int quantum = 5;
        //findavgTime(processes, n, burst_time, quantum);
        //Câu 2
        //String[] name = { "p1", "p2", "p3", "p4", "p5" };
        //int[] arrivaltime = { 0, 5, 12, 2, 9 };
        //int[] bursttime = { 11, 28, 2, 10,16 };
        //int q = 3;
        //roundRobin(name, arrivaltime, bursttime, q);
        //Câu 3
        String[] name = { "p1", "p2", "p3", "p4", "p5" , "p6"};
        int[] arrivaltime = { 0, 25, 20, 35, 10, 15 };
        int[] bursttime = { 20, 25, 25, 15, 35, 50 };
        int q = 10;
        roundRobin(name, arrivaltime, bursttime, q);
    }
}