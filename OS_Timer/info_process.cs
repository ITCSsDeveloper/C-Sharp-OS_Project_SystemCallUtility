using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace OS_Timer
{
    public partial class info_process : Form
    {
        public info_process()
        {
            InitializeComponent();
        }

        private void info_process_Load(object sender, EventArgs e)
        {
            textBox6.Text = (""+  Environment.MachineName);
            textBox7.Text = ("" + Environment.OSVersion );
            textBox8.Text= ( "" + Environment.UserName);
            textBox9.Text = ("" + Environment.ProcessorCount );

            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "" + process.ProcessName ;
                item.SubItems.Add("" + process.Id);
      
                listView1.Items.Add(item);
            }

        }

        string name_process_kill = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Selected == true )
            {
                name_process_kill = "" + listView1.SelectedItems[0].Text;

                if (name_process_kill != "")
                {
                    try
                    {
                        Process[] prs = Process.GetProcesses();
                        foreach (Process pr in prs)
                        {
                            if (pr.ProcessName == name_process_kill)
                            {
                                pr.Kill();
                                button2_Click(null, null);
                            }
                        }
                    }
                    catch (Exception FF)
                    {
                        Console.WriteLine(FF);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
              
                ListViewItem item = new ListViewItem();
                item.Text = "" + process.ProcessName ;
                item.SubItems.Add("" + process.Id);

                listView1.Items.Add(item);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB(); // avaliable
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();              // total
            progressBar1.Value = (int)(performanceCounter1.NextValue());
            progressBar2.Maximum = (int)tot;
            progressBar2.Value = (int)(tot - phav) ;

            label1.Text = progressBar1.Value.ToString() + "%";
            label2.Text = (int)(tot - phav) + "/"+ tot ;
         
        }
    }


}



public static class PerformanceInfo
{
    [DllImport("psapi.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetPerformanceInfo([Out] out PerformanceInformation PerformanceInformation, [In] int Size);

    [StructLayout(LayoutKind.Sequential)]
    public struct PerformanceInformation
    {
        public int Size;
        public IntPtr CommitTotal;
        public IntPtr CommitLimit;
        public IntPtr CommitPeak;
        public IntPtr PhysicalTotal;
        public IntPtr PhysicalAvailable;
        public IntPtr SystemCache;
        public IntPtr KernelTotal;
        public IntPtr KernelPaged;
        public IntPtr KernelNonPaged;
        public IntPtr PageSize;
        public int HandlesCount;
        public int ProcessCount;
        public int ThreadCount;
    }

    public static Int64 GetPhysicalAvailableMemoryInMiB()
    {
        PerformanceInformation pi = new PerformanceInformation();
        if (GetPerformanceInfo(out pi, Marshal.SizeOf(pi)))
        {
            return Convert.ToInt64((pi.PhysicalAvailable.ToInt64() * pi.PageSize.ToInt64() / 1048576));
        }
        else
        {
            return -1;
        }

    }

    public static Int64 GetTotalMemoryInMiB()
    {
        PerformanceInformation pi = new PerformanceInformation();
        if (GetPerformanceInfo(out pi, Marshal.SizeOf(pi)))
        {
            return Convert.ToInt64((pi.PhysicalTotal.ToInt64() * pi.PageSize.ToInt64() / 1048576));
        }
        else
        {
            return -1;
        }

    }
}


