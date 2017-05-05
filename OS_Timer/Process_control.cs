using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace OS_Timer
{
    public partial class Process_control : Form
    {
        public Process_control()
        {
            InitializeComponent();
        }


        Process process = new Process();
        
        int i = 0;
        public struct RECT
        {
            public int X;
            public int Y;
            public int Width;
            public int Height;
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int Width, int Height, bool Repaint);



        private void button25_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }
        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
        private void button27_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }

        private void button24_Click(object sender, EventArgs e)
        {
         
            process.Start();
        }
        private void button31_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("notepad");
            foreach (Process p in processes)
            {
                IntPtr handle = p.MainWindowHandle;
                RECT Rect = new RECT();
                if (GetWindowRect(handle, ref Rect))
                    MoveWindow(handle, Rect.X, Rect.Y, 320, 240, true);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("notepad");
            foreach (Process p in processes)
            {
                IntPtr handle = p.MainWindowHandle;
                RECT Rect = new RECT();
                if (i == 0)
                {
                    if (GetWindowRect(handle, ref Rect))
                        MoveWindow(handle, 0, 0, 320, 240, true);
                    i = 1;
                }
                else if (i == 1)
                {
                    if (GetWindowRect(handle, ref Rect))
                        MoveWindow(handle, 400, 200, 320, 240, true);
                    i = 2;
                }
                else if (i == 2)
                {
                    if (GetWindowRect(handle, ref Rect))
                        MoveWindow(handle, 850, 415, 320, 240, true);
                    i = 0;
                }
            }
        }
        private void button33_Click(object sender, EventArgs e)
        {
            Process[] prs = Process.GetProcesses();
            foreach (Process pr in prs)
            {
                if (pr.ProcessName == "notepad")
                {
                    pr.Kill();
                }
            }
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string msg_to_key = "";
        void Auto_key()
        {
            for (int j = 0; j < msg_to_key.Length; j++)
            {
                Thread.Sleep(500);
                SendKeys.SendWait ("{"+msg_to_key.Substring(j,1)+"}");
            }
        }

        private void Process_control_Load(object sender, EventArgs e)
        {
            process.StartInfo.FileName = "notepad.exe";
        }

    }
}
