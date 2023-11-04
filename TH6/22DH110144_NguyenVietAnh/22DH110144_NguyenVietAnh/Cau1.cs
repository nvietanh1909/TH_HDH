using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _22DH110144_NguyenVietAnh.GFG;


namespace _22DH110144_NguyenVietAnh;

internal class Cau1
{
    static void Main()
    {
        int[] processes = { 1, 2, 3, 4 };
        int n = processes.Length;
        int[] burst_time = { 21, 3, 6, 2 };
        int quantum = 5;
        findavgTime(processes, n, burst_time, quantum);
    }
}
