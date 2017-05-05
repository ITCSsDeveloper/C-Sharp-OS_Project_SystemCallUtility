using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Management;

namespace OS_Timer
{
    public partial class Battery_info : Form
    {
        public Battery_info()
        {
            InitializeComponent();
        }

        private void Battery_info_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        double battery_percent = 1;
        int BatteryLifeRemaining = -1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            battery_percent = double.Parse(SystemInformation.PowerStatus.BatteryLifePercent.ToString()) * 100; 
            BatteryLifeRemaining = int.Parse(SystemInformation.PowerStatus.BatteryLifeRemaining.ToString());

            if (BatteryLifeRemaining > 0)
            {
                TimeSpan t = TimeSpan.FromSeconds(BatteryLifeRemaining);

                string answer = string.Format("{0:D2}h:{1:D2}m", t.Hours, t.Minutes);

                textBox11.Text = answer;
            }
            else
            {
                textBox11.Text = "N/A";
            }

            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery");
            
            foreach (ManagementObject mo in mos.Get())
            {
                textBox13.Text = mo["Name"].ToString();
            }

            textBox12.Text = "" + battery_percent + " % ";
            textBox10.Text = SystemInformation.PowerStatus.BatteryChargeStatus.ToString(); // เวลาที่ใช้ได้ ( วินาที )
        }
    }
}
