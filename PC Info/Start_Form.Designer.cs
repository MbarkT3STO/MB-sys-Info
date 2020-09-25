namespace PC_Info
{
    partial class Start_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.Title_Bar_PNL = new Telerik.WinControls.UI.RadPanel();
            this.Title_Bar_Separator_BTN = new Telerik.WinControls.UI.RadLabel();
            this.Time_LBL = new Telerik.WinControls.UI.RadLabel();
            this.User_LBL = new Telerik.WinControls.UI.RadLabel();
            this.Storage_PNL = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.Drives_LBL = new Telerik.WinControls.UI.RadLabel();
            this.CPU_PNL = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.CPU_LBL = new Telerik.WinControls.UI.RadLabel();
            this.GPU_PNL = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.GPU_LBL = new Telerik.WinControls.UI.RadLabel();
            this.CPU_ProgBAR = new Telerik.WinControls.UI.RadProgressBar();
            this.System_PNL = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.System_LBL = new Telerik.WinControls.UI.RadLabel();
            this.RAM_PNL = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.RAM_LBL = new Telerik.WinControls.UI.RadLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.Usage_PNL = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.RAM_ProgBAR = new Telerik.WinControls.UI.RadProgressBar();
            this.Themes_BTN = new Telerik.WinControls.UI.RadButton();
            this.Infos_BTN = new Telerik.WinControls.UI.RadButton();
            this.Minimize_BTN = new Telerik.WinControls.UI.RadButton();
            this.Exit_BTN = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Bar_PNL)).BeginInit();
            this.Title_Bar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Bar_Separator_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_LBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_LBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storage_PNL)).BeginInit();
            this.Storage_PNL.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drives_LBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PNL)).BeginInit();
            this.CPU_PNL.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_LBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPU_PNL)).BeginInit();
            this.GPU_PNL.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GPU_LBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_ProgBAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_PNL)).BeginInit();
            this.System_PNL.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.System_LBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_PNL)).BeginInit();
            this.RAM_PNL.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_LBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usage_PNL)).BeginInit();
            this.Usage_PNL.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_ProgBAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Themes_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Infos_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Bar_PNL
            // 
            this.Title_Bar_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Bar_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Title_Bar_PNL.Controls.Add(this.Title_Bar_Separator_BTN);
            this.Title_Bar_PNL.Controls.Add(this.Time_LBL);
            this.Title_Bar_PNL.Controls.Add(this.User_LBL);
            this.Title_Bar_PNL.Controls.Add(this.Themes_BTN);
            this.Title_Bar_PNL.Controls.Add(this.Infos_BTN);
            this.Title_Bar_PNL.Controls.Add(this.Minimize_BTN);
            this.Title_Bar_PNL.Controls.Add(this.Exit_BTN);
            this.Title_Bar_PNL.Location = new System.Drawing.Point(-1, -2);
            this.Title_Bar_PNL.Name = "Title_Bar_PNL";
            // 
            // 
            // 
            this.Title_Bar_PNL.RootElement.ApplyShapeToControl = false;
            this.Title_Bar_PNL.RootElement.AutoSize = true;
            this.Title_Bar_PNL.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Title_Bar_PNL.RootElement.BorderHighlightThickness = 0;
            this.Title_Bar_PNL.RootElement.EnableFocusBorderAnimation = false;
            this.Title_Bar_PNL.Size = new System.Drawing.Size(1233, 72);
            this.Title_Bar_PNL.TabIndex = 2;
            this.Title_Bar_PNL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title_Bar_PNL.ThemeName = "Material";
            // 
            // Title_Bar_Separator_BTN
            // 
            this.Title_Bar_Separator_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Bar_Separator_BTN.AutoSize = false;
            this.Title_Bar_Separator_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.Title_Bar_Separator_BTN.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Bar_Separator_BTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.Title_Bar_Separator_BTN.Location = new System.Drawing.Point(578, 15);
            this.Title_Bar_Separator_BTN.Name = "Title_Bar_Separator_BTN";
            this.Title_Bar_Separator_BTN.Size = new System.Drawing.Size(29, 43);
            this.Title_Bar_Separator_BTN.TabIndex = 0;
            this.Title_Bar_Separator_BTN.Text = "|";
            this.Title_Bar_Separator_BTN.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title_Bar_Separator_BTN.ThemeName = "Material";
            // 
            // Time_LBL
            // 
            this.Time_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_LBL.AutoSize = false;
            this.Time_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.Time_LBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.Time_LBL.Location = new System.Drawing.Point(613, 15);
            this.Time_LBL.Name = "Time_LBL";
            this.Time_LBL.Size = new System.Drawing.Size(385, 43);
            this.Time_LBL.TabIndex = 0;
            this.Time_LBL.Text = "12:20";
            this.Time_LBL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Time_LBL.ThemeName = "Material";
            // 
            // User_LBL
            // 
            this.User_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.User_LBL.AutoSize = false;
            this.User_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.User_LBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(176)))));
            this.User_LBL.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.User_LBL.Location = new System.Drawing.Point(13, 15);
            this.User_LBL.Name = "User_LBL";
            this.User_LBL.Size = new System.Drawing.Size(559, 43);
            this.User_LBL.TabIndex = 0;
            this.User_LBL.Text = "User";
            this.User_LBL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.User_LBL.ThemeName = "Material";
            // 
            // Storage_PNL
            // 
            this.Storage_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Storage_PNL.AnimationFrames = 60;
            this.Storage_PNL.AnimationInterval = 5;
            this.Storage_PNL.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            this.Storage_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.Storage_PNL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Storage_PNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.Storage_PNL.HeaderText = "Storage";
            this.Storage_PNL.Location = new System.Drawing.Point(865, 84);
            this.Storage_PNL.Name = "Storage_PNL";
            this.Storage_PNL.OwnerBoundsCache = new System.Drawing.Rectangle(865, 76, 354, 188);
            // 
            // Storage_PNL.PanelContainer
            // 
            this.Storage_PNL.PanelContainer.Controls.Add(this.Drives_LBL);
            this.Storage_PNL.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.Storage_PNL.PanelContainer.Size = new System.Drawing.Size(354, 162);
            this.Storage_PNL.ShowHeaderLine = false;
            this.Storage_PNL.Size = new System.Drawing.Size(354, 188);
            this.Storage_PNL.TabIndex = 3;
            this.Storage_PNL.ThemeName = "Material";
            // 
            // Drives_LBL
            // 
            this.Drives_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Drives_LBL.AutoSize = false;
            this.Drives_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.Drives_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drives_LBL.ForeColor = System.Drawing.Color.White;
            this.Drives_LBL.Location = new System.Drawing.Point(6, 3);
            this.Drives_LBL.Name = "Drives_LBL";
            this.Drives_LBL.Size = new System.Drawing.Size(345, 156);
            this.Drives_LBL.TabIndex = 1;
            this.Drives_LBL.Text = "Drives Infos";
            this.Drives_LBL.ThemeName = "Material";
            // 
            // CPU_PNL
            // 
            this.CPU_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPU_PNL.AnimationFrames = 60;
            this.CPU_PNL.AnimationInterval = 5;
            this.CPU_PNL.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            this.CPU_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.CPU_PNL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU_PNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.CPU_PNL.HeaderText = "CPU";
            this.CPU_PNL.Location = new System.Drawing.Point(12, 84);
            this.CPU_PNL.Name = "CPU_PNL";
            this.CPU_PNL.OwnerBoundsCache = new System.Drawing.Rectangle(865, 76, 354, 188);
            // 
            // CPU_PNL.PanelContainer
            // 
            this.CPU_PNL.PanelContainer.Controls.Add(this.CPU_LBL);
            this.CPU_PNL.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.CPU_PNL.PanelContainer.Size = new System.Drawing.Size(847, 162);
            this.CPU_PNL.ShowHeaderLine = false;
            this.CPU_PNL.Size = new System.Drawing.Size(847, 188);
            this.CPU_PNL.TabIndex = 3;
            this.CPU_PNL.ThemeName = "Material";
            // 
            // CPU_LBL
            // 
            this.CPU_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CPU_LBL.AutoSize = false;
            this.CPU_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.CPU_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU_LBL.ForeColor = System.Drawing.Color.White;
            this.CPU_LBL.Location = new System.Drawing.Point(6, 2);
            this.CPU_LBL.Name = "CPU_LBL";
            this.CPU_LBL.Size = new System.Drawing.Size(838, 157);
            this.CPU_LBL.TabIndex = 0;
            this.CPU_LBL.Text = "12:20";
            this.CPU_LBL.ThemeName = "Material";
            // 
            // GPU_PNL
            // 
            this.GPU_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPU_PNL.AnimationFrames = 60;
            this.GPU_PNL.AnimationInterval = 5;
            this.GPU_PNL.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            this.GPU_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.GPU_PNL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU_PNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.GPU_PNL.HeaderText = "GPU";
            this.GPU_PNL.Location = new System.Drawing.Point(12, 278);
            this.GPU_PNL.Name = "GPU_PNL";
            this.GPU_PNL.OwnerBoundsCache = new System.Drawing.Rectangle(865, 76, 354, 188);
            // 
            // GPU_PNL.PanelContainer
            // 
            this.GPU_PNL.PanelContainer.Controls.Add(this.GPU_LBL);
            this.GPU_PNL.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.GPU_PNL.PanelContainer.Size = new System.Drawing.Size(847, 218);
            this.GPU_PNL.ShowHeaderLine = false;
            this.GPU_PNL.Size = new System.Drawing.Size(847, 244);
            this.GPU_PNL.TabIndex = 4;
            this.GPU_PNL.ThemeName = "Material";
            // 
            // GPU_LBL
            // 
            this.GPU_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GPU_LBL.AutoSize = false;
            this.GPU_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.GPU_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU_LBL.ForeColor = System.Drawing.Color.White;
            this.GPU_LBL.Location = new System.Drawing.Point(6, 3);
            this.GPU_LBL.Name = "GPU_LBL";
            this.GPU_LBL.Size = new System.Drawing.Size(838, 212);
            this.GPU_LBL.TabIndex = 0;
            this.GPU_LBL.Text = "GPU Infos";
            this.GPU_LBL.ThemeName = "Material";
            // 
            // CPU_ProgBAR
            // 
            this.CPU_ProgBAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.CPU_ProgBAR.ForeColor = System.Drawing.Color.White;
            this.CPU_ProgBAR.Location = new System.Drawing.Point(40, 27);
            this.CPU_ProgBAR.Name = "CPU_ProgBAR";
            // 
            // 
            // 
            this.CPU_ProgBAR.RootElement.BorderHighlightThickness = 0;
            this.CPU_ProgBAR.Size = new System.Drawing.Size(376, 51);
            this.CPU_ProgBAR.TabIndex = 6;
            this.CPU_ProgBAR.Text = "CPU Usage";
            this.CPU_ProgBAR.ThemeName = "Material";
            this.CPU_ProgBAR.Value1 = 50;
            // 
            // System_PNL
            // 
            this.System_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.System_PNL.AnimationFrames = 60;
            this.System_PNL.AnimationInterval = 5;
            this.System_PNL.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            this.System_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.System_PNL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.System_PNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.System_PNL.HeaderText = "System";
            this.System_PNL.Location = new System.Drawing.Point(865, 278);
            this.System_PNL.Name = "System_PNL";
            this.System_PNL.OwnerBoundsCache = new System.Drawing.Rectangle(865, 76, 354, 188);
            // 
            // System_PNL.PanelContainer
            // 
            this.System_PNL.PanelContainer.Controls.Add(this.System_LBL);
            this.System_PNL.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.System_PNL.PanelContainer.Size = new System.Drawing.Size(354, 218);
            this.System_PNL.ShowHeaderLine = false;
            this.System_PNL.Size = new System.Drawing.Size(354, 244);
            this.System_PNL.TabIndex = 5;
            this.System_PNL.ThemeName = "Material";
            // 
            // System_LBL
            // 
            this.System_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.System_LBL.AutoSize = false;
            this.System_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.System_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.System_LBL.ForeColor = System.Drawing.Color.White;
            this.System_LBL.Location = new System.Drawing.Point(6, 3);
            this.System_LBL.Name = "System_LBL";
            this.System_LBL.Size = new System.Drawing.Size(345, 212);
            this.System_LBL.TabIndex = 1;
            this.System_LBL.Text = "Windows Infos";
            this.System_LBL.ThemeName = "Material";
            // 
            // RAM_PNL
            // 
            this.RAM_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RAM_PNL.AnimationFrames = 60;
            this.RAM_PNL.AnimationInterval = 5;
            this.RAM_PNL.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            this.RAM_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.RAM_PNL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAM_PNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.RAM_PNL.HeaderText = "RAM";
            this.RAM_PNL.Location = new System.Drawing.Point(865, 528);
            this.RAM_PNL.Name = "RAM_PNL";
            this.RAM_PNL.OwnerBoundsCache = new System.Drawing.Rectangle(865, 76, 354, 188);
            // 
            // RAM_PNL.PanelContainer
            // 
            this.RAM_PNL.PanelContainer.Controls.Add(this.RAM_LBL);
            this.RAM_PNL.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.RAM_PNL.PanelContainer.Size = new System.Drawing.Size(354, 105);
            this.RAM_PNL.ShowHeaderLine = false;
            this.RAM_PNL.Size = new System.Drawing.Size(354, 131);
            this.RAM_PNL.TabIndex = 5;
            this.RAM_PNL.ThemeName = "Material";
            // 
            // RAM_LBL
            // 
            this.RAM_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RAM_LBL.AutoSize = false;
            this.RAM_LBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.RAM_LBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAM_LBL.ForeColor = System.Drawing.Color.White;
            this.RAM_LBL.Location = new System.Drawing.Point(6, 3);
            this.RAM_LBL.Name = "RAM_LBL";
            this.RAM_LBL.Size = new System.Drawing.Size(345, 99);
            this.RAM_LBL.TabIndex = 1;
            this.RAM_LBL.Text = "RAM Infos";
            this.RAM_LBL.ThemeName = "Material";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // Usage_PNL
            // 
            this.Usage_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usage_PNL.AnimationFrames = 60;
            this.Usage_PNL.AnimationInterval = 5;
            this.Usage_PNL.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            this.Usage_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.Usage_PNL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usage_PNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.Usage_PNL.HeaderText = "Usage";
            this.Usage_PNL.Location = new System.Drawing.Point(12, 528);
            this.Usage_PNL.Name = "Usage_PNL";
            this.Usage_PNL.OwnerBoundsCache = new System.Drawing.Rectangle(865, 76, 354, 188);
            // 
            // Usage_PNL.PanelContainer
            // 
            this.Usage_PNL.PanelContainer.Controls.Add(this.RAM_ProgBAR);
            this.Usage_PNL.PanelContainer.Controls.Add(this.CPU_ProgBAR);
            this.Usage_PNL.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.Usage_PNL.PanelContainer.Size = new System.Drawing.Size(847, 105);
            this.Usage_PNL.ShowHeaderLine = false;
            this.Usage_PNL.Size = new System.Drawing.Size(847, 131);
            this.Usage_PNL.TabIndex = 5;
            this.Usage_PNL.ThemeName = "Material";
            // 
            // RAM_ProgBAR
            // 
            this.RAM_ProgBAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.RAM_ProgBAR.ForeColor = System.Drawing.Color.White;
            this.RAM_ProgBAR.Location = new System.Drawing.Point(422, 27);
            this.RAM_ProgBAR.Name = "RAM_ProgBAR";
            this.RAM_ProgBAR.Size = new System.Drawing.Size(376, 51);
            this.RAM_ProgBAR.TabIndex = 7;
            this.RAM_ProgBAR.Text = "RAM Usage";
            this.RAM_ProgBAR.ThemeName = "Material";
            this.RAM_ProgBAR.Value1 = 50;
            // 
            // Themes_BTN
            // 
            this.Themes_BTN.AllowShowFocusCues = false;
            this.Themes_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Themes_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Themes_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Themes_BTN.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.Themes_BTN.EnableGestures = false;
            this.Themes_BTN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Themes_BTN.ForeColor = System.Drawing.Color.Transparent;
            this.Themes_BTN.Image = global::PC_Info.Properties.Resources.Theme_BTN_Light;
            this.Themes_BTN.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Themes_BTN.Location = new System.Drawing.Point(1004, 15);
            this.Themes_BTN.Name = "Themes_BTN";
            // 
            // 
            // 
            this.Themes_BTN.RootElement.BorderHighlightColor = System.Drawing.Color.Transparent;
            this.Themes_BTN.RootElement.BorderHighlightThickness = 0;
            this.Themes_BTN.RootElement.EnableFocusBorderAnimation = false;
            this.Themes_BTN.RootElement.FocusBorderWidth = 0;
            this.Themes_BTN.Size = new System.Drawing.Size(48, 43);
            this.Themes_BTN.TabIndex = 1;
            this.Themes_BTN.Text = "-";
            this.Themes_BTN.ThemeName = "Material";
            this.Themes_BTN.Click += new System.EventHandler(this.Themes_BTN_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.Themes_BTN.GetChildAt(0))).Image = global::PC_Info.Properties.Resources.Theme_BTN_Light;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Themes_BTN.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Themes_BTN.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Themes_BTN.GetChildAt(0))).Text = "-";
            ((Telerik.WinControls.UI.RadButtonElement)(this.Themes_BTN.GetChildAt(0))).FocusBorderWidth = 0;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Themes_BTN.GetChildAt(0))).BorderHighlightThickness = 0;
            // 
            // Infos_BTN
            // 
            this.Infos_BTN.AllowShowFocusCues = false;
            this.Infos_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Infos_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Infos_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Infos_BTN.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.Infos_BTN.EnableGestures = false;
            this.Infos_BTN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Infos_BTN.ForeColor = System.Drawing.Color.Transparent;
            this.Infos_BTN.Image = global::PC_Info.Properties.Resources.icons8_information;
            this.Infos_BTN.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Infos_BTN.Location = new System.Drawing.Point(1058, 15);
            this.Infos_BTN.Name = "Infos_BTN";
            // 
            // 
            // 
            this.Infos_BTN.RootElement.BorderHighlightColor = System.Drawing.Color.Transparent;
            this.Infos_BTN.RootElement.BorderHighlightThickness = 0;
            this.Infos_BTN.RootElement.EnableFocusBorderAnimation = false;
            this.Infos_BTN.RootElement.FocusBorderWidth = 0;
            this.Infos_BTN.Size = new System.Drawing.Size(48, 43);
            this.Infos_BTN.TabIndex = 1;
            this.Infos_BTN.Text = "-";
            this.Infos_BTN.ThemeName = "Material";
            this.Infos_BTN.Click += new System.EventHandler(this.Infos_BTN_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.Infos_BTN.GetChildAt(0))).Image = global::PC_Info.Properties.Resources.icons8_information;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Infos_BTN.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Infos_BTN.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Infos_BTN.GetChildAt(0))).Text = "-";
            ((Telerik.WinControls.UI.RadButtonElement)(this.Infos_BTN.GetChildAt(0))).FocusBorderWidth = 0;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Infos_BTN.GetChildAt(0))).BorderHighlightThickness = 0;
            // 
            // Minimize_BTN
            // 
            this.Minimize_BTN.AllowShowFocusCues = false;
            this.Minimize_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Minimize_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize_BTN.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.Minimize_BTN.EnableGestures = false;
            this.Minimize_BTN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Minimize_BTN.ForeColor = System.Drawing.Color.Transparent;
            this.Minimize_BTN.Image = global::PC_Info.Properties.Resources.icons8_subtract_1;
            this.Minimize_BTN.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Minimize_BTN.Location = new System.Drawing.Point(1112, 14);
            this.Minimize_BTN.Name = "Minimize_BTN";
            // 
            // 
            // 
            this.Minimize_BTN.RootElement.BorderHighlightColor = System.Drawing.Color.Transparent;
            this.Minimize_BTN.RootElement.BorderHighlightThickness = 0;
            this.Minimize_BTN.RootElement.EnableFocusBorderAnimation = false;
            this.Minimize_BTN.RootElement.FocusBorderWidth = 0;
            this.Minimize_BTN.Size = new System.Drawing.Size(48, 43);
            this.Minimize_BTN.TabIndex = 1;
            this.Minimize_BTN.Text = "-";
            this.Minimize_BTN.ThemeName = "Material";
            this.Minimize_BTN.Click += new System.EventHandler(this.Minimize_BTN_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.Minimize_BTN.GetChildAt(0))).Image = global::PC_Info.Properties.Resources.icons8_subtract_1;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Minimize_BTN.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Minimize_BTN.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Minimize_BTN.GetChildAt(0))).Text = "-";
            ((Telerik.WinControls.UI.RadButtonElement)(this.Minimize_BTN.GetChildAt(0))).FocusBorderWidth = 0;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Minimize_BTN.GetChildAt(0))).BorderHighlightThickness = 0;
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.AllowShowFocusCues = false;
            this.Exit_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Exit_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_BTN.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.Exit_BTN.EnableGestures = false;
            this.Exit_BTN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Exit_BTN.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_BTN.Image = global::PC_Info.Properties.Resources.icons8_delete_1;
            this.Exit_BTN.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_BTN.Location = new System.Drawing.Point(1166, 14);
            this.Exit_BTN.Name = "Exit_BTN";
            // 
            // 
            // 
            this.Exit_BTN.RootElement.BorderHighlightColor = System.Drawing.Color.Transparent;
            this.Exit_BTN.RootElement.BorderHighlightThickness = 0;
            this.Exit_BTN.RootElement.EnableFocusBorderAnimation = false;
            this.Exit_BTN.RootElement.FocusBorderWidth = 0;
            this.Exit_BTN.Size = new System.Drawing.Size(54, 43);
            this.Exit_BTN.TabIndex = 1;
            this.Exit_BTN.Text = "-";
            this.Exit_BTN.ThemeName = "Material";
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.Exit_BTN.GetChildAt(0))).Image = global::PC_Info.Properties.Resources.icons8_delete_1;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Exit_BTN.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Exit_BTN.GetChildAt(0))).DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Exit_BTN.GetChildAt(0))).Text = "-";
            ((Telerik.WinControls.UI.RadButtonElement)(this.Exit_BTN.GetChildAt(0))).FocusBorderWidth = 0;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Exit_BTN.GetChildAt(0))).BorderHighlightThickness = 0;
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1231, 671);
            this.Controls.Add(this.Usage_PNL);
            this.Controls.Add(this.RAM_PNL);
            this.Controls.Add(this.System_PNL);
            this.Controls.Add(this.GPU_PNL);
            this.Controls.Add(this.CPU_PNL);
            this.Controls.Add(this.Storage_PNL);
            this.Controls.Add(this.Title_Bar_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start_Form";
            this.Opacity = 0.98D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MB Sys Info";
            this.ThemeName = "Material";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.p);
            this.Load += new System.EventHandler(this.Start_Form_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Start_Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Title_Bar_PNL)).EndInit();
            this.Title_Bar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title_Bar_Separator_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_LBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_LBL)).EndInit();
            this.Storage_PNL.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Storage_PNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drives_LBL)).EndInit();
            this.CPU_PNL.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_LBL)).EndInit();
            this.GPU_PNL.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GPU_PNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPU_LBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_ProgBAR)).EndInit();
            this.System_PNL.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.System_PNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_LBL)).EndInit();
            this.RAM_PNL.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RAM_PNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_LBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.Usage_PNL.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Usage_PNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_ProgBAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Themes_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Infos_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        public Telerik.WinControls.UI.RadButton Exit_BTN;
        public Telerik.WinControls.UI.RadButton Minimize_BTN;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private Telerik.WinControls.UI.RadLabel Title_Bar_Separator_BTN;
        public Telerik.WinControls.UI.RadButton Infos_BTN;
        public Telerik.WinControls.UI.RadButton Themes_BTN;
        public Telerik.WinControls.UI.RadPanel Title_Bar_PNL;
        public Telerik.WinControls.UI.RadCollapsiblePanel Storage_PNL;
        public Telerik.WinControls.UI.RadLabel Time_LBL;
        public Telerik.WinControls.UI.RadCollapsiblePanel CPU_PNL;
        public Telerik.WinControls.UI.RadLabel CPU_LBL;
        public Telerik.WinControls.UI.RadCollapsiblePanel GPU_PNL;
        public Telerik.WinControls.UI.RadLabel GPU_LBL;
        public Telerik.WinControls.UI.RadCollapsiblePanel System_PNL;
        public Telerik.WinControls.UI.RadLabel System_LBL;
        public Telerik.WinControls.UI.RadCollapsiblePanel RAM_PNL;
        public Telerik.WinControls.UI.RadLabel RAM_LBL;
        public Telerik.WinControls.UI.RadLabel User_LBL;
        public Telerik.WinControls.UI.RadProgressBar CPU_ProgBAR;
        public Telerik.WinControls.UI.RadCollapsiblePanel Usage_PNL;
        public Telerik.WinControls.UI.RadProgressBar RAM_ProgBAR;
        public Telerik.WinControls.UI.RadLabel Drives_LBL;
    }
}
