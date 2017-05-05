using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;

namespace OS_Timer
{
    public partial class IO_Stream : Form
    {
        public IO_Stream()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             string path = @"createText.txt";


             using (StreamWriter sw = File.CreateText(path))
             {
                 sw.WriteLine("Hello!!!");
                 sw.Close();
             }
                 
                 richTextBox2.AppendText("Created 'createText.txt' \n");
            richTextBox2.ScrollToCaret();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"createText.txt";
            
                using (StreamWriter sw = File.AppendText(path))
                {
                    if (textBox4.Text != "")
                    {
                        sw.WriteLine(textBox4.Text);
                        richTextBox2.AppendText("AppendText '" + textBox4.Text + "'\n");
                        richTextBox2.ScrollToCaret();
                        sw.Close();
                    }
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = @"createText.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    richTextBox1.AppendText(s + "\n");
                    richTextBox2.AppendText("ReadLine '" + s + "'\n");
                    richTextBox1.ScrollToCaret();
                    richTextBox2.ScrollToCaret();
                }
                sr.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "createText.txt";
                string sourceFile = System.IO.Path.Combine(@"", fileName);
                string destFile = System.IO.Path.Combine(@"", "createText_Copy.txt");
                System.IO.File.Copy(sourceFile, destFile, true);
                richTextBox2.AppendText("Copy Complete!! \n");
                richTextBox2.ScrollToCaret();
            }
            catch (Exception FF)
            {
 
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceFile = @"createText_Copy.txt";
                string destinationFile = @"move\createText_Copy.txt";

                System.IO.File.Move(sourceFile, destinationFile);
                richTextBox2.AppendText("Move Complete!! \n");
                richTextBox2.ScrollToCaret();
                
            }
            catch (Exception FF)
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Delete(@"move\createText_Copy.txt");
                richTextBox2.AppendText("Delete Complete!! \n");
                richTextBox2.ScrollToCaret();
            }
            catch (System.IO.IOException FF)
            {
                Console.WriteLine(FF.Message);
            }
        }
    }
}
