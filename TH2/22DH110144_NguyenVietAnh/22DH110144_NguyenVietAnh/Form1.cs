using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace _22DH110144_NguyenVietAnh
{
    public partial class Form1 : Form
    {
        double[,] A;
        double[,] B;
        double[,] C;
        int N;
        int[] stateLst = new int[20];
        System.TimeSpan[] dateLst = new System.TimeSpan[20];
        ProcessPriorityClass myPrio = ProcessPriorityClass.Normal;
        Process MyProc;
        ThreadPriority[] tPrio = {
        ThreadPriority.Lowest, ThreadPriority.BelowNormal, ThreadPriority.Normal,
        ThreadPriority.AboveNormal, ThreadPriority.Highest
        };
        class Params
        {
            public Thread t;
            public int sr;
            public int er;
            public int id;
            public Params(Thread t, int s, int e, int i)
            {
                this.t = t; sr = s;
                er = e;
                id = i;
            }
        };
        
        void TinhTich(object obj)
        {
            DateTime t1 = DateTime.Now;
            Params p = (Params)obj;
            int h, c, k;
            for (h = p.sr; h < p.er; h++)
                for (c = 0; c < N; c++)
                {
                    double s = 0;
                    for (k = 0; k < N; k++)
                        s = s + A[h, k] * B[k, c];
                    C[h, c] = s;
                }
            stateLst[p.id] = 1;
            dateLst[p.id] = DateTime.Now.Subtract(t1);
        }
        public Form1()
        {
            InitializeComponent();
            lbKetqua.Items.Clear();
            N = 1000;
            A = new double[N, N];
            B = new double[N, N];
            C = new double[N, N];
            int h, c;
            for (h = 0; h < N; h++)
                for (c = 0; c < N; c++)
                    A[h, c] = B[h, c] = c;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            myPrio = ProcessPriorityClass.BelowNormal;
        }

        private void btnNhanh_Click(object sender, EventArgs e)
        {
            myPrio = ProcessPriorityClass.RealTime;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MyProc = Process.GetCurrentProcess();
            MyProc.PriorityClass = myPrio;
            int cnt = Int32.Parse(txtThreads.Text);
            int i;
            DateTime t1 = DateTime.Now;
            if (cnt == 1)
            { 
                TinhTich(new Params(null, 0, N, 0));
            }
            else
            {
                Thread t;
                for (i = 0; i < cnt - 1; i++)
                {
                    stateLst[i] = 0; 
                    t = new Thread(new ParameterizedThreadStart(TinhTich));
                    t.Priority = tPrio[i % 5];
                    lbKetqua.Items.Add(String.Format("Thread {0:d} co do uu tien = {1:d}", i,
                   t.Priority.ToString()));
                    t.Start(new Params(t, i * N / cnt, (i + 1) * N / cnt, i));
                }
            }
            TinhTich(new Params(null, (cnt - 1) * N / cnt, N, cnt - 1));
            for (i = 0; i < cnt - 1; i++)
                while (stateLst[i] == 0) ;
            DateTime t2 = DateTime.Now;
            System.TimeSpan diff;
            lbKetqua.Items.Add("Ung dung da chay voi quyen " + myPrio.ToString());
            for (i = 0; i < cnt - 1; i++)
            {
                diff = dateLst[i];
                lbKetqua.Items.Add(String.Format("Thread {0:d} chay ton {1:d2} phut {2:d2} giay {3:d3} ms",i, diff.Minutes, diff.Seconds, diff.Milliseconds));
            }
            diff = t2.Subtract(t1);
            lbKetqua.Items.Add(String.Format("{0:d} threads ==> Thoi gian chay la {1:d2} phut {2:d2} giay {3:d3} ms", cnt, diff.Minutes, diff.Seconds, diff.Milliseconds));
        }

        private void txtThreads_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
