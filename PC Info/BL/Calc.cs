using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Info.BL
{
    class Calc
    {

        /// <summary>
        /// Convert any Number Of Bytes to KB, MB, or GB
        /// </summary>
        /// <returns></returns>
        public static string BytesTo_KMG(ulong Bytes, string Result_Unit = "KB")
        {

            double R = Bytes/1024;

            if (Result_Unit=="GB")
            {
                R = R / 1024 / 1024;
            }
            else if(Result_Unit == "MB")
            {
                R = R / 1024;
            }
            else if(Result_Unit == "T")
            {
                R = R / 1024 / 1024 / 1024;
            }

            return $"{Math.Round(R,2)} {Result_Unit}".Replace("-", "");

        }


        public static string GetMemoryType(byte MemoryType)
        {
            switch (MemoryType)
            {
                case 20:
                    return "DDR";
                case 21:
                    return "DDR-2";
                default:
                    if (MemoryType == 0 || MemoryType > 22)
                        return "DDR-3";
                    else
                        return "Other";

            }
        }



    }
}
