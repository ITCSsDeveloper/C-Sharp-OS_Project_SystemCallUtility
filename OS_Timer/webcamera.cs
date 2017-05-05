using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace OS_Timer
{
    public partial class webcamera : Form
    {
        public webcamera()
        {
            InitializeComponent();
        }

        private FilterInfoCollection videoCaptureDevice;
        private VideoCaptureDevice FinalVideo;

        private void webcamera_Load(object sender, EventArgs e)
        {
            videoCaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo Temp in videoCaptureDevice)
            {
                comboBox1.Items.Add(Temp.Name);
            }

            comboBox1.SelectedIndex = 0;
            FinalVideo = new VideoCaptureDevice();
        }





        private void button13_Click(object sender, EventArgs e)
        {
            if (FinalVideo.IsRunning == true) { FinalVideo.Stop(); }
            else
            {
                FinalVideo = new VideoCaptureDevice(videoCaptureDevice[comboBox1.SelectedIndex].MonikerString);
                FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                FinalVideo.Start();
            }
        }

        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = video;
        }

        int i = 0;
        private void button14_Click(object sender, EventArgs e)
        {
            string File_Name = "capture.jpg";
            while (true)
            {
                if (File.Exists(File_Name))
                {
                    i++;
                    File_Name = ("capture" + i + ".jpg");
                }
                else
                {
                    pictureBox1.Image.Save(File_Name);
                    i = 0;
                    break;
                }
            }
        }
    }
}