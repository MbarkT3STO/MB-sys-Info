using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Management;


using Telerik.WinControls;using PC_Info.BL;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.Devices;
using System.Security.Principal;
using System.Diagnostics;
using System.IO;
using Telerik.WinControls.UI;

namespace PC_Info
{
    public partial class Start_Form : Telerik.WinControls.UI.RadForm
    {




        public void Apply_Theme()
        {

            Form F = Application.OpenForms[0];

            if (Themes.Current_Theme == "Blue")
            {
                //Form
                F.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Start_Form_BgColor);



                //Title Bar Elements
                Title_Bar_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Title_Bar_BgColor);
                Title_Bar_Separator_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().BTN_BgColor);
                Time_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);
                Time_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Time_LBL_Fore_Color);
                User_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);
                User_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().User_LBL_Fore_Color);

                Exit_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().BTN_BgColor);
                Minimize_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().BTN_BgColor);
                Infos_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().BTN_BgColor);

                Themes_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().BTN_BgColor);
                Themes_BTN.Image = Properties.Resources.Theme_BTN_Dark;



                //Cards (Panels)
                CPU_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Header_Color);
                CPU_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Panel_BgColor);
                CPU_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);
                CPU_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Label_Fore_Color);


                GPU_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Header_Color);
                GPU_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Panel_BgColor);
                GPU_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Label_Fore_Color);
                GPU_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);

                Usage_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Header_Color);
                Usage_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Panel_BgColor);

                Storage_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Panel_BgColor);
                Storage_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Header_Color);
                Drives_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);
                Drives_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Label_Fore_Color);


                System_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Panel_BgColor);
                System_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Header_Color);
                System_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);
                System_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Label_Fore_Color);


                RAM_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Panel_BgColor);
                RAM_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Header_Color);
                RAM_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);
                RAM_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Card_Label_Fore_Color);



                //Progress Bars

                CPU_ProgBAR.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);
                CPU_ProgBAR.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Progress_Bar_Fore_Color);

                RAM_ProgBAR.BackColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Label_BgColor);
                RAM_ProgBAR.ForeColor = ColorTranslator.FromHtml(new Themes.Blue_Theme().Progress_Bar_Fore_Color);


            }
            else if (Themes.Current_Theme == "Dark")
            {







                //Form
                F.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Start_Form_BgColor);



                //Title Bar Elements
                Title_Bar_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Title_Bar_BgColor);
                Title_Bar_Separator_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().BTN_BgColor);
                Time_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);
                Time_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Time_LBL_Fore_Color);
                User_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);
                User_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().User_LBL_Fore_Color);

                Exit_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().BTN_BgColor);
                Minimize_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().BTN_BgColor);
                Infos_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().BTN_BgColor);

                Themes_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().BTN_BgColor);
                Themes_BTN.Image = Properties.Resources.Theme_BTN_Light;



                //Cards (Panels)
                CPU_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Header_Color);
                CPU_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Panel_BgColor);
                CPU_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);
                CPU_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Label_Fore_Color);


                GPU_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Header_Color);
                GPU_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Panel_BgColor);
                GPU_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Label_Fore_Color);
                GPU_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);

                Usage_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Header_Color);
                Usage_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Panel_BgColor);

                Storage_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Panel_BgColor);
                Storage_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Header_Color);
                Drives_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);
                Drives_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Label_Fore_Color);


                System_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Panel_BgColor);
                System_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Header_Color);
                System_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);
                System_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Label_Fore_Color);


                RAM_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Panel_BgColor);
                RAM_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Header_Color);
                RAM_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);
                RAM_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Card_Label_Fore_Color);



                //Progress Bars

                CPU_ProgBAR.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);
                CPU_ProgBAR.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Progress_Bar_Fore_Color);

                RAM_ProgBAR.BackColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Label_BgColor);
                RAM_ProgBAR.ForeColor = ColorTranslator.FromHtml(new Themes.Dark_Theme().Progress_Bar_Fore_Color);






            }
            else if (Themes.Current_Theme == "Light")
            {







                //Form
                F.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Start_Form_BgColor);



                //Title Bar Elements
                Title_Bar_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Title_Bar_BgColor);
                Title_Bar_Separator_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().BTN_BgColor);
                Time_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                Time_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Time_LBL_Fore_Color);
                User_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                User_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().User_LBL_Fore_Color);

                Exit_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().BTN_BgColor);
                Minimize_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().BTN_BgColor);
                Infos_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().BTN_BgColor);

                Themes_BTN.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().BTN_BgColor);
                Themes_BTN.Image = Properties.Resources.Theme_BTN_Blue;



                //Cards (Panels)
                CPU_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Header_Color);
                CPU_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Panel_BgColor);
                CPU_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                CPU_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Label_Fore_Color);

                GPU_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Header_Color);
                GPU_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Panel_BgColor);
                GPU_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                GPU_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Label_Fore_Color);


                Usage_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Header_Color);
                Usage_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Panel_BgColor);

                Storage_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Header_Color);
                Storage_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Panel_BgColor);
                Drives_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                Drives_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Label_Fore_Color);


                System_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Header_Color);
                System_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Panel_BgColor);
                System_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                System_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Label_Fore_Color);


                RAM_PNL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Header_Color);
                RAM_PNL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Panel_BgColor);
                RAM_LBL.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                RAM_LBL.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Card_Label_Fore_Color);



                //Progress Bars

                CPU_ProgBAR.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                CPU_ProgBAR.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Progress_Bar_Fore_Color);


                RAM_ProgBAR.BackColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Label_BgColor);
                RAM_ProgBAR.ForeColor = ColorTranslator.FromHtml(new Themes.Light_Theme().Progress_Bar_Fore_Color);






            }



        }



        public void Apply_Appearence()
        {

            Set_Appearance.BTN_Border(ref Exit_BTN, false);
            Set_Appearance.BTN_Border(ref Minimize_BTN, false);

            Title_Bar_PNL.BackColor = ColorTranslator.FromHtml(Set_Appearance.Title_Bar_BgColor);
            this.BackColor = ColorTranslator.FromHtml(Set_Appearance.Start_Form_BgColor);
            Storage_PNL.BackColor = ColorTranslator.FromHtml(Set_Appearance.Panel_BgColor);



        }



        public void Set_Date_and_Time()
        {

            DateTime DT = Infos.Get_Current_DATE_and_TIME();

            Time_LBL.Text = $"{DT.ToString("hh:mm tt")}";


        }

        public void Set_USER_Infos()
        {


                User_LBL.Text = $"{Environment.UserName}";



        }

        public void Set_CPU_Infos()
        {

            ManagementObjectSearcher CPU_Info = Infos.CPU_Infos();


            foreach (ManagementObject Info in CPU_Info.Get())
            {


                CPU_LBL.Text = $"CPU : {Info["Name"]} \n\n" +
                    $"Cores : {Info["NumberOfCores"]} \n\n" +
                    $"Enabled Cores : {Info["NumberOfEnabledCore"]}";                


            }


        }

        public void Set_GPU_Infos()
        {

            ManagementObjectSearcher GPU = Infos.GPU_Infos();


            foreach (ManagementObject Info in GPU.Get())
            {

                int GPU_RAM_Size = (int)Convert.ToInt64(Info["AdapterRAM"]);
                string GPU_RAM_Size_In_GB = Calc.BytesTo_KMG((ulong)Convert.ToInt64(Info["AdapterRAM"]),"GB");

                GPU_LBL.Text = $"Name : {Info["Name"]} \n\n" +
                    $"Processor : {Info["VideoProcessor"]} \n\n" +
                    $"RAM : {GPU_RAM_Size_In_GB} \n\n" +
                    $"Driver Version : {Info["DriverVersion"]} \n\n" +
                    $"Status : {Info["Status"]}";                


            }


        }

        public void Set_System_Infos()
        {

            ManagementObjectSearcher System_Infos = Infos.System_Infos();

            foreach (ManagementObject Info in System_Infos.Get())
            {

                System_LBL.Text = $"System : {Info["Caption"]} \n\n" +
                    $"Architechture : {Info["OSArchitecture"]} \n\n" +
                    $"Version : {Info["Version"]}";

            }


        }

        public void Set_RAM_Infos()
        {

            ManagementObjectSearcher RAM = Infos.RAM_Infos();

            ulong Total_RAMs_Size = 0;
            byte RAM_Type = 0;

            foreach (ManagementObject Info in RAM.Get())
            {

                 Total_RAMs_Size+= (ulong)Convert.ToInt64(Info["Capacity"]);
                 RAM_Type = byte.Parse(Info["MemoryType"].ToString());



            }

                RAM_LBL.Text = $"Capacity : {Calc.BytesTo_KMG(Total_RAMs_Size,"GB")} \n\n" +
                    $"Type : {Calc.GetMemoryType(RAM_Type)}";

            //RAM_LBL.Text = $"System : { Calc.BytesTo_KMG(new ComputerInfo().TotalPhysicalMemory,"GB")}";


        }



        public void Usage_CPU()
        {

            float CPU_Usage = pCPU.NextValue();

            CPU_ProgBAR.Value1 = (int)CPU_Usage;
            CPU_ProgBAR.Text = $"CPU Usage : {string.Format("{0:0}%",CPU_Usage)}";


            if (CPU_Usage<=10)
            {
                CPU_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#1dd1a1");
            }
            else if (CPU_Usage > 10 && CPU_Usage <= 30)
            {
                CPU_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#10ac84");
            }
            else if (CPU_Usage > 30 && CPU_Usage <= 50)
            {
                CPU_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#fff200");
            }
            else if (CPU_Usage > 50 && CPU_Usage <= 70)
            {
                CPU_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#ff9f1a");
            }
            else if (CPU_Usage > 70)
            {
                CPU_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#ee5253");
            }


        } 
        
        
        public void Usage_RAM()
        {


            float RAM_Usage = pRAM.NextValue();

            RAM_ProgBAR.Value1 = (int)RAM_Usage;
            RAM_ProgBAR.Text = $"RAM Usage : {string.Format("{0:0.00} %",RAM_Usage)}";


            if (RAM_Usage<=10)
            {
                RAM_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#1dd1a1");
            }
            else if (RAM_Usage > 10 && RAM_Usage <= 30)
            {
                RAM_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#10ac84");
            }
            else if (RAM_Usage > 30 && RAM_Usage <= 50)
            {
                RAM_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#fff200");
            }
            else if (RAM_Usage > 50 && RAM_Usage <= 70)
            {
                RAM_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#ff9f1a");
            }
            else if (RAM_Usage > 70)
            {
                RAM_ProgBAR.ProgressBarElement.IndicatorElement1.BackColor = ColorTranslator.FromHtml("#ee5253");
            }


        }



        public void Set_Drives_Infos()
        {

            DriveInfo[] Drives = Infos.Drives_Infos();
            Drives_LBL.Text = "";

            foreach (DriveInfo drive in Drives)
            {


                Drives_LBL.Text += $"{drive.Name.Replace(":\\","")} : {Calc.BytesTo_KMG((ulong)drive.TotalSize,"GB")} | Available [ {Calc.BytesTo_KMG((ulong)drive.AvailableFreeSpace, "GB")} ] \n\n";


            }



        }


        public void Get_Info()
        {

            Set_Date_and_Time();
            Set_USER_Infos();

            Set_CPU_Infos();
            Set_GPU_Infos();
            Set_System_Infos();
            Set_RAM_Infos();
            Set_Drives_Infos();

        }


        //private void set_background(Object sender, PaintEventArgs e)
        //{
        //    Graphics graphics = e.Graphics;

        //    //the rectangle, the same size as our Form
        //    Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

        //    //define gradient's properties
        //    Brush b = new LinearGradientBrush(gradient_rectangle, ColorTranslator.FromHtml("#222f3e"), ColorTranslator.FromHtml("#171518"), 65f);

        //    //apply gradient         
        //    graphics.FillRectangle(b, gradient_rectangle);
        //}


        public Start_Form()
        {
            InitializeComponent();
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Start_Form_Load(object sender, EventArgs e)
        {

            Apply_Appearence();

            Apply_Theme();

            Get_Info();

            timer1.Start();

        }

        private void Minimize_BTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void p(object sender, FormClosedEventArgs e)
        {

        }

        private void Start_Form_Paint(object sender, PaintEventArgs e)
        {
            //this.Paint += new PaintEventHandler(set_background);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Set Datte and Time (Real Time)
            Set_Date_and_Time();

            //Get CPU and RAM usage
            Usage_CPU();
            Usage_RAM();


        }

        private void Infos_BTN_Click(object sender, EventArgs e)
        {
            Process.Start("https://mbark.t3sto.com/");
        }

        private void Themes_BTN_Click(object sender, EventArgs e)
        {
            if (Themes.Current_Theme=="Dark")
            {
                Themes.Current_Theme = "Light";

                Apply_Theme();

            }
            else if(Themes.Current_Theme=="Light")
            {
                Themes.Current_Theme = "Blue";

                Apply_Theme();

            }
            else if(Themes.Current_Theme=="Blue")
            {
                Themes.Current_Theme = "Dark";

                Apply_Theme();

            }
        }
    }
}
