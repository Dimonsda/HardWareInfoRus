using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysInfo
{
    class SystemInfo
    {
        public string GPUname {get;set;}
        public string GPUSize { get; set; }
        public string Ports { get; set; }
        public string Motherboard { get; set; }
        public string MotherboardSerial { get; set; }
        public List<string> portss = new List<string>();
        public List<string> networks = new List<string>();

        //Ниже железо
        public void videocard()
        {
            
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_DisplayConfiguration");

            foreach (ManagementObject queryObj in searcher.Get())
            {
               GPUname = string.Join(" + ", queryObj["Description"]);
            }
        }

        public void videoRAM()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                GPUSize = string.Format("Объём: {0}", Math.Truncate(Convert.ToDouble(queryObj["AdapterRAM"]) / 1024 / 1024)) + "MB";
            }
        }

        public void ports()
        {

            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PortConnector");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                portss.Add(string.Format("Порт: {0} {1}" , queryObj["InternalReferenceDesignator"],Environment.NewLine));
            }

        }

        public void motherboard()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Motherboard = (string.Format("{0} {1} {2}", queryObj["Manufacturer"], queryObj["Product"], queryObj["Version"]) + Environment.NewLine);
                MotherboardSerial = (string.Format("Серийный номер: {0}", queryObj["SerialNumber"]) + Environment.NewLine);
            }

        }

        public void network()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_NetworkAdapter");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                networks.Add(string.Format("{0} : {1}", queryObj["Name"], Math.Truncate(Convert.ToDouble(queryObj["Speed"]) / 1024 / 1024)) + "MB/s");
            }

        }

        public string TotalRam { get; set; }
        public string OsName { get; set; }
        public string CompName { get; set; }
        public string MonitorSize { get; set; }
        public string HDDFree { get; set; }
        public string CoreCount { get; set; }
        public string CoreNumber { get; set; }
        public string Version { get; set; }



        public void wininfo()
        {
            var temper = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            int temp2 = Convert.ToInt32(temper);
            TotalRam = temp2.ToString();

            //Название ОС
            OsName = "ОС: " + new Microsoft.VisualBasic.Devices.ComputerInfo().OSFullName;
            CompName = new Microsoft.VisualBasic.Devices.Computer().Name;

            //Разрешение
            MonitorSize  = "Разрешение: " + SystemInformation.PrimaryMonitorSize.Width.ToString() + " x " + SystemInformation.PrimaryMonitorSize.Height.ToString();

            CoreCount = "Число ядер: " + Convert.ToString(Environment.ProcessorCount);
            CoreNumber = "Ядро: " + Convert.ToString(Environment.OSVersion);
            Version = "Версия: " + Convert.ToString(Environment.Version);
        }
    }
}
