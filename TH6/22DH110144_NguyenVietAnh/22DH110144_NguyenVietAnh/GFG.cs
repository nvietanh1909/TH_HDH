using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22DH110144_NguyenVietAnh
{
    internal class GFG
    {
        public static void findWaitingTime(int[] processes, int n, int[] bt, int[] wt, int quantum)
        {
            var rem_bt = new int[n];
            for (var i = 0; i < n; i++) rem_bt[i] = bt[i];
            int t = 0;
            while (true)
            {
                bool done = true;
                for (var i = 0; i < n; i++)
                {
                    if (rem_bt[i] > 0)
                    {
                        done = false;
                        if (rem_bt[i] > quantum)
                        {
                            t += quantum;
                            rem_bt[i] -= quantum;
                        }
                        else
                        {
                            t += rem_bt[i];
                            wt[i] = t - bt[i];
                            rem_bt[i] = 0;
                        }
                    }
                }
                if (done) break;
            }
        }
        public static void findTurnAroundTime(int[] processes, int n, int[] bt, int[] wt, int[] tat)
        {
            for (var i = 0; i < n; i++)
            {
                tat[i] = bt[i] + wt[i];
            }
        }

        public static void findavgTime(int[] processes, int n, int[] bt, int quantum)
        {
            var wt = new int[n];
            var tat = new int[n];
            int total_wt = 0, total_tat = 0;
            findWaitingTime(processes, n, bt, wt, quantum);
            findTurnAroundTime(processes, n, bt, wt, tat);
            Console.WriteLine("Processes " + " Burst time " + " Waiting time " + " Turn around time");
            for (var i = 0; i < n; i++)
            {
                total_wt = total_wt + wt[i];
                total_tat = total_tat + tat[i];
                Console.WriteLine(" " + (i + 1) + "\t\t" + bt[i] + "\t " + wt[i] + "\t\t " + tat[i]);
            }
            Console.WriteLine("Average waiting time = " + (float)total_wt / (float)n);
            Console.Write("Average turn around time = " + (float)total_tat / (float)n);
        }
        public static void roundRobin(String[] p, int[] a, int[] b, int n)
        {
            // result of average times
            int res = 0; int resc = 0;
            // for sequence storage
            String seq = "";
            // copy the burst array and arrival array
            // for not effecting the actual array
            int[] res_b = new int[b.Length]; int[]
            res_a = new int[a.Length];
            for (int i = 0; i < res_b.Length; i++)
            {
                res_b[i] = b[i];
                res_a[i] = a[i];
            }
            // critical time of system
            int t = 0;
            // for store the waiting time
            int[] w = new int[p.Length];
            // for store the Completion time
            int[] comp = new int[p.Length];
            while (true)
            {
                Boolean flag = true;
                for (int i = 0; i < p.Length; i++)
                {
                    // these condition for if
                    // arrival is not on zero
                    // check that if there come before qtime
                    if (res_a[i] <= t)
                    {
                        if (res_a[i] <= n)
                        {
                            if (res_b[i] > 0)
                            {
                                flag = false;
                                if (res_b[i] > n)
                                {
                                    // make decrease the b time
                                    t = t + n; res_b[i] =
                                    res_b[i] - n;
                                    res_a[i] = res_a[i] + n;
                                    seq += "->" + p[i];
                                }
                                else
                                {
                                    // for last time
                                    t = t + res_b[i];
                                    // store comp time
                                    comp[i] = t - a[i];
                                    // store wait time
                                    w[i] = t - b[i] - a[i];
                                    res_b[i] = 0;
                                    // add sequence
                                    seq += "->" + p[i];
                                }
                            }
                        }
                        else if (res_a[i] > n)
                        {
                            // is any have less arrival time
                            // the coming process then execute
                            // them
                            for (int j = 0; j < p.Length; j++)
                            {
                                // compare
                                if (res_a[j] < res_a[i])
                                {
                                    if (res_b[j] > 0)
                                    {
                                        flag = false;
                                        if (res_b[j] > n)
                                        {
                                            t = t + n; res_b[j]
                                            = res_b[j] - n;
                                            res_a[j] = res_a[j] + n;
                                            seq += "->" + p[j];
                                        }
                                        else
                                        {
                                            t = t + res_b[j];
                                            comp[j] = t - a[j];
                                            w[j] = t - b[j]
                                            - a[j]; res_b[j] = 0;
                                            seq += "->" + p[j];
                                        }
                                    }
                                }
                            }
                            if (res_b[i] > 0)
                            {
                                flag = false;
                                if (res_b[i] > n)
                                {
                                    t = t + n; res_b[i] =
                                    res_b[i] - n; res_a[i] =
                                    res_a[i] + n;
                                    seq += "-> " + p[i];
                                }
                                else
                                {
                                    t = t + res_b[i];
                                    comp[i] = t - a[i];
                                    w[i] = t - b[i] - a[i];
                                    res_b[i] = 0;
                                    seq += "-> " + p[i];
                                }
                            }
                        }
                    }
                    else if (res_a[i] > t)
                    {
                        t++;
                        i--;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            Console.WriteLine("name ctime wtime");
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(" " + p[i] + "\t" + comp[i] + "\t" + w[i]);
                res = res + w[i];
                resc = resc + comp[i];
            }
            Console.WriteLine("Average waiting time is " + (float)res / p.Length);
            Console.WriteLine("Average compilation time is " + (float)resc / p.Length);
            Console.WriteLine("Sequence is like that " + seq);
        }

    }
}