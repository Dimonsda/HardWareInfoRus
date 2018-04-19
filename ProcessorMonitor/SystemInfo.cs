using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SysInfo
{
    class SystemInfo
    {
        public string GPUname {get;set;}
        public string GPUSize { get; set; }
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
    }
}
