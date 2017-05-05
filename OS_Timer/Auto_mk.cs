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
    public partial class Auto_mk : Form
    {
        public Auto_mk()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                Process.Start("notepad.exe");
                msg_to_key = textBox14.Text;
                Thread AA = new Thread(Auto_key);
                AA.Start();
            }
        }

        string msg_to_key = "";
        void Auto_key()
        {
            for (int j = 0; j < msg_to_key.Length; j++)
            {
                Thread.Sleep(500);
                SendKeys.SendWait("{" + msg_to_key.Substring(j, 1) + "}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");

            Thread AA = new Thread(Auto_mouse);
            AA.Start();
        }



        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static void DoMouseClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        void Auto_mouse()
        {
            Thread.Sleep(500);
            Cursor.Position = new Point(335, 75);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            Thread.Sleep(500);
            Cursor.Position = new Point(630, 80);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            Thread.Sleep(500);
            Cursor.Position = new Point(675, 256);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);


            int m_x = 300, m_y = 286;
            int limit = 0;
         
            while (m_x > 236 && m_y > 218) 
            {
                Thread.Sleep(5);
                Cursor.Position = new Point(m_x, m_y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                if (m_x % 2 == 0)
                {
                    m_y-=1;
                }
                m_x--;

                limit++;
                if (limit > 200)
                { break; }
                Console.WriteLine(limit);
            }

            limit = 0;
            while (m_x > 165 && m_y < 326)
            {
                Thread.Sleep(5);
                Cursor.Position = new Point(m_x, m_y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                
                m_x--;
                m_y++;

                limit++;
                if (limit > 200)
                { break; }
                Console.WriteLine(limit);
            }

            limit = 0;
            while (m_x < 329 && m_y < 495)
            {
                Thread.Sleep(5);
                Cursor.Position = new Point(m_x, m_y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                m_x++;
                m_y++;

                limit++;
                if (limit > 400)
                { break; }
                Console.WriteLine(limit);
            }

            limit = 0;
            while (m_x < 495 && m_y > 328)
            {
                Thread.Sleep(5);
                Cursor.Position = new Point(m_x, m_y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                m_x++;
                m_y--;

                limit++;
                if (limit > 3000)
                { break; }
                Console.WriteLine(limit);
            }

            limit = 0;
            while (m_x > 385 && m_y > 224)
            {
                Thread.Sleep(5);
                Cursor.Position = new Point(m_x, m_y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                m_x--;
                m_y--;

                limit++;
                if (limit > 500)
                { break; }
                Console.WriteLine(limit);
            }

            limit = 0;
            while (m_x > 150 && m_y < 286+20)
            {
                Thread.Sleep(5);
                Cursor.Position = new Point(m_x, m_y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                m_x--;
                m_y++;

                limit++;
                if (limit > 300)
                { break; }
                Console.WriteLine(limit);
            }

            Thread.Sleep(1000);
            Cursor.Position = new Point(301, 76);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            Thread.Sleep(1000);
            Cursor.Position = new Point(461, 439);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            Thread.Sleep(1000);
            Cursor.Position = new Point(153, 112);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);


            Thread.Sleep(1000);
            Cursor.Position = new Point(136, 262);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            Thread.Sleep(1000);
            Cursor.Position = new Point(461, 439);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);


            msg_to_key = "ITCSS_Developer";
            for (int j = 0; j < msg_to_key.Length; j++)
            {
                Thread.Sleep(800);
                SendKeys.SendWait("{" + msg_to_key.Substring(j, 1) + "}");
            }

            Thread.Sleep(1000);
            Cursor.Position = new Point(400, 400);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}
