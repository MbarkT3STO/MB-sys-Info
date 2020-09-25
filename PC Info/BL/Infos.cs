using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management;
using System.IO;

namespace PC_Info.BL
{
    class Infos
    {

        public static DateTime Get_Current_DATE_and_TIME()
        {
            return DateTime.Now;
        }

        public static ManagementObjectSearcher CPU_Infos()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");

            return searcher;
        }
        
        public static ManagementObjectSearcher GPU_Infos()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController");

            return searcher;
        }

        public static ManagementObjectSearcher RAM_Infos()
        {

            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("Select * From Win32_PhysicalMemory");

            return Searcher;
        }
        
        public static ManagementObjectSearcher System_Infos()
        {

            ManagementObjectSearcher Searcher = new ManagementObjectSearcher("Select * From Win32_OperatingSystem");

            return Searcher;
        }

        public static DriveInfo[] Drives_Infos()
        {

            DriveInfo[] Drives = DriveInfo.GetDrives();

            return Drives;
        }





       

    }
}
