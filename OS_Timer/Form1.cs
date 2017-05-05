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


namespace OS_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string hh, mm;
        string _HH, _MM;
        string info_noti = "ยังไม่มีตั้งค่าการทำงาน";


        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                hh = comboBox1.Text;
                mm = comboBox2.Text;


                if (checkBox1.Checked == true)
                {
                    info_noti = "[" + comboBox3.Text + "] @ " + hh + ":" + mm + " - มีแจ้งเตือน";
                }
                else
                { info_noti = "[" + comboBox3.Text + "] @ " + hh + ":" + mm + " - ไม่มีแจ้งเตือน!!"; }


                textBox2.Text = hh + ":" + mm;
                textBox3.Text = comboBox3.Text;

                timer1.Stop();
                timer2.Start();
            }
        }

        bool chk = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
            _HH = string.Format("{0:HH}", DateTime.Now);
            _MM = string.Format("{0:mm}", DateTime.Now);

            if (_HH == hh && _MM == mm || chk == true)
            {
                timer2.Stop();

                if (comboBox3.SelectedIndex == 0)
                {
                    if (checkBox1.Checked == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("ระบบกำลังจะ Shutdown คุณต้องการทำมันหรือไม่ ?", "Auto Timer ", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Process.Start("shutdown", "/s /t 3");

                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    { Process.Start("shutdown", "/s /t 0"); }
                }

                else if (comboBox3.SelectedIndex == 1)
                {
                    if (checkBox1.Checked == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("ระบบกำลังจะ Restart คุณต้องการทำมันหรือไม่ ? ", "Auto Timer ", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Process.Start("shutdown", "/r /t 3");

                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    { Process.Start("shutdown", "/r /t 0"); }
                }

                else if (comboBox3.SelectedIndex == 2)
                {
                    if (checkBox1.Checked == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("ระบบกำลังจะ Logoff คุณต้องการทำมันหรือไม่ ?", "Auto Timer ", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Process.Start("shutdown", "/sl /t 3");

                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    { Process.Start("shutdown", "/l /t 0"); }
                }


                timer2.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/GmtanBeartai2010");
        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                hh = comboBox1.Text;
                mm = comboBox2.Text;


                if (checkBox1.Checked == true)
                {
                    info_noti = "[" + comboBox3.Text + "] @ " + hh + ":" + mm + " - มีแจ้งเตือน";
                }
                else
                { info_noti = "[" + comboBox3.Text + "] @ " + hh + ":" + mm + " - ไม่มีแจ้งเตือน!!"; }


                textBox2.Text = hh + ":" + mm;
                textBox3.Text = comboBox3.Text;

                timer1.Stop();
                timer2.Start();
            }

            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Auto timer ถูกซ่อนไว้ที่นี้...";
                notifyIcon1.Text = info_noti;
                notifyIcon1.ShowBalloonTip(2000);
                Hide();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.Show();
            }
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chk = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form DD = new Process_control();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form DD = new Auto_mk ();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form DD = new Battery_info ();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form DD = new info_process();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form DD = new threading_test ();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form DD = new webcamera ();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form DD = new IO_Stream ();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form DD = new Speakers_Control ();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form DD = new player ();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form DD = new brwoser ();
            DD.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

       

       

      

       
      