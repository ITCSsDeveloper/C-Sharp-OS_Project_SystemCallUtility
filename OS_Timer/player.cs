using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OS_Timer
{
    public partial class player : Form
    {
        public player()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {

         
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Media AVI|*.avi";
            openFileDialog1.Title = "Select a Cursor File";

           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               openFileDialog1.OpenFile();
               textBox5.Text = openFileDialog1.FileName.ToString();

               axWindowsMediaPlayer1.URL = textBox5.Text;

            }

        }
    }
}
