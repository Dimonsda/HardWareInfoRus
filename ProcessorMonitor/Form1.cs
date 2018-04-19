using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using MetroFramework.Forms;
using CircularProgressBar;
using System.Management;
using System.Threading;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;
using SysInfo;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;


namespace ProcessorMonitor
{
    public partial class Form1 : MetroForm
    {
        SysInfo.SystemInfo info = new SystemInfo();
        public delegate void MyDelegate();

        Computer c = new Computer();

        #region Hardware
        public void hddinfo()
        {
            try
            {
                ManagementObjectSearcher searcher =
                        new ManagementObjectSearcher("root\\Microsoft\\Windows\\Storage",
                        "SELECT * FROM MSFT_PhysicalDisk");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    hddlist.AppendText(string.Format("HDD: {0}", queryObj["FriendlyName"]) + Environment.NewLine + string.Format("Объём: {0}", Math.Truncate(Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024) + " GB" + Environment.NewLine));
                }
            }
            catch { }
        }
        public void raminfo2()
        {

            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PhysicalMemoryArray");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                raznoe.AppendText(string.Format("Максимальный объём: {0}", Convert.ToDouble(queryObj["MaxCapacity"]) / 1024) + "MB" + Environment.NewLine);
                raznoe.AppendText("-----------------------------------------" + Environment.NewLine);
                //raznoe.AppendText(string.Format("Модулей памяти: {0}", queryObj["Use"]) + Environment.NewLine);
            }
        }
        public void raminfo()
        {

            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PhysicalMemory");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                raznoe.AppendText(string.Format("Модуль: {0}", queryObj["DeviceLocator"]) + Environment.NewLine);
                raznoe.AppendText(string.Format("Объём: {0}", Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024) + " MB" + Environment.NewLine);
            }
        }
        public void usbinfo()
        {

            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_USBController");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                usb.AppendText(string.Format("{0}", queryObj["Name"] + Environment.NewLine));
                usb.AppendText("-----------------------------------------" + Environment.NewLine);
            }
        }
        public void proc()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");
            string cpuname;
            foreach (ManagementObject queryObj in searcher.Get())
            {
                //cpuname = queryObj["Name"].ToString();
                //cpusocket.Text = cpuname.Replace(" ", "");
                cpusocket.Text = string.Format("CPU: {0}", queryObj["Name"]);
                Socket.Text = string.Format("Сокет: {0}", queryObj["SocketDesignation"]);
            }
        }
        public void cache()
        {
            List<string> result = new List<string>();
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_CacheMemory");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                result.Add(queryObj["MaxCacheSize"].ToString() + " KB");
            }
            try
            {
                L1Cache.Text = "L1 " + result[0];
                L2Cache.Text = "L2 " + result[1];
                L3Cache.Text = "L3 " + result[2];
            }
            catch { }


        }
        public void ramspeed()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                "SELECT * FROM Win32_PhysicalMemory");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                ramspeedl.Text = string.Format("Частота памяти: {0}", queryObj["Speed"]) + " MHz";
            }

        }
        public void Voltage()
        {
            c.CPUEnabled = true;
            c.MainboardEnabled = true;
            c.Open();

            foreach (var hardware in c.Hardware)
            {
                // This will be in the mainboard
                foreach (var subhardware in hardware.SubHardware)
                {
                    // This will be in the SuperIO
                    subhardware.Update();
                    voltagebox.Clear();
                    if (subhardware.Sensors.Length > 0) // Index out of bounds check
                    {
                        foreach (var sensor in subhardware.Sensors)
                        {
                            // Look for the main fan sensor
                            if (sensor.SensorType == SensorType.Voltage)
                            {
                                voltagebox.AppendText(sensor.Name + " " + sensor.Value + Environment.NewLine);
                            }
                        }
                    }
                }
            }
        }
        public void Hardware()
        {
            try
            {

                List<double> cpulist = new List<double>();
                List<string> gpuprop = new List<string>();
                List<string> gpulist = new List<string>();


                c.Open();
                c.HDDEnabled = true;
                c.FanControllerEnabled = true;
                c.RAMEnabled = true;
                c.GPUEnabled = true;
                c.MainboardEnabled = true;
                c.CPUEnabled = true;


                foreach (var hardware in c.Hardware)
                {
                    switch (hardware.HardwareType)
                    {

                        case HardwareType.CPU:
                            hardware.Update();
                            //testbox.Clear();

                            foreach (var sensors in hardware.Sensors)
                            {

                                if (sensors.SensorType == SensorType.Temperature)
                                {
                                    tempcpu.Text = (sensors.Value.GetValueOrDefault() + "°C");
                                    circularProgressBar3.Value = (int)sensors.Value;
                                }
                            }
                            foreach (var sensors in hardware.Sensors)
                            {
                                if (sensors.SensorType == SensorType.Clock)
                                {
                                    cpulist.Add(Convert.ToDouble(sensors.Value.GetValueOrDefault().ToString()));
                                }
                            }
                            try
                            {
                                cpuclock.Text = Math.Truncate(cpulist[0]).ToString() + " MHz";
                                var rnclock = cpulist[0] / (cpulist[cpulist.Count - 1]);
                                var clock = Math.Round(rnclock);
                                Multipl.Text = "Множитель: " + clock;
                            }
                            catch { }
                            break;

                        case HardwareType.GpuNvidia:
                            hardware.Update();
                            if (hardware.HardwareType == HardwareType.GpuNvidia)
                            {
                                hardware.Update();
                                //gpuname.Text = hardware.Name;
                                foreach (var sensors in hardware.Sensors)
                                {
                                    if (sensors.SensorType == SensorType.Fan)
                                    {
                                        gpufanspeed.Text = (sensors.Value.GetValueOrDefault() + "RPM");
                                    }
                                    if (sensors.SensorType == SensorType.Clock)
                                    {
                                        gpuprop.Add(sensors.Name + ": " + Math.Round(Convert.ToDouble(sensors.Value.GetValueOrDefault())));
                                        try
                                        {
                                            //testbox.Text = string.Join(" + ", hardware.Name);
                                            gpucore.Text = (gpuprop[0] + " MHz");
                                            gpushader.Text = (gpuprop[2] + " MHz");
                                            gpumemory.Text = (gpuprop[1] + " MHz");
                                        }
                                        catch { }

                                    }

                                }
                            }
                            foreach (var sensors in hardware.Sensors)
                            {
                                if (sensors.SensorType == SensorType.Temperature)
                                {
                                    tempgpu.Text = (sensors.Value.GetValueOrDefault() + "°C");
                                    if (sensors.Max.GetValueOrDefault() > 60)
                                    {
                                        circularProgressBar3.ProgressColor = Color.Red;
                                    }
                                }
                            }
                            break;

                        case HardwareType.GpuAti:
                            hardware.Update();

                            if (hardware.HardwareType == HardwareType.GpuAti)
                            {
                                hardware.Update();
                                gpulist.Add(hardware.Name);
                                foreach (var sensors in hardware.Sensors)
                                {
                                    if (sensors.SensorType == SensorType.Fan)
                                    {
                                        gpufanspeed.Text = (sensors.Value.GetValueOrDefault() + "RPM");
                                    }
                                    if (sensors.SensorType == SensorType.Clock)
                                    {
                                        gpuprop.Add(sensors.Name + ": " + Math.Round(Convert.ToDouble(sensors.Value.GetValueOrDefault())));

                                        try
                                        {
                                            gpucore.Text = (gpuprop[0] + " MHz");
                                            gpushader.Text = (gpuprop[2] + " MHz");
                                            gpumemory.Text = (gpuprop[1] + " MHz");
                                            gpuname.Text = (string.Join(" + ", gpulist));
                                        }
                                        catch { }
                                    }
                                }
                            }
                            break;
                        case HardwareType.HDD:
                            break;
                        case HardwareType.Mainboard:

                            foreach (var subhardware in hardware.SubHardware)
                            {
                                // This will be in the SuperIO
                                subhardware.Update();
                                if (subhardware.Sensors.Length > 0) // Index out of bounds check
                                {
                                    foreach (var sensor in subhardware.Sensors)
                                    {
                                        // Look for the main fan sensor
                                        if (sensor.SensorType == SensorType.Fan)
                                        {
                                            CpuRPM.Text = ("CPU Fan Speed: " + Math.Round(Convert.ToDouble(sensor.Value.GetValueOrDefault())) + " RPM");
                                        }
                                    }
                                }
                            }
                            break;
                        case HardwareType.RAM:
                            break;
                    }
                }
            }
            catch { }
        }


        public void readclass()
        {
            info.ports();
            info.videocard();
            info.motherboard();
            info.videoRAM();
            info.network();
            info.wininfo();

            PCname.Text = info.OsName;

            gpuname.Text = info.GPUname;
            gpuramsize.Text = info.GPUSize;


            Ports.AppendText(string.Join("------------------------------------------------------------------------------------" + Environment.NewLine, info.portss));
            Motherboard.Text = (info.Motherboard + Environment.NewLine + info.MotherboardSerial);

            Network.AppendText(string.Join(Environment.NewLine + "------------------------------------------------------------------------------------" + Environment.NewLine, info.networks));

            osname.Text = info.OsName;

            MonitorSize.Text = info.MonitorSize;

            Corecount.Text = info.CoreCount;

            osnumber.Text = info.CoreNumber;

            PCname.Text = info.PCname;

            allram.Text = info.TotalRam;

        }

        public void wininfo()
        {
            //HDD
            HDD.Text = "Свободно " + (Hddinfo1.NextValue()).ToString("00.##") + "%";
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            //Потоки
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BeginInvoke(new MyDelegate(Hardware));
            BeginInvoke(new MyDelegate(Voltage));

            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BeginInvoke(new MyDelegate(readclass));
            BeginInvoke(new MyDelegate(hddinfo));
            BeginInvoke(new MyDelegate(cache));
            BeginInvoke(new MyDelegate(proc));
            BeginInvoke(new MyDelegate(ramspeed));
            BeginInvoke(new MyDelegate(wininfo));
            BeginInvoke(new MyDelegate(raminfo2));
            BeginInvoke(new MyDelegate(raminfo));
            BeginInvoke(new MyDelegate(usbinfo));

            backgroundWorker2.CancelAsync();
        }


        public void timer1_Tick(object sender, EventArgs e)
        {
            loading.Enabled = false;
            loading.Visible = false;
            info.time();
            time.Text = info.Time;

            //Проц и оператива
            circularProgressBar1.Value = (int)(pcProcessor.NextValue());
            cpuusage.Text = circularProgressBar1.Value.ToString() + "%";

            lblProcessor.Text = "Загрузка процессора: " + circularProgressBar1.Value.ToString() + "%";

            lblMemoryAvailable.Text = ((int)pcMemoryAvailable.NextValue()).ToString();
            circularProgressBar2.Value = (int)Memory.NextValue();

            ramproc.Text = Math.Truncate(Memory.NextValue()).ToString() + "%";

            HDDspeed.Text = (Hddinfo2.NextValue() / 1024 / 1024).ToString("0.###") + " MB/sec";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Voltage();
            Hardware();
        }
    }
}