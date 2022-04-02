namespace PanelConfig
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainForm = new Hura_Theme.HuraForm();
            this.Button_Exit = new Hura_Theme.HuraButton();
            this.logInTabControl = new Login_Theme.LogInTabControl();
            this.tabPage_Main = new System.Windows.Forms.TabPage();
            this.AutoStartDelayValue_Numeric = new Login_Theme.LogInNumeric();
            this.AutoStartDelayType_ComboBox = new Login_Theme.LogInComboBox();
            this.logInLabel9 = new Login_Theme.LogInLabel();
            this.ToggleButton_AutoStart = new Login_Theme.LogInOnOffSwitch();
            this.logInLabel8 = new Login_Theme.LogInLabel();
            this.Button_ChangeAccentColor = new System.Windows.Forms.Button();
            this.logInLabel7 = new Login_Theme.LogInLabel();
            this.SensorUpdateInterval_Numeric = new Login_Theme.LogInNumeric();
            this.ScreenTime_Numeric = new Login_Theme.LogInNumeric();
            this.logInLabel6 = new Login_Theme.LogInLabel();
            this.logInLabel5 = new Login_Theme.LogInLabel();
            this.Button_ClosePanel = new Hura_Theme.HuraButton();
            this.Button_StartRestartPanel = new Hura_Theme.HuraButton();
            this.Button_Save = new Hura_Theme.HuraButton();
            this.tabPage_Position = new System.Windows.Forms.TabPage();
            this.logInGroupBox2 = new Login_Theme.LogInGroupBox();
            this.PanelCurrent_PosY = new Login_Theme.LogInNormalTextBox();
            this.PanelCurrent_PosX = new Login_Theme.LogInNormalTextBox();
            this.logInLabel4 = new Login_Theme.LogInLabel();
            this.logInLabel3 = new Login_Theme.LogInLabel();
            this.logInGroupBox1 = new Login_Theme.LogInGroupBox();
            this.PositionY_minus100 = new Hura_Theme.HuraButton();
            this.PositionX_minus100 = new Hura_Theme.HuraButton();
            this.PositionY_minus50 = new Hura_Theme.HuraButton();
            this.PositionX_minus50 = new Hura_Theme.HuraButton();
            this.PositionY_plus100 = new Hura_Theme.HuraButton();
            this.PositionY_minus10 = new Hura_Theme.HuraButton();
            this.PositionX_plus100 = new Hura_Theme.HuraButton();
            this.PositionY_plus50 = new Hura_Theme.HuraButton();
            this.PositionX_minus10 = new Hura_Theme.HuraButton();
            this.PositionY_minus5 = new Hura_Theme.HuraButton();
            this.PositionX_plus50 = new Hura_Theme.HuraButton();
            this.PositionY_plus10 = new Hura_Theme.HuraButton();
            this.PositionX_minus5 = new Hura_Theme.HuraButton();
            this.PositionY_plus5 = new Hura_Theme.HuraButton();
            this.PositionX_plus10 = new Hura_Theme.HuraButton();
            this.PositionX_plus5 = new Hura_Theme.HuraButton();
            this.Button_UseCurrentPosition = new Hura_Theme.HuraButton();
            this.PositionY_Numeric = new Login_Theme.LogInNumeric();
            this.logInLabel2 = new Login_Theme.LogInLabel();
            this.logInLabel1 = new Login_Theme.LogInLabel();
            this.PositionX_Numeric = new Login_Theme.LogInNumeric();
            this.updateCurrentWinPos_Timer = new System.Windows.Forms.Timer(this.components);
            this.MainForm.SuspendLayout();
            this.logInTabControl.SuspendLayout();
            this.tabPage_Main.SuspendLayout();
            this.tabPage_Position.SuspendLayout();
            this.logInGroupBox2.SuspendLayout();
            this.logInGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainForm.ColorScheme = Hura_Theme.HuraForm.ColorSchemes.Dark;
            this.MainForm.Controls.Add(this.Button_Exit);
            this.MainForm.Controls.Add(this.logInTabControl);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MainForm.ForeColor = System.Drawing.Color.White;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(888, 474);
            this.MainForm.TabIndex = 0;
            this.MainForm.Text = "Mario\'s Senor Panel - Config Manager";
            // 
            // Button_Exit
            // 
            this.Button_Exit.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Exit.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.Button_Exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.Location = new System.Drawing.Point(849, 4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(32, 23);
            this.Button_Exit.TabIndex = 0;
            this.Button_Exit.Text = "X";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // logInTabControl
            // 
            this.logInTabControl.ActiveColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.logInTabControl.BackTabColour = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.logInTabControl.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.logInTabControl.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logInTabControl.Controls.Add(this.tabPage_Main);
            this.logInTabControl.Controls.Add(this.tabPage_Position);
            this.logInTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logInTabControl.HorizontalLineColour = System.Drawing.Color.White;
            this.logInTabControl.ItemSize = new System.Drawing.Size(240, 32);
            this.logInTabControl.Location = new System.Drawing.Point(3, 33);
            this.logInTabControl.Name = "logInTabControl";
            this.logInTabControl.SelectedIndex = 0;
            this.logInTabControl.Size = new System.Drawing.Size(882, 438);
            this.logInTabControl.TabIndex = 0;
            this.logInTabControl.TextColour = System.Drawing.Color.White;
            this.logInTabControl.UpLineColour = System.Drawing.Color.White;
            // 
            // tabPage_Main
            // 
            this.tabPage_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.tabPage_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_Main.Controls.Add(this.AutoStartDelayValue_Numeric);
            this.tabPage_Main.Controls.Add(this.AutoStartDelayType_ComboBox);
            this.tabPage_Main.Controls.Add(this.logInLabel9);
            this.tabPage_Main.Controls.Add(this.ToggleButton_AutoStart);
            this.tabPage_Main.Controls.Add(this.logInLabel8);
            this.tabPage_Main.Controls.Add(this.Button_ChangeAccentColor);
            this.tabPage_Main.Controls.Add(this.logInLabel7);
            this.tabPage_Main.Controls.Add(this.SensorUpdateInterval_Numeric);
            this.tabPage_Main.Controls.Add(this.ScreenTime_Numeric);
            this.tabPage_Main.Controls.Add(this.logInLabel6);
            this.tabPage_Main.Controls.Add(this.logInLabel5);
            this.tabPage_Main.Controls.Add(this.Button_ClosePanel);
            this.tabPage_Main.Controls.Add(this.Button_StartRestartPanel);
            this.tabPage_Main.Controls.Add(this.Button_Save);
            this.tabPage_Main.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Main.Name = "tabPage_Main";
            this.tabPage_Main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Main.Size = new System.Drawing.Size(874, 398);
            this.tabPage_Main.TabIndex = 0;
            this.tabPage_Main.Text = "Main";
            // 
            // AutoStartDelayValue_Numeric
            // 
            this.AutoStartDelayValue_Numeric.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.AutoStartDelayValue_Numeric.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AutoStartDelayValue_Numeric.ButtonColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.AutoStartDelayValue_Numeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoStartDelayValue_Numeric.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AutoStartDelayValue_Numeric.Location = new System.Drawing.Point(367, 248);
            this.AutoStartDelayValue_Numeric.Maximum = ((long)(15));
            this.AutoStartDelayValue_Numeric.Minimum = ((long)(1));
            this.AutoStartDelayValue_Numeric.Name = "AutoStartDelayValue_Numeric";
            this.AutoStartDelayValue_Numeric.SecondBorderColour = System.Drawing.Color.White;
            this.AutoStartDelayValue_Numeric.Size = new System.Drawing.Size(109, 24);
            this.AutoStartDelayValue_Numeric.TabIndex = 15;
            this.AutoStartDelayValue_Numeric.Text = "0";
            this.AutoStartDelayValue_Numeric.Value = ((long)(1));
            this.AutoStartDelayValue_Numeric.Click += new System.EventHandler(this.AutoStartDelayValue_Numeric_Click);
            // 
            // AutoStartDelayType_ComboBox
            // 
            this.AutoStartDelayType_ComboBox.ArrowColour = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AutoStartDelayType_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoStartDelayType_ComboBox.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.AutoStartDelayType_ComboBox.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AutoStartDelayType_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AutoStartDelayType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoStartDelayType_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoStartDelayType_ComboBox.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AutoStartDelayType_ComboBox.FormattingEnabled = true;
            this.AutoStartDelayType_ComboBox.Items.AddRange(new object[] {
            "Minutes",
            "Seconds"});
            this.AutoStartDelayType_ComboBox.LineColour = System.Drawing.Color.White;
            this.AutoStartDelayType_ComboBox.Location = new System.Drawing.Point(498, 247);
            this.AutoStartDelayType_ComboBox.Name = "AutoStartDelayType_ComboBox";
            this.AutoStartDelayType_ComboBox.Size = new System.Drawing.Size(163, 26);
            this.AutoStartDelayType_ComboBox.SqaureColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.AutoStartDelayType_ComboBox.SqaureHoverColour = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.AutoStartDelayType_ComboBox.StartIndex = 0;
            this.AutoStartDelayType_ComboBox.TabIndex = 14;
            this.AutoStartDelayType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AutoStartDelayType_ComboBox_SelectedIndexChanged);
            // 
            // logInLabel9
            // 
            this.logInLabel9.AutoSize = true;
            this.logInLabel9.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel9.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel9.Location = new System.Drawing.Point(6, 247);
            this.logInLabel9.Name = "logInLabel9";
            this.logInLabel9.Size = new System.Drawing.Size(355, 25);
            this.logInLabel9.TabIndex = 13;
            this.logInLabel9.Text = "Auto Start after Windows Login Delay:";
            // 
            // ToggleButton_AutoStart
            // 
            this.ToggleButton_AutoStart.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ToggleButton_AutoStart.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ToggleButton_AutoStart.Location = new System.Drawing.Point(367, 203);
            this.ToggleButton_AutoStart.Name = "ToggleButton_AutoStart";
            this.ToggleButton_AutoStart.NonToggledTextColourderColour = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ToggleButton_AutoStart.Size = new System.Drawing.Size(109, 25);
            this.ToggleButton_AutoStart.TabIndex = 12;
            this.ToggleButton_AutoStart.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ToggleButton_AutoStart.Toggled = Login_Theme.LogInOnOffSwitch.Toggles.NotToggled;
            this.ToggleButton_AutoStart.ToggledColour = System.Drawing.Color.Red;
            this.ToggleButton_AutoStart.Click += new System.EventHandler(this.ToggleButton_AutoStart_Click);
            // 
            // logInLabel8
            // 
            this.logInLabel8.AutoSize = true;
            this.logInLabel8.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel8.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel8.Location = new System.Drawing.Point(6, 203);
            this.logInLabel8.Name = "logInLabel8";
            this.logInLabel8.Size = new System.Drawing.Size(110, 25);
            this.logInLabel8.TabIndex = 10;
            this.logInLabel8.Text = "Auto Start:";
            // 
            // Button_ChangeAccentColor
            // 
            this.Button_ChangeAccentColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_ChangeAccentColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ChangeAccentColor.Location = new System.Drawing.Point(367, 126);
            this.Button_ChangeAccentColor.Name = "Button_ChangeAccentColor";
            this.Button_ChangeAccentColor.Size = new System.Drawing.Size(109, 25);
            this.Button_ChangeAccentColor.TabIndex = 9;
            this.Button_ChangeAccentColor.UseVisualStyleBackColor = false;
            this.Button_ChangeAccentColor.Click += new System.EventHandler(this.Button_ChangeAccentColor_Click);
            // 
            // logInLabel7
            // 
            this.logInLabel7.AutoSize = true;
            this.logInLabel7.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel7.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel7.Location = new System.Drawing.Point(6, 124);
            this.logInLabel7.Name = "logInLabel7";
            this.logInLabel7.Size = new System.Drawing.Size(132, 25);
            this.logInLabel7.TabIndex = 8;
            this.logInLabel7.Text = "Accent Color:";
            // 
            // SensorUpdateInterval_Numeric
            // 
            this.SensorUpdateInterval_Numeric.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SensorUpdateInterval_Numeric.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SensorUpdateInterval_Numeric.ButtonColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.SensorUpdateInterval_Numeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorUpdateInterval_Numeric.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SensorUpdateInterval_Numeric.Location = new System.Drawing.Point(367, 16);
            this.SensorUpdateInterval_Numeric.Maximum = ((long)(5));
            this.SensorUpdateInterval_Numeric.Minimum = ((long)(1));
            this.SensorUpdateInterval_Numeric.Name = "SensorUpdateInterval_Numeric";
            this.SensorUpdateInterval_Numeric.SecondBorderColour = System.Drawing.Color.White;
            this.SensorUpdateInterval_Numeric.Size = new System.Drawing.Size(109, 24);
            this.SensorUpdateInterval_Numeric.TabIndex = 7;
            this.SensorUpdateInterval_Numeric.Text = "0";
            this.SensorUpdateInterval_Numeric.Value = ((long)(1));
            this.SensorUpdateInterval_Numeric.Click += new System.EventHandler(this.SensorUpdateInterval_Numeric_Click);
            // 
            // ScreenTime_Numeric
            // 
            this.ScreenTime_Numeric.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ScreenTime_Numeric.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ScreenTime_Numeric.ButtonColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ScreenTime_Numeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTime_Numeric.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ScreenTime_Numeric.Location = new System.Drawing.Point(367, 52);
            this.ScreenTime_Numeric.Maximum = ((long)(30));
            this.ScreenTime_Numeric.Minimum = ((long)(5));
            this.ScreenTime_Numeric.Name = "ScreenTime_Numeric";
            this.ScreenTime_Numeric.SecondBorderColour = System.Drawing.Color.White;
            this.ScreenTime_Numeric.Size = new System.Drawing.Size(109, 24);
            this.ScreenTime_Numeric.TabIndex = 6;
            this.ScreenTime_Numeric.Text = "0";
            this.ScreenTime_Numeric.Value = ((long)(5));
            this.ScreenTime_Numeric.Click += new System.EventHandler(this.ScreenTime_Numeric_Click);
            // 
            // logInLabel6
            // 
            this.logInLabel6.AutoSize = true;
            this.logInLabel6.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel6.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel6.Location = new System.Drawing.Point(6, 51);
            this.logInLabel6.Name = "logInLabel6";
            this.logInLabel6.Size = new System.Drawing.Size(213, 25);
            this.logInLabel6.TabIndex = 4;
            this.logInLabel6.Text = "Screen Time(Seconds):";
            // 
            // logInLabel5
            // 
            this.logInLabel5.AutoSize = true;
            this.logInLabel5.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel5.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel5.Location = new System.Drawing.Point(6, 15);
            this.logInLabel5.Name = "logInLabel5";
            this.logInLabel5.Size = new System.Drawing.Size(310, 25);
            this.logInLabel5.TabIndex = 3;
            this.logInLabel5.Text = "Sensor Update Interval(Seconds):";
            // 
            // Button_ClosePanel
            // 
            this.Button_ClosePanel.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_ClosePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_ClosePanel.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.Button_ClosePanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ClosePanel.ForeColor = System.Drawing.Color.White;
            this.Button_ClosePanel.Location = new System.Drawing.Point(373, 346);
            this.Button_ClosePanel.Name = "Button_ClosePanel";
            this.Button_ClosePanel.Size = new System.Drawing.Size(196, 44);
            this.Button_ClosePanel.TabIndex = 2;
            this.Button_ClosePanel.Text = "Close Panel";
            this.Button_ClosePanel.UseVisualStyleBackColor = false;
            this.Button_ClosePanel.Click += new System.EventHandler(this.Button_ClosePanel_Click);
            // 
            // Button_StartRestartPanel
            // 
            this.Button_StartRestartPanel.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_StartRestartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_StartRestartPanel.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.Button_StartRestartPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StartRestartPanel.ForeColor = System.Drawing.Color.White;
            this.Button_StartRestartPanel.Location = new System.Drawing.Point(171, 346);
            this.Button_StartRestartPanel.Name = "Button_StartRestartPanel";
            this.Button_StartRestartPanel.Size = new System.Drawing.Size(196, 44);
            this.Button_StartRestartPanel.TabIndex = 1;
            this.Button_StartRestartPanel.Text = "Start/Restart Panel";
            this.Button_StartRestartPanel.UseVisualStyleBackColor = false;
            this.Button_StartRestartPanel.Click += new System.EventHandler(this.Button_StartRestartPanel_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Save.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.Button_Save.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.ForeColor = System.Drawing.Color.White;
            this.Button_Save.Location = new System.Drawing.Point(6, 346);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(131, 44);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "SAVE";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // tabPage_Position
            // 
            this.tabPage_Position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.tabPage_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_Position.Controls.Add(this.logInGroupBox2);
            this.tabPage_Position.Controls.Add(this.logInGroupBox1);
            this.tabPage_Position.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Position.Name = "tabPage_Position";
            this.tabPage_Position.Size = new System.Drawing.Size(874, 398);
            this.tabPage_Position.TabIndex = 1;
            this.tabPage_Position.Text = "Position";
            // 
            // logInGroupBox2
            // 
            this.logInGroupBox2.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.logInGroupBox2.Controls.Add(this.PanelCurrent_PosY);
            this.logInGroupBox2.Controls.Add(this.PanelCurrent_PosX);
            this.logInGroupBox2.Controls.Add(this.logInLabel4);
            this.logInGroupBox2.Controls.Add(this.logInLabel3);
            this.logInGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.logInGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.logInGroupBox2.Location = new System.Drawing.Point(4, 230);
            this.logInGroupBox2.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.logInGroupBox2.Name = "logInGroupBox2";
            this.logInGroupBox2.Size = new System.Drawing.Size(864, 162);
            this.logInGroupBox2.TabIndex = 2;
            this.logInGroupBox2.Text = "Panel Window Current Position";
            this.logInGroupBox2.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // PanelCurrent_PosY
            // 
            this.PanelCurrent_PosY.BackColor = System.Drawing.Color.Transparent;
            this.PanelCurrent_PosY.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PanelCurrent_PosY.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelCurrent_PosY.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PanelCurrent_PosY.Location = new System.Drawing.Point(96, 91);
            this.PanelCurrent_PosY.MaxLength = 32767;
            this.PanelCurrent_PosY.Multiline = false;
            this.PanelCurrent_PosY.Name = "PanelCurrent_PosY";
            this.PanelCurrent_PosY.ReadOnly = true;
            this.PanelCurrent_PosY.Size = new System.Drawing.Size(118, 37);
            this.PanelCurrent_PosY.Style = Login_Theme.LogInNormalTextBox.Styles.NotRounded;
            this.PanelCurrent_PosY.TabIndex = 5;
            this.PanelCurrent_PosY.Text = "0";
            this.PanelCurrent_PosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PanelCurrent_PosY.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelCurrent_PosY.UseSystemPasswordChar = false;
            // 
            // PanelCurrent_PosX
            // 
            this.PanelCurrent_PosX.BackColor = System.Drawing.Color.Transparent;
            this.PanelCurrent_PosX.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PanelCurrent_PosX.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PanelCurrent_PosX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PanelCurrent_PosX.Location = new System.Drawing.Point(96, 48);
            this.PanelCurrent_PosX.MaxLength = 32767;
            this.PanelCurrent_PosX.Multiline = false;
            this.PanelCurrent_PosX.Name = "PanelCurrent_PosX";
            this.PanelCurrent_PosX.ReadOnly = true;
            this.PanelCurrent_PosX.Size = new System.Drawing.Size(118, 37);
            this.PanelCurrent_PosX.Style = Login_Theme.LogInNormalTextBox.Styles.NotRounded;
            this.PanelCurrent_PosX.TabIndex = 4;
            this.PanelCurrent_PosX.Text = "0";
            this.PanelCurrent_PosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PanelCurrent_PosX.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelCurrent_PosX.UseSystemPasswordChar = false;
            // 
            // logInLabel4
            // 
            this.logInLabel4.AutoSize = true;
            this.logInLabel4.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel4.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel4.Location = new System.Drawing.Point(22, 101);
            this.logInLabel4.Name = "logInLabel4";
            this.logInLabel4.Size = new System.Drawing.Size(29, 25);
            this.logInLabel4.TabIndex = 3;
            this.logInLabel4.Text = "Y:";
            // 
            // logInLabel3
            // 
            this.logInLabel3.AutoSize = true;
            this.logInLabel3.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel3.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel3.Location = new System.Drawing.Point(22, 56);
            this.logInLabel3.Name = "logInLabel3";
            this.logInLabel3.Size = new System.Drawing.Size(29, 25);
            this.logInLabel3.TabIndex = 2;
            this.logInLabel3.Text = "X:";
            // 
            // logInGroupBox1
            // 
            this.logInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.logInGroupBox1.Controls.Add(this.PositionY_minus100);
            this.logInGroupBox1.Controls.Add(this.PositionX_minus100);
            this.logInGroupBox1.Controls.Add(this.PositionY_minus50);
            this.logInGroupBox1.Controls.Add(this.PositionX_minus50);
            this.logInGroupBox1.Controls.Add(this.PositionY_plus100);
            this.logInGroupBox1.Controls.Add(this.PositionY_minus10);
            this.logInGroupBox1.Controls.Add(this.PositionX_plus100);
            this.logInGroupBox1.Controls.Add(this.PositionY_plus50);
            this.logInGroupBox1.Controls.Add(this.PositionX_minus10);
            this.logInGroupBox1.Controls.Add(this.PositionY_minus5);
            this.logInGroupBox1.Controls.Add(this.PositionX_plus50);
            this.logInGroupBox1.Controls.Add(this.PositionY_plus10);
            this.logInGroupBox1.Controls.Add(this.PositionX_minus5);
            this.logInGroupBox1.Controls.Add(this.PositionY_plus5);
            this.logInGroupBox1.Controls.Add(this.PositionX_plus10);
            this.logInGroupBox1.Controls.Add(this.PositionX_plus5);
            this.logInGroupBox1.Controls.Add(this.Button_UseCurrentPosition);
            this.logInGroupBox1.Controls.Add(this.PositionY_Numeric);
            this.logInGroupBox1.Controls.Add(this.logInLabel2);
            this.logInGroupBox1.Controls.Add(this.logInLabel1);
            this.logInGroupBox1.Controls.Add(this.PositionX_Numeric);
            this.logInGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.logInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.logInGroupBox1.Location = new System.Drawing.Point(4, 3);
            this.logInGroupBox1.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.logInGroupBox1.Name = "logInGroupBox1";
            this.logInGroupBox1.Size = new System.Drawing.Size(864, 221);
            this.logInGroupBox1.TabIndex = 1;
            this.logInGroupBox1.Text = "Panel Window Position";
            this.logInGroupBox1.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // PositionY_minus100
            // 
            this.PositionY_minus100.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionY_minus100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionY_minus100.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionY_minus100.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionY_minus100.ForeColor = System.Drawing.Color.White;
            this.PositionY_minus100.Location = new System.Drawing.Point(627, 111);
            this.PositionY_minus100.Name = "PositionY_minus100";
            this.PositionY_minus100.Size = new System.Drawing.Size(57, 24);
            this.PositionY_minus100.TabIndex = 8;
            this.PositionY_minus100.Text = "-100";
            this.PositionY_minus100.UseVisualStyleBackColor = false;
            this.PositionY_minus100.Click += new System.EventHandler(this.PositionY_minus100_Click);
            // 
            // PositionX_minus100
            // 
            this.PositionX_minus100.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionX_minus100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionX_minus100.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionX_minus100.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionX_minus100.ForeColor = System.Drawing.Color.White;
            this.PositionX_minus100.Location = new System.Drawing.Point(627, 69);
            this.PositionX_minus100.Name = "PositionX_minus100";
            this.PositionX_minus100.Size = new System.Drawing.Size(57, 24);
            this.PositionX_minus100.TabIndex = 8;
            this.PositionX_minus100.Text = "-100";
            this.PositionX_minus100.UseVisualStyleBackColor = false;
            this.PositionX_minus100.Click += new System.EventHandler(this.PositionX_minus100_Click);
            // 
            // PositionY_minus50
            // 
            this.PositionY_minus50.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionY_minus50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionY_minus50.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionY_minus50.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionY_minus50.ForeColor = System.Drawing.Color.White;
            this.PositionY_minus50.Location = new System.Drawing.Point(577, 111);
            this.PositionY_minus50.Name = "PositionY_minus50";
            this.PositionY_minus50.Size = new System.Drawing.Size(44, 24);
            this.PositionY_minus50.TabIndex = 7;
            this.PositionY_minus50.Text = "-50";
            this.PositionY_minus50.UseVisualStyleBackColor = false;
            this.PositionY_minus50.Click += new System.EventHandler(this.PositionY_minus50_Click);
            // 
            // PositionX_minus50
            // 
            this.PositionX_minus50.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionX_minus50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionX_minus50.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionX_minus50.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionX_minus50.ForeColor = System.Drawing.Color.White;
            this.PositionX_minus50.Location = new System.Drawing.Point(577, 69);
            this.PositionX_minus50.Name = "PositionX_minus50";
            this.PositionX_minus50.Size = new System.Drawing.Size(44, 24);
            this.PositionX_minus50.TabIndex = 7;
            this.PositionX_minus50.Text = "-50";
            this.PositionX_minus50.UseVisualStyleBackColor = false;
            this.PositionX_minus50.Click += new System.EventHandler(this.PositionX_minus50_Click);
            // 
            // PositionY_plus100
            // 
            this.PositionY_plus100.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionY_plus100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionY_plus100.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionY_plus100.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionY_plus100.ForeColor = System.Drawing.Color.White;
            this.PositionY_plus100.Location = new System.Drawing.Point(381, 111);
            this.PositionY_plus100.Name = "PositionY_plus100";
            this.PositionY_plus100.Size = new System.Drawing.Size(57, 24);
            this.PositionY_plus100.TabIndex = 8;
            this.PositionY_plus100.Text = "+100";
            this.PositionY_plus100.UseVisualStyleBackColor = false;
            this.PositionY_plus100.Click += new System.EventHandler(this.PositionY_plus100_Click);
            // 
            // PositionY_minus10
            // 
            this.PositionY_minus10.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionY_minus10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionY_minus10.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionY_minus10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionY_minus10.ForeColor = System.Drawing.Color.White;
            this.PositionY_minus10.Location = new System.Drawing.Point(527, 111);
            this.PositionY_minus10.Name = "PositionY_minus10";
            this.PositionY_minus10.Size = new System.Drawing.Size(44, 24);
            this.PositionY_minus10.TabIndex = 6;
            this.PositionY_minus10.Text = "-10";
            this.PositionY_minus10.UseVisualStyleBackColor = false;
            this.PositionY_minus10.Click += new System.EventHandler(this.PositionY_minus10_Click);
            // 
            // PositionX_plus100
            // 
            this.PositionX_plus100.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionX_plus100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionX_plus100.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionX_plus100.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionX_plus100.ForeColor = System.Drawing.Color.White;
            this.PositionX_plus100.Location = new System.Drawing.Point(381, 69);
            this.PositionX_plus100.Name = "PositionX_plus100";
            this.PositionX_plus100.Size = new System.Drawing.Size(57, 24);
            this.PositionX_plus100.TabIndex = 8;
            this.PositionX_plus100.Text = "+100";
            this.PositionX_plus100.UseVisualStyleBackColor = false;
            this.PositionX_plus100.Click += new System.EventHandler(this.PositionX_plus100_Click);
            // 
            // PositionY_plus50
            // 
            this.PositionY_plus50.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionY_plus50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionY_plus50.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionY_plus50.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionY_plus50.ForeColor = System.Drawing.Color.White;
            this.PositionY_plus50.Location = new System.Drawing.Point(331, 111);
            this.PositionY_plus50.Name = "PositionY_plus50";
            this.PositionY_plus50.Size = new System.Drawing.Size(44, 24);
            this.PositionY_plus50.TabIndex = 7;
            this.PositionY_plus50.Text = "+50";
            this.PositionY_plus50.UseVisualStyleBackColor = false;
            this.PositionY_plus50.Click += new System.EventHandler(this.PositionY_plus50_Click);
            // 
            // PositionX_minus10
            // 
            this.PositionX_minus10.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionX_minus10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionX_minus10.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionX_minus10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionX_minus10.ForeColor = System.Drawing.Color.White;
            this.PositionX_minus10.Location = new System.Drawing.Point(527, 69);
            this.PositionX_minus10.Name = "PositionX_minus10";
            this.PositionX_minus10.Size = new System.Drawing.Size(44, 24);
            this.PositionX_minus10.TabIndex = 6;
            this.PositionX_minus10.Text = "-10";
            this.PositionX_minus10.UseVisualStyleBackColor = false;
            this.PositionX_minus10.Click += new System.EventHandler(this.PositionX_minus10_Click);
            // 
            // PositionY_minus5
            // 
            this.PositionY_minus5.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionY_minus5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionY_minus5.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionY_minus5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionY_minus5.ForeColor = System.Drawing.Color.White;
            this.PositionY_minus5.Location = new System.Drawing.Point(477, 111);
            this.PositionY_minus5.Name = "PositionY_minus5";
            this.PositionY_minus5.Size = new System.Drawing.Size(44, 24);
            this.PositionY_minus5.TabIndex = 5;
            this.PositionY_minus5.Text = "-5";
            this.PositionY_minus5.UseVisualStyleBackColor = false;
            this.PositionY_minus5.Click += new System.EventHandler(this.PositionY_minus5_Click);
            // 
            // PositionX_plus50
            // 
            this.PositionX_plus50.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionX_plus50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionX_plus50.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionX_plus50.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionX_plus50.ForeColor = System.Drawing.Color.White;
            this.PositionX_plus50.Location = new System.Drawing.Point(331, 69);
            this.PositionX_plus50.Name = "PositionX_plus50";
            this.PositionX_plus50.Size = new System.Drawing.Size(44, 24);
            this.PositionX_plus50.TabIndex = 7;
            this.PositionX_plus50.Text = "+50";
            this.PositionX_plus50.UseVisualStyleBackColor = false;
            this.PositionX_plus50.Click += new System.EventHandler(this.PositionX_plus50_Click);
            // 
            // PositionY_plus10
            // 
            this.PositionY_plus10.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionY_plus10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionY_plus10.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionY_plus10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionY_plus10.ForeColor = System.Drawing.Color.White;
            this.PositionY_plus10.Location = new System.Drawing.Point(281, 111);
            this.PositionY_plus10.Name = "PositionY_plus10";
            this.PositionY_plus10.Size = new System.Drawing.Size(44, 24);
            this.PositionY_plus10.TabIndex = 6;
            this.PositionY_plus10.Text = "+10";
            this.PositionY_plus10.UseVisualStyleBackColor = false;
            this.PositionY_plus10.Click += new System.EventHandler(this.PositionY_plus10_Click);
            // 
            // PositionX_minus5
            // 
            this.PositionX_minus5.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionX_minus5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionX_minus5.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionX_minus5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionX_minus5.ForeColor = System.Drawing.Color.White;
            this.PositionX_minus5.Location = new System.Drawing.Point(477, 69);
            this.PositionX_minus5.Name = "PositionX_minus5";
            this.PositionX_minus5.Size = new System.Drawing.Size(44, 24);
            this.PositionX_minus5.TabIndex = 5;
            this.PositionX_minus5.Text = "-5";
            this.PositionX_minus5.UseVisualStyleBackColor = false;
            this.PositionX_minus5.Click += new System.EventHandler(this.PositionX_minus5_Click);
            // 
            // PositionY_plus5
            // 
            this.PositionY_plus5.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionY_plus5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionY_plus5.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionY_plus5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionY_plus5.ForeColor = System.Drawing.Color.White;
            this.PositionY_plus5.Location = new System.Drawing.Point(231, 111);
            this.PositionY_plus5.Name = "PositionY_plus5";
            this.PositionY_plus5.Size = new System.Drawing.Size(44, 24);
            this.PositionY_plus5.TabIndex = 5;
            this.PositionY_plus5.Text = "+5";
            this.PositionY_plus5.UseVisualStyleBackColor = false;
            this.PositionY_plus5.Click += new System.EventHandler(this.PositionY_plus5_Click);
            // 
            // PositionX_plus10
            // 
            this.PositionX_plus10.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionX_plus10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionX_plus10.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionX_plus10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionX_plus10.ForeColor = System.Drawing.Color.White;
            this.PositionX_plus10.Location = new System.Drawing.Point(281, 69);
            this.PositionX_plus10.Name = "PositionX_plus10";
            this.PositionX_plus10.Size = new System.Drawing.Size(44, 24);
            this.PositionX_plus10.TabIndex = 6;
            this.PositionX_plus10.Text = "+10";
            this.PositionX_plus10.UseVisualStyleBackColor = false;
            this.PositionX_plus10.Click += new System.EventHandler(this.PositionX_plus10_Click);
            // 
            // PositionX_plus5
            // 
            this.PositionX_plus5.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PositionX_plus5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PositionX_plus5.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.PositionX_plus5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PositionX_plus5.ForeColor = System.Drawing.Color.White;
            this.PositionX_plus5.Location = new System.Drawing.Point(231, 69);
            this.PositionX_plus5.Name = "PositionX_plus5";
            this.PositionX_plus5.Size = new System.Drawing.Size(44, 24);
            this.PositionX_plus5.TabIndex = 5;
            this.PositionX_plus5.Text = "+5";
            this.PositionX_plus5.UseVisualStyleBackColor = false;
            this.PositionX_plus5.Click += new System.EventHandler(this.PositionX_plus5_Click);
            // 
            // Button_UseCurrentPosition
            // 
            this.Button_UseCurrentPosition.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_UseCurrentPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_UseCurrentPosition.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.Button_UseCurrentPosition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Button_UseCurrentPosition.ForeColor = System.Drawing.Color.White;
            this.Button_UseCurrentPosition.Location = new System.Drawing.Point(27, 161);
            this.Button_UseCurrentPosition.Name = "Button_UseCurrentPosition";
            this.Button_UseCurrentPosition.Size = new System.Drawing.Size(231, 46);
            this.Button_UseCurrentPosition.TabIndex = 4;
            this.Button_UseCurrentPosition.Text = "Use Current Position";
            this.Button_UseCurrentPosition.UseVisualStyleBackColor = false;
            this.Button_UseCurrentPosition.Click += new System.EventHandler(this.Button_UseCurrentPosition_Click);
            // 
            // PositionY_Numeric
            // 
            this.PositionY_Numeric.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PositionY_Numeric.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PositionY_Numeric.ButtonColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.PositionY_Numeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionY_Numeric.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PositionY_Numeric.Location = new System.Drawing.Point(96, 111);
            this.PositionY_Numeric.Maximum = ((long)(5000));
            this.PositionY_Numeric.Minimum = ((long)(-5000));
            this.PositionY_Numeric.Name = "PositionY_Numeric";
            this.PositionY_Numeric.SecondBorderColour = System.Drawing.Color.White;
            this.PositionY_Numeric.Size = new System.Drawing.Size(118, 24);
            this.PositionY_Numeric.TabIndex = 3;
            this.PositionY_Numeric.Text = "0";
            this.PositionY_Numeric.Value = ((long)(0));
            this.PositionY_Numeric.Click += new System.EventHandler(this.PositionY_Numeric_Click);
            // 
            // logInLabel2
            // 
            this.logInLabel2.AutoSize = true;
            this.logInLabel2.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel2.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel2.Location = new System.Drawing.Point(22, 110);
            this.logInLabel2.Name = "logInLabel2";
            this.logInLabel2.Size = new System.Drawing.Size(29, 25);
            this.logInLabel2.TabIndex = 2;
            this.logInLabel2.Text = "Y:";
            // 
            // logInLabel1
            // 
            this.logInLabel1.AutoSize = true;
            this.logInLabel1.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.logInLabel1.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel1.Location = new System.Drawing.Point(22, 68);
            this.logInLabel1.Name = "logInLabel1";
            this.logInLabel1.Size = new System.Drawing.Size(29, 25);
            this.logInLabel1.TabIndex = 1;
            this.logInLabel1.Text = "X:";
            // 
            // PositionX_Numeric
            // 
            this.PositionX_Numeric.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PositionX_Numeric.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PositionX_Numeric.ButtonColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.PositionX_Numeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionX_Numeric.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PositionX_Numeric.Location = new System.Drawing.Point(96, 69);
            this.PositionX_Numeric.Maximum = ((long)(5000));
            this.PositionX_Numeric.Minimum = ((long)(-5000));
            this.PositionX_Numeric.Name = "PositionX_Numeric";
            this.PositionX_Numeric.SecondBorderColour = System.Drawing.Color.White;
            this.PositionX_Numeric.Size = new System.Drawing.Size(118, 24);
            this.PositionX_Numeric.TabIndex = 0;
            this.PositionX_Numeric.Text = "0";
            this.PositionX_Numeric.Value = ((long)(0));
            this.PositionX_Numeric.Click += new System.EventHandler(this.PositionX_Numeric_Click);
            // 
            // updateCurrentWinPos_Timer
            // 
            this.updateCurrentWinPos_Timer.Enabled = true;
            this.updateCurrentWinPos_Timer.Interval = 1;
            this.updateCurrentWinPos_Timer.Tick += new System.EventHandler(this.updateCurrentWinPos_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(888, 474);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mario\'s Senor Panel - Config Manager";
            this.MainForm.ResumeLayout(false);
            this.logInTabControl.ResumeLayout(false);
            this.tabPage_Main.ResumeLayout(false);
            this.tabPage_Main.PerformLayout();
            this.tabPage_Position.ResumeLayout(false);
            this.logInGroupBox2.ResumeLayout(false);
            this.logInGroupBox2.PerformLayout();
            this.logInGroupBox1.ResumeLayout(false);
            this.logInGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Hura_Theme.HuraForm MainForm;
        private Login_Theme.LogInTabControl logInTabControl;
        private System.Windows.Forms.TabPage tabPage_Main;
        private System.Windows.Forms.TabPage tabPage_Position;
        private Hura_Theme.HuraButton Button_Exit;
        private Hura_Theme.HuraButton Button_Save;
        private Hura_Theme.HuraButton Button_ClosePanel;
        private Hura_Theme.HuraButton Button_StartRestartPanel;
        private System.Windows.Forms.Timer updateCurrentWinPos_Timer;
        private Login_Theme.LogInNumeric PositionX_Numeric;
        private Login_Theme.LogInGroupBox logInGroupBox2;
        private Login_Theme.LogInGroupBox logInGroupBox1;
        private Login_Theme.LogInNumeric PositionY_Numeric;
        private Login_Theme.LogInLabel logInLabel2;
        private Login_Theme.LogInLabel logInLabel1;
        private Hura_Theme.HuraButton Button_UseCurrentPosition;
        private Login_Theme.LogInLabel logInLabel4;
        private Login_Theme.LogInLabel logInLabel3;
        private Login_Theme.LogInNormalTextBox PanelCurrent_PosY;
        private Login_Theme.LogInNormalTextBox PanelCurrent_PosX;
        private Hura_Theme.HuraButton PositionY_minus100;
        private Hura_Theme.HuraButton PositionX_minus100;
        private Hura_Theme.HuraButton PositionY_minus50;
        private Hura_Theme.HuraButton PositionX_minus50;
        private Hura_Theme.HuraButton PositionY_plus100;
        private Hura_Theme.HuraButton PositionY_minus10;
        private Hura_Theme.HuraButton PositionX_plus100;
        private Hura_Theme.HuraButton PositionY_plus50;
        private Hura_Theme.HuraButton PositionX_minus10;
        private Hura_Theme.HuraButton PositionY_minus5;
        private Hura_Theme.HuraButton PositionX_plus50;
        private Hura_Theme.HuraButton PositionY_plus10;
        private Hura_Theme.HuraButton PositionX_minus5;
        private Hura_Theme.HuraButton PositionY_plus5;
        private Hura_Theme.HuraButton PositionX_plus10;
        private Hura_Theme.HuraButton PositionX_plus5;
        private Login_Theme.LogInLabel logInLabel5;
        private Login_Theme.LogInLabel logInLabel6;
        private Login_Theme.LogInNumeric ScreenTime_Numeric;
        private Login_Theme.LogInNumeric SensorUpdateInterval_Numeric;
        private Login_Theme.LogInLabel logInLabel7;
        private System.Windows.Forms.Button Button_ChangeAccentColor;
        private Login_Theme.LogInLabel logInLabel8;
        private Login_Theme.LogInOnOffSwitch ToggleButton_AutoStart;
        private Login_Theme.LogInLabel logInLabel9;
        private Login_Theme.LogInComboBox AutoStartDelayType_ComboBox;
        private Login_Theme.LogInNumeric AutoStartDelayValue_Numeric;
    }
}

