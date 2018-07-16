using OpenHardwareMonitor.Hardware;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PC_Monitor
{
    public partial class MainScreen : Form
    {
        private Computer computer;
        private PerformanceCounter disk0ReadsPerSec = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "2 C:");
        private PerformanceCounter disk0WritesPerSec = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "2 C:");
        private PerformanceCounter disk1ReadsPerSec = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "0 E:");
        private PerformanceCounter disk1WritesPerSec = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "0 E:");
        private PerformanceCounter disk2ReadsPerSec = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "1 F:");
        private PerformanceCounter disk2WritesPerSec = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "1 F:");
        private DriveInfo[] drives = DriveInfo.GetDrives();

        private int tempLimit = 3;

        public MainScreen()
        {
            InitializeComponent();
            
            geckoWebBrowserCapital.Navigate("http://www.capitalfm.com/london/radio/player/#");
            geckoWebBrowserCalc.Navigate("http://www.wolframalpha.com/");
            geckoWebBrowserYoutube.Navigate("https://www.youtube.com/");

            computer = new Computer();

            computer.Open();

            computer.MainboardEnabled = true;
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.HDDEnabled = true;
            computer.RAMEnabled = true;
            computer.FanControllerEnabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBarCPURPM.Visible = false; // Remove when Fan speed found
            label6.Visible = false; // Remove when Fan speed found

            groupBoxCPU.Text = computer.Hardware[1].Name;
            groupBoxGPU.Text = computer.Hardware[2].Name;
            
            groupBoxDisk0.Text = drives[0].Name + "Local Disk";
            groupBoxDisk1.Text = drives[1].Name + drives[1].VolumeLabel;
            groupBoxDisk2.Text = drives[2].Name + drives[2].VolumeLabel;

            UpdateVisuals();

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {   
            UpdateVisuals();

            labelReadDisk0.Text = MB(disk0ReadsPerSec.NextValue()).ToString("0.00") + "MB/s";
            labelWriteDisk0.Text = MB(disk0WritesPerSec.NextValue()).ToString("0.00") + "MB/s";

            labelReadDisk1.Text = MB(disk1ReadsPerSec.NextValue()).ToString("0.00") + "MB/s";
            labelWriteDisk1.Text = MB(disk1WritesPerSec.NextValue()).ToString("0.00") + "MB/s";

            labelReadDisk2.Text = MB(disk2ReadsPerSec.NextValue()).ToString("0.00") + "MB/s";
            labelWriteDisk2.Text = MB(disk2WritesPerSec.NextValue()).ToString("0.00") + "MB/s";

            labelSpaceDisk0.Text = GB(drives[0].TotalFreeSpace) + "/" + GB(drives[0].TotalSize) + " GB";

            labelSpaceDisk1.Text = GB(drives[1].TotalFreeSpace) + "/" + GB(drives[1].TotalSize) + " GB";

            labelSpaceDisk2.Text = GB(drives[2].TotalFreeSpace) + "/" + GB(drives[2].TotalSize) + " GB";
        }

        private long GB(long bytes)
        {
            return (((bytes / 1024) / 1024) / 1024);
        }

        private float MB(float bytes)
        {
            return ((bytes / 1024) / 1024);
        }

        private void UpdateVisuals()
        {
            int cpuTemp = 0;
            int gpuTemp = 0;

            int cpuLoad = 0;
            int gpuLoad = 0;

            int cpuRPM = 0; // Not Found
            int gpuRPM = 0;

            int ramLoad = 0;
            int ramUsed = 0;
            int ramAvailable = 0;
            
            int hddLoad = 0;
            int hddCount = 0;

            // Get data

            //Console.WriteLine("==========================");
            foreach (IHardware hardware in computer.Hardware)
            {
                //Console.WriteLine("--------------------------");
                hardware.Update();
                //Console.WriteLine(hardware.Name);
                //Console.WriteLine("->" + hardware.HardwareType);
                
                if (hardware.HardwareType.ToString().ToLower().Contains("cpu"))
                {
                    cpuLoad = (int)hardware.Sensors[4].Value;
                    cpuTemp = (int)hardware.Sensors[9].Value;
                    cpuRPM = 0;
                }

                if (hardware.HardwareType.ToString().ToLower().Contains("gpu"))
                {
                    gpuTemp = (int)hardware.Sensors[0].Value;
                    gpuLoad = (int)hardware.Sensors[5].Value;
                    gpuRPM = (int)hardware.Sensors[8].Value;
                }

                if (hardware.HardwareType.ToString().ToLower().Contains("ram"))
                {
                    ramLoad = (int)hardware.Sensors[0].Value;
                    ramUsed = (int)hardware.Sensors[1].Value;
                    ramAvailable = (int)hardware.Sensors[2].Value;
                }
                
                if (hardware.HardwareType.ToString().ToLower().Contains("hdd"))
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            hddLoad = (int)sensor.Value;

                            if (hddCount == 0)
                            {
                                progressBarDisk1.Value = hddLoad;
                            }

                            else if (hddCount == 1)
                            {
                                progressBarDisk2.Value = hddLoad;
                            }

                            else if (hddCount == 2)
                            {
                                progressBarDisk0.Value = hddLoad;
                            }

                            hddCount++;
                        }
                    }
                }

                /*
                foreach (ISensor sensor in hardware.Sensors)
                {
                    Console.WriteLine("-->" + sensor.Name);
                    Console.WriteLine("--->" + sensor.Hardware);
                    Console.WriteLine("---->" + sensor.SensorType);
                    Console.WriteLine("----->" + sensor.Value);
                }*/
            }

            // Setting visuals to display data

            circularProgressBarCPUTemp.Value = cpuTemp;
            circularProgressBarCPUTemp.Text = cpuTemp + "°C";

            circularProgressBarCPULoad.Value = cpuLoad;
            circularProgressBarCPULoad.Text = cpuLoad + "%";

            circularProgressBarGPUTemp.Value = gpuTemp;
            circularProgressBarGPUTemp.Text = gpuTemp + "°C";

            circularProgressBarGPULoad.Value = gpuLoad;
            circularProgressBarGPULoad.Text = gpuLoad + "%";

            circularProgressBarGPURPM.Value = gpuRPM;
            circularProgressBarGPURPM.Text = gpuRPM + "%";

            circularProgressBarRAMUsage.Maximum = ramUsed + ramAvailable;
            circularProgressBarRAMUsage.Value = ramUsed;
            circularProgressBarRAMUsage.Text = ramUsed + "GB";

            circularProgressBarRAMLoad.Value = ramLoad;
            circularProgressBarRAMLoad.Text = ramLoad + "%";

            // Colour coding

            if (cpuTemp > 75)
            {
                circularProgressBarCPUTemp.ProgressColor = Color.Red;
            }

            else if (cpuTemp > 50)
            {
                circularProgressBarCPUTemp.ProgressColor = Color.Orange;
            }

            else
            {
                circularProgressBarCPUTemp.ProgressColor = Color.LimeGreen;
            }

            if (cpuLoad > 75)
            {
                circularProgressBarCPULoad.ProgressColor = Color.Red;
            }

            else if (cpuLoad > 50)
            {
                circularProgressBarCPULoad.ProgressColor = Color.Orange;
            }

            else
            {
                circularProgressBarCPULoad.ProgressColor = Color.LimeGreen;
            }

            if (gpuTemp > 70)
            {
                circularProgressBarGPUTemp.ProgressColor = Color.Red;
            }

            else if (gpuTemp > 50)
            {
                circularProgressBarGPUTemp.ProgressColor = Color.Orange;
            }

            else
            {
                circularProgressBarGPUTemp.ProgressColor = Color.LimeGreen;
            }

            if (gpuLoad > 75)
            {
                circularProgressBarGPULoad.ProgressColor = Color.Red;
            }

            else if (gpuLoad > 50)
            {
                circularProgressBarGPULoad.ProgressColor = Color.Orange;
            }

            else
            {
                circularProgressBarGPULoad.ProgressColor = Color.LimeGreen;
            }

            if (gpuRPM > 75)
            {
                circularProgressBarGPURPM.ProgressColor = Color.Red;
            }

            else if (gpuRPM > 50)
            {
                circularProgressBarGPURPM.ProgressColor = Color.Orange;
            }

            else
            {
                circularProgressBarGPURPM.ProgressColor = Color.LimeGreen;
            }

            if (gpuTemp > 35 && (gpuRPM <= (gpuTemp - tempLimit)))
            {
                groupBoxGPU.ForeColor = Color.Red;
            }

            else
            {
                groupBoxGPU.ForeColor = SystemColors.ControlText;
            }
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveFile();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TempMessageBox msg = new TempMessageBox();
            msg.ShowDialog();

            if (msg.DialogResult == DialogResult.OK)
            {
                tempLimit = msg.GetDiff();
            }
        }
    }
}
