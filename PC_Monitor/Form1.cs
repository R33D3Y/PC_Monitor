﻿using OpenHardwareMonitor.Hardware;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Windows.Forms;

namespace PC_Monitor
{
    public partial class MainScreen : Form
    {
        private Computer computer;
        private ManagementObjectSearcher mos;
        private PerformanceCounter diskReadsPerSec = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
        private PerformanceCounter diskWritesPerSec = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");

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

            UpdateVisuals();

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {   
            UpdateVisuals();

            labelRead.Text = ((diskReadsPerSec.NextValue() / 1024) / 1024).ToString("0.00") + "MB/s";
            labelWrite.Text = ((diskWritesPerSec.NextValue() / 1024) / 1024).ToString("0.00") + "MB/s";
        }

        private void UpdateVisuals()
        {
            int cpuTemp = 0; // Not Found
            int gpuTemp = 0;

            int cpuLoad = 0;
            int gpuLoad = 0;

            int cpuRPM = 0; // Not Found
            int gpuRPM = 0;

            int ramLoad = 0;
            int ramUsed = 0;
            int ramAvailable = 0;

            int hddTemp = 0;
            int hddLoad = 0;

            //ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\cimv2");
            //SelectQuery query = new SelectQuery("SELECT * FROM Win32_Fan");
            //mos = new ManagementObjectSearcher(scope, query);

            //foreach (ManagementObject mo in mos.Get())
            //{
            //    //Console.WriteLine(mo.ToString());

            //    foreach (PropertyData pd in mo.Properties)
            //    {
            //        if (pd.Name == "DesiredSpeed")
            //        {
            //            Console.WriteLine("{0}: {1}", pd.Name, pd.Value);
            //        }

            //        foreach (QualifierData qd in pd.Qualifiers)
            //        {
            //            //Console.WriteLine(qd.Value);
            //        }
            //    }
            //}


            //ManagementObjectCollection disk = mos.Get();
            
            //foreach (ManagementObject mo in disk)
            //{
            //    foreach (PropertyData prop in mo.Properties)
            //    {
            //        Console.WriteLine("{0}: {1}", prop.Name, prop.Value);
            //    }
            //}

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
                    hddTemp = (int)hardware.Sensors[0].Value;
                    hddLoad = (int)hardware.Sensors[1].Value;
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

            circularProgressBarHDDTemp.Value = hddTemp;
            circularProgressBarHDDTemp.Text = hddTemp + "°C";

            circularProgressBarHDDLoad.Value = hddLoad;
            circularProgressBarHDDLoad.Text = hddLoad + "%";

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
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveFile();
        }
    }
}