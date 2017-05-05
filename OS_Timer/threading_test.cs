using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace OS_Timer
{
    public partial class threading_test : Form
    {
        public threading_test()
        {
            InitializeComponent();
        }


        public delegate void InvokeDelegate();


        private void button10_Click(object sender, EventArgs e)
        {
            Thread TT = new Thread(TT1);
            TT.Start();
        }


        int i = 0, j = 10, k = 100;
        void TT1()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (label1.InvokeRequired)
                {
                    BeginInvoke(new InvokeDelegate(InvokeMethod1));
                }
                i++;

                if (k <= 0)
                { 
                    break; 
                }
            }
        }

        void TT2()
        {
            while (true)
            {
                Thread.Sleep(2000);
                if (label5.InvokeRequired)
                {
                    BeginInvoke(new InvokeDelegate(InvokeMethod2));
                }
                j++;

                if (k <= 0)
                {
                    break;
                }
            }
        }

        void TT3()
        {
            while (true)
            {
                Thread.Sleep(3000);
                if (label6.InvokeRequired)
                {
                    BeginInvoke(new InvokeDelegate(InvokeMethod3));
                }
                k++;

                if (k <= 0)
                {
                    break;
                }
            }
        }

        public void InvokeMethod1()
        {
            label1.Text = i + "";
        }
        public void InvokeMethod2()
        {
            label5.Text = j + "";
        }
        public void InvokeMethod3()
        {
            label6.Text = k + "";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            k = -100;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Thread TT = new Thread(TT2);
            TT.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Thread TT = new Thread(TT3);
            TT.Start();
        }
    }
}