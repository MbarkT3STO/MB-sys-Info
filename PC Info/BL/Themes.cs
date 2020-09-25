using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Info.BL
{
    class Themes
    {

        public virtual string Title_Bar_BgColor { get; set; }
        public virtual string Start_Form_BgColor { get; set; }
        public virtual string Panel_BgColor { get; set; }
        public virtual string Label_BgColor { get; set; }
        public virtual string BTN_BgColor { get; set; }


        public virtual string Fore_Color { get; set; }
        public virtual string User_LBL_Fore_Color { get; set; }
        public virtual string Time_LBL_Fore_Color { get; set; }
        public virtual string Card_Header_Color { get; set; }
        public virtual string Card_Label_Fore_Color { get; set; }
        public virtual string Progress_Bar_Fore_Color { get; set; }


        /// <summary>
        /// Dark Theme Class
        /// </summary>
        public class Dark_Theme : Themes
        {

            
            public override string Title_Bar_BgColor { get { return "#171518"; } }
            public override string Start_Form_BgColor { get { return "#0E0F11"; } }
            public override string Panel_BgColor { get { return "#171518"; } }
            public override string Label_BgColor { get { return "#171518"; } }
            public override string BTN_BgColor { get { return "#171518"; } }
            public override string Fore_Color { get { return "White"; } }
            public override string User_LBL_Fore_Color { get { return "#b2bec3"; } }
            public override string Time_LBL_Fore_Color { get { return "#b2bec3"; } }
            public override string Card_Header_Color { get { return "#10ac84"; } }
            public override string Card_Label_Fore_Color { get { return "White"; } }
            public override string Progress_Bar_Fore_Color { get { return "White"; } }



        }



        /// <summary>
        /// Blue Theme Class
        /// </summary>
        public class Blue_Theme : Themes
        {


            public override string Title_Bar_BgColor { get { return "#5f27cd"; } }
            public override string Start_Form_BgColor { get {return "#341f97"; } }
            public override string Panel_BgColor { get { return "#5f27cd"; } }
            public override string Label_BgColor { get { return "#5f27cd"; } }
            public override string BTN_BgColor { get { return "#5f27cd"; } }
            public override string Fore_Color { get { return "White"; } }
            public override string User_LBL_Fore_Color { get { return "#f1f2f6"; } }
            public override string Time_LBL_Fore_Color { get { return "#f1f2f6"; } }
            public override string Card_Header_Color { get { return "#10ac84"; } }
            public override string Card_Label_Fore_Color { get { return "White"; } }
            public override string Progress_Bar_Fore_Color { get { return "White"; } }



        }




        /// <summary>
        /// Light Theme Class
        /// </summary>
        public class Light_Theme : Themes
        {


            public override string Title_Bar_BgColor { get { return "White"; } }
            public override string Start_Form_BgColor { get {return "#ecf0f1"; } }
            public override string Panel_BgColor { get { return "White"; } }
            public override string Label_BgColor { get { return "White"; } }
            public override string BTN_BgColor { get { return "White"; } }
            public override string Fore_Color { get { return "#222f3e"; } }
            public override string User_LBL_Fore_Color { get { return "#60a3bc"; } }
            public override string Time_LBL_Fore_Color { get { return "#60a3bc"; } }
            public override string Card_Header_Color { get { return "#16a085"; } }
            public override string Card_Label_Fore_Color { get { return "#34495e"; } }
            public override string Progress_Bar_Fore_Color { get { return "#34495e"; } }



        }



        /// <summary>
        /// Get Or Set The Current Theme
        /// </summary>
        public static string Current_Theme
        {

            get { return Properties.Settings.Default.Theme; } 

            set {
                Properties.Settings.Default.Theme = value;
                Properties.Settings.Default.Save(); 
            }

        }



        public static void Apply_Theme(ref Form F)
        {

            if (Themes.Current_Theme == "Blue")
            {
                F.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Start_Form_BgColor);
            }

            MessageBox.Show(Themes.Current_Theme);
        }


    }
}
