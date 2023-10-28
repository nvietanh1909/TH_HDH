using System.Threading;
using System.Resources;
using System.IO;

namespace ThreadDemo
{
    public partial class Form1 : Form
    {
        //Field
        Stream myStream;
        MyThread[] threadLst = new MyThread[26];
        const int xCell = 30;
        const int yCell = 30;
        const int xMax = 25;
        const int yMax = 20;
        public Random rnd = new Random();
        void Running(object obj)
        {
            MyThread p = (MyThread)obj;
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.FromArgb(0, 0, 0));
            int x1, y1;
            int x2, y2;
            int x, y;
            bool kq = true;
            try
            {
                while (p.start)
                {
                    x1 = p.Pos.X; y1 = p.Pos.Y;
                    g.DrawImage(p.Pic, xCell * x1, yCell * y1);
                    Color c = p.Pic.GetPixel(1, 1);
                    int yR, yG, yB;
                    if (c.R > 128) yR = 0; else yR = 255;
                    if (c.G > 128) yG = 0; else yG = 255;
                    if (c.B > 128) yB = 0; else yB = 255;
                    Pen pen = new Pen(Color.FromArgb(yR, yG, yB), 2);
                    if (p.tx >= 0 && p.ty >= 0)
                    {
                        x = xCell * x1 + xCell - 2;
                        y = yCell * y1 + yCell - 2;
                        g.DrawLine(pen, x, y, x - 10, y);
                        g.DrawLine(pen, x, y, x, y - 10);
                    }
                    else if (p.tx >= 0 && p.ty < 0)
                    {
                        x = xCell * x1 + xCell - 2;
                        y = yCell * y1 + 2;
                        g.DrawLine(pen, x, y, x - 10, y);
                        g.DrawLine(pen, x, y, x, y + 10);
                    }
                    else if (p.tx < 0 && p.ty >= 0)
                    {
                        x = xCell * x1 + 2;
                        y = yCell * y1 + yCell - 2;
                        g.DrawLine(pen, x, y, x + 10, y);
                        g.DrawLine(pen, x, y, x, y - 10);
                    }
                    else
                    {
                        x = xCell * x1 + 2;
                        y = yCell * y1 + 2;
                        g.DrawLine(pen, x, y, x + 10, y);
                        g.DrawLine(pen, x, y, x, y + 10);
                    }
                    MySleep(500);
                    p.HieuchinhVitri();
                    x2 = p.Pos.X; y2 = p.Pos.Y;
                    g.FillRectangle(brush, xCell * x1, yCell * y1, xCell, yCell);
                    if (kq == false && p.start == false)
                    {
                        p.t.Abort();
                        p.stop = true;
                        return;
                    }
                }
            } catch(Exception e) { p.t.Abort(); }
            x1 = p.Pos.X; y1 = p.Pos.Y;
            g.FillRectangle(brush, xCell * x1, yCell * y1, xCell, yCell);
            p.stop = true;
            p.t.Abort();
        }
        void MySleep(long count)
        {
            long i, j, k = 0;
            for (i = 0; i < count; i++)
                for (j = 0; j < 64000; j++) k = k + 1;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly myAssembly = this.GetType().Assembly;
            for (var i = 0; i < 26; i++)
            {
                threadLst[i] = new MyThread(rnd, xMax, yMax);
                threadLst[i].stop = threadLst[i].suspend = threadLst[i].start = false;
                char c = (char)(i + 65);
                Stream myStream = myAssembly.GetManifestResourceStream(myAssembly.GetName().Name + ".Resources." + c + ".png");
                threadLst[i].Pic = new Bitmap(myStream);
                threadLst[i].Xmax = 25;
                threadLst[i].Ymax = 20;
            }
            ClientSize = new Size(25 * 30, 20 * 30);
            this.Location = new Point(0, 0);
            this.BackColor = Color.Black;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   
            int newch = e.KeyValue;
            if (newch < 0x41 || newch > 0x5a) return;
            if (e.Control && e.Shift)
            {
                threadLst[newch - 65].start = false;
            }
            else if (e.Control)
            {
                threadLst[newch - 65].t.Priority = ThreadPriority.Lowest;
                MessageBox.Show(threadLst[newch - 65].t.Priority.ToString());
            }
            else if (e.Control && e.Alt)
            {
                if (threadLst[newch - 65].start && !threadLst[newch - 65].suspend)
                {
                    threadLst[newch - 65].t.Suspend();
                    threadLst[newch - 65].suspend = true;
                }
            }
            else if (e.Alt)
            {
                if (threadLst[newch - 65].start && threadLst[newch - 65].suspend)
                {
                    threadLst[newch - 65].t.Resume();
                    threadLst[newch - 65].suspend = false;
                }
            }
            else if (e.Shift)
            {
                threadLst[newch - 65].t.Priority = ThreadPriority.Highest;
                MessageBox.Show(threadLst[newch - 65].t.Priority.ToString());
            }
            else
            {
                if (!threadLst[newch - 65].start)
                {
                    threadLst[newch - 65].start = true;
                    threadLst[newch - 65].suspend = false;
                    threadLst[newch - 65].t = new Thread(new ParameterizedThreadStart(Running));
                    if (newch == 65) threadLst[newch - 65].t.Priority = ThreadPriority.Highest;
                    else threadLst[newch - 65].t.Priority = ThreadPriority.Lowest;
                    threadLst[newch - 65].t.Start(threadLst[newch - 65]);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (var i = 0; i < 26; i++)
                if (threadLst[i].start)
                {
                    threadLst[i].start = false;
                    while (!threadLst[i].stop) ;
                }
        }
    }
}