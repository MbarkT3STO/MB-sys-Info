using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Telerik.WinControls.UI;

namespace PC_Info.BL
{
    class Set_Appearance
    {

        public static string Title_Bar_BgColor { get { return "#171518"; } }
        public static string Start_Form_BgColor { get { return "#0E0F11"; } }
        public static string Panel_BgColor { get { return "#171518"; } }










        //---------------------------------------------------------------------------------------------------------------------------------------------------------







        /// <summary>
        /// Set a RadButton Border state
        /// </summary>
        public static void BTN_Border(ref RadButton Button,bool State)
        {


                Button.ButtonElement.ShowBorder = State;


        }



    }
}
