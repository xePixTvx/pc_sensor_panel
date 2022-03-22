namespace PanelViewer
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
            this.GroupBox_Intro = new Login_Theme.LogInGroupBox();
            this.intro_progress_value = new Login_Theme.LogInLabel();
            this.intro_progress = new Login_Theme.LogInProgressBar();
            this.intro_title = new Login_Theme.LogInLabel();
            this.GroupBox_GPU = new Login_Theme.LogInGroupBox();
            this.gpu_usage_progress_value = new Login_Theme.LogInLabel();
            this.gpu_usage_progress = new Login_Theme.LogInProgressBar();
            this.gpu_text_usage = new Login_Theme.LogInLabel();
            this.gpu_celsius_mainTemp = new Login_Theme.LogInLabel();
            this.gpu_text_mainTemp = new Login_Theme.LogInLabel();
            this.gpu_mainTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.gpu_info_name = new Login_Theme.LogInLabel();
            this.GroupBox_MOBO = new Login_Theme.LogInGroupBox();
            this.mobo_celsius_chipTemp = new Login_Theme.LogInLabel();
            this.mobo_celsius_mainTemp = new Login_Theme.LogInLabel();
            this.mobo_text_chipTemp = new Login_Theme.LogInLabel();
            this.mobo_text_mainTemp = new Login_Theme.LogInLabel();
            this.mobo_text_biosVersion = new Login_Theme.LogInLabel();
            this.mobo_info_biosVersion = new Login_Theme.LogInLabel();
            this.mobo_chipTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.mobo_mainTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.mobo_info_name = new Login_Theme.LogInLabel();
            this.GroupBox_CPU = new Login_Theme.LogInGroupBox();
            this.cpu_usage_progress_value = new Login_Theme.LogInLabel();
            this.cpu_usage_progress = new Login_Theme.LogInProgressBar();
            this.cpu_text_usage = new Login_Theme.LogInLabel();
            this.cpu_info_name = new Login_Theme.LogInLabel();
            this.cpu_text_diodeTemp = new Login_Theme.LogInLabel();
            this.cpu_text_mainTemp = new Login_Theme.LogInLabel();
            this.cpu_celsius_diodeTemp = new Login_Theme.LogInLabel();
            this.cpu_celsius_mainTemp = new Login_Theme.LogInLabel();
            this.cpu_diodeTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.cpu_mainTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.intro_timer = new System.Windows.Forms.Timer(this.components);
            this.nextScreen_Timer = new System.Windows.Forms.Timer(this.components);
            this.sensorUpdate_Timer = new System.Windows.Forms.Timer(this.components);
            this.MainForm.SuspendLayout();
            this.GroupBox_Intro.SuspendLayout();
            this.GroupBox_GPU.SuspendLayout();
            this.GroupBox_MOBO.SuspendLayout();
            this.GroupBox_CPU.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainForm.ColorScheme = Hura_Theme.HuraForm.ColorSchemes.Dark;
            this.MainForm.Controls.Add(this.GroupBox_Intro);
            this.MainForm.Controls.Add(this.GroupBox_GPU);
            this.MainForm.Controls.Add(this.GroupBox_MOBO);
            this.MainForm.Controls.Add(this.GroupBox_CPU);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MainForm.ForeColor = System.Drawing.Color.White;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(800, 480);
            this.MainForm.TabIndex = 0;
            this.MainForm.Text = "USER:";
            // 
            // GroupBox_Intro
            // 
            this.GroupBox_Intro.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GroupBox_Intro.Controls.Add(this.intro_progress_value);
            this.GroupBox_Intro.Controls.Add(this.intro_progress);
            this.GroupBox_Intro.Controls.Add(this.intro_title);
            this.GroupBox_Intro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GroupBox_Intro.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.GroupBox_Intro.Location = new System.Drawing.Point(1000, 34);
            this.GroupBox_Intro.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.GroupBox_Intro.Name = "GroupBox_Intro";
            this.GroupBox_Intro.Size = new System.Drawing.Size(794, 443);
            this.GroupBox_Intro.TabIndex = 3;
            this.GroupBox_Intro.Text = "Intro:";
            this.GroupBox_Intro.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // intro_progress_value
            // 
            this.intro_progress_value.BackColor = System.Drawing.Color.Transparent;
            this.intro_progress_value.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro_progress_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intro_progress_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intro_progress_value.Location = new System.Drawing.Point(203, 227);
            this.intro_progress_value.Name = "intro_progress_value";
            this.intro_progress_value.Size = new System.Drawing.Size(386, 36);
            this.intro_progress_value.TabIndex = 2;
            this.intro_progress_value.Text = "0%";
            this.intro_progress_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intro_progress
            // 
            this.intro_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.intro_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.intro_progress.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.intro_progress.Location = new System.Drawing.Point(203, 194);
            this.intro_progress.Maximum = 100;
            this.intro_progress.Name = "intro_progress";
            this.intro_progress.ProgressColour = System.Drawing.Color.White;
            this.intro_progress.SecondColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(184)))));
            this.intro_progress.Size = new System.Drawing.Size(386, 25);
            this.intro_progress.TabIndex = 1;
            this.intro_progress.Text = "logInProgressBar1";
            this.intro_progress.TwoColour = false;
            this.intro_progress.Value = 0;
            // 
            // intro_title
            // 
            this.intro_title.BackColor = System.Drawing.Color.Transparent;
            this.intro_title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro_title.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intro_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intro_title.Location = new System.Drawing.Point(203, 150);
            this.intro_title.Name = "intro_title";
            this.intro_title.Size = new System.Drawing.Size(386, 41);
            this.intro_title.TabIndex = 0;
            this.intro_title.Text = "Mario\'s Sensor Panel";
            this.intro_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox_GPU
            // 
            this.GroupBox_GPU.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GroupBox_GPU.Controls.Add(this.gpu_usage_progress_value);
            this.GroupBox_GPU.Controls.Add(this.gpu_usage_progress);
            this.GroupBox_GPU.Controls.Add(this.gpu_text_usage);
            this.GroupBox_GPU.Controls.Add(this.gpu_celsius_mainTemp);
            this.GroupBox_GPU.Controls.Add(this.gpu_text_mainTemp);
            this.GroupBox_GPU.Controls.Add(this.gpu_mainTemp_progress);
            this.GroupBox_GPU.Controls.Add(this.gpu_info_name);
            this.GroupBox_GPU.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GroupBox_GPU.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.GroupBox_GPU.Location = new System.Drawing.Point(1000, 34);
            this.GroupBox_GPU.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.GroupBox_GPU.Name = "GroupBox_GPU";
            this.GroupBox_GPU.Size = new System.Drawing.Size(794, 443);
            this.GroupBox_GPU.TabIndex = 2;
            this.GroupBox_GPU.Text = "GPU:";
            this.GroupBox_GPU.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // gpu_usage_progress_value
            // 
            this.gpu_usage_progress_value.BackColor = System.Drawing.Color.Transparent;
            this.gpu_usage_progress_value.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_usage_progress_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_usage_progress_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_usage_progress_value.Location = new System.Drawing.Point(731, 400);
            this.gpu_usage_progress_value.Name = "gpu_usage_progress_value";
            this.gpu_usage_progress_value.Size = new System.Drawing.Size(63, 25);
            this.gpu_usage_progress_value.TabIndex = 17;
            this.gpu_usage_progress_value.Text = "0%";
            this.gpu_usage_progress_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpu_usage_progress
            // 
            this.gpu_usage_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gpu_usage_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gpu_usage_progress.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gpu_usage_progress.Location = new System.Drawing.Point(105, 400);
            this.gpu_usage_progress.Maximum = 100;
            this.gpu_usage_progress.Name = "gpu_usage_progress";
            this.gpu_usage_progress.ProgressColour = System.Drawing.Color.White;
            this.gpu_usage_progress.SecondColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(184)))));
            this.gpu_usage_progress.Size = new System.Drawing.Size(620, 25);
            this.gpu_usage_progress.TabIndex = 16;
            this.gpu_usage_progress.Text = "logInProgressBar1";
            this.gpu_usage_progress.TwoColour = false;
            this.gpu_usage_progress.Value = 0;
            // 
            // gpu_text_usage
            // 
            this.gpu_text_usage.BackColor = System.Drawing.Color.Transparent;
            this.gpu_text_usage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_text_usage.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_text_usage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_text_usage.Location = new System.Drawing.Point(9, 400);
            this.gpu_text_usage.Name = "gpu_text_usage";
            this.gpu_text_usage.Size = new System.Drawing.Size(90, 25);
            this.gpu_text_usage.TabIndex = 15;
            this.gpu_text_usage.Text = "USAGE:";
            this.gpu_text_usage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpu_celsius_mainTemp
            // 
            this.gpu_celsius_mainTemp.BackColor = System.Drawing.Color.Transparent;
            this.gpu_celsius_mainTemp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_celsius_mainTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_celsius_mainTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_celsius_mainTemp.Location = new System.Drawing.Point(480, 227);
            this.gpu_celsius_mainTemp.Name = "gpu_celsius_mainTemp";
            this.gpu_celsius_mainTemp.Size = new System.Drawing.Size(38, 28);
            this.gpu_celsius_mainTemp.TabIndex = 14;
            this.gpu_celsius_mainTemp.Text = "C°";
            this.gpu_celsius_mainTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpu_text_mainTemp
            // 
            this.gpu_text_mainTemp.BackColor = System.Drawing.Color.Transparent;
            this.gpu_text_mainTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_text_mainTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_text_mainTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_text_mainTemp.Location = new System.Drawing.Point(358, 302);
            this.gpu_text_mainTemp.Name = "gpu_text_mainTemp";
            this.gpu_text_mainTemp.Size = new System.Drawing.Size(113, 23);
            this.gpu_text_mainTemp.TabIndex = 12;
            this.gpu_text_mainTemp.Text = "Main Temp";
            // 
            // gpu_mainTemp_progress
            // 
            this.gpu_mainTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.gpu_mainTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gpu_mainTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gpu_mainTemp_progress.Location = new System.Drawing.Point(268, 97);
            this.gpu_mainTemp_progress.Maximum = 100;
            this.gpu_mainTemp_progress.Name = "gpu_mainTemp_progress";
            this.gpu_mainTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.gpu_mainTemp_progress.RotationAngle = 255;
            this.gpu_mainTemp_progress.Size = new System.Drawing.Size(250, 228);
            this.gpu_mainTemp_progress.StartingAngle = 110;
            this.gpu_mainTemp_progress.TabIndex = 8;
            this.gpu_mainTemp_progress.Text = "logInRadialProgressBar1";
            this.gpu_mainTemp_progress.Value = 0;
            // 
            // gpu_info_name
            // 
            this.gpu_info_name.BackColor = System.Drawing.Color.Transparent;
            this.gpu_info_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_info_name.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_info_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_info_name.Location = new System.Drawing.Point(0, 40);
            this.gpu_info_name.Name = "gpu_info_name";
            this.gpu_info_name.Size = new System.Drawing.Size(791, 46);
            this.gpu_info_name.TabIndex = 7;
            this.gpu_info_name.Text = "GPU NAME";
            this.gpu_info_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox_MOBO
            // 
            this.GroupBox_MOBO.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GroupBox_MOBO.Controls.Add(this.mobo_celsius_chipTemp);
            this.GroupBox_MOBO.Controls.Add(this.mobo_celsius_mainTemp);
            this.GroupBox_MOBO.Controls.Add(this.mobo_text_chipTemp);
            this.GroupBox_MOBO.Controls.Add(this.mobo_text_mainTemp);
            this.GroupBox_MOBO.Controls.Add(this.mobo_text_biosVersion);
            this.GroupBox_MOBO.Controls.Add(this.mobo_info_biosVersion);
            this.GroupBox_MOBO.Controls.Add(this.mobo_chipTemp_progress);
            this.GroupBox_MOBO.Controls.Add(this.mobo_mainTemp_progress);
            this.GroupBox_MOBO.Controls.Add(this.mobo_info_name);
            this.GroupBox_MOBO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GroupBox_MOBO.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.GroupBox_MOBO.Location = new System.Drawing.Point(1000, 34);
            this.GroupBox_MOBO.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.GroupBox_MOBO.Name = "GroupBox_MOBO";
            this.GroupBox_MOBO.Size = new System.Drawing.Size(794, 443);
            this.GroupBox_MOBO.TabIndex = 1;
            this.GroupBox_MOBO.Text = "Mainboard:";
            this.GroupBox_MOBO.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // mobo_celsius_chipTemp
            // 
            this.mobo_celsius_chipTemp.BackColor = System.Drawing.Color.Transparent;
            this.mobo_celsius_chipTemp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_celsius_chipTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_celsius_chipTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_celsius_chipTemp.Location = new System.Drawing.Point(623, 227);
            this.mobo_celsius_chipTemp.Name = "mobo_celsius_chipTemp";
            this.mobo_celsius_chipTemp.Size = new System.Drawing.Size(38, 28);
            this.mobo_celsius_chipTemp.TabIndex = 15;
            this.mobo_celsius_chipTemp.Text = "C°";
            this.mobo_celsius_chipTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobo_celsius_mainTemp
            // 
            this.mobo_celsius_mainTemp.BackColor = System.Drawing.Color.Transparent;
            this.mobo_celsius_mainTemp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_celsius_mainTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_celsius_mainTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_celsius_mainTemp.Location = new System.Drawing.Point(357, 227);
            this.mobo_celsius_mainTemp.Name = "mobo_celsius_mainTemp";
            this.mobo_celsius_mainTemp.Size = new System.Drawing.Size(38, 28);
            this.mobo_celsius_mainTemp.TabIndex = 14;
            this.mobo_celsius_mainTemp.Text = "C°";
            this.mobo_celsius_mainTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobo_text_chipTemp
            // 
            this.mobo_text_chipTemp.BackColor = System.Drawing.Color.Transparent;
            this.mobo_text_chipTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_text_chipTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_text_chipTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_text_chipTemp.Location = new System.Drawing.Point(504, 302);
            this.mobo_text_chipTemp.Name = "mobo_text_chipTemp";
            this.mobo_text_chipTemp.Size = new System.Drawing.Size(130, 23);
            this.mobo_text_chipTemp.TabIndex = 13;
            this.mobo_text_chipTemp.Text = "Chipset Temp";
            // 
            // mobo_text_mainTemp
            // 
            this.mobo_text_mainTemp.BackColor = System.Drawing.Color.Transparent;
            this.mobo_text_mainTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_text_mainTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_text_mainTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_text_mainTemp.Location = new System.Drawing.Point(239, 302);
            this.mobo_text_mainTemp.Name = "mobo_text_mainTemp";
            this.mobo_text_mainTemp.Size = new System.Drawing.Size(113, 23);
            this.mobo_text_mainTemp.TabIndex = 12;
            this.mobo_text_mainTemp.Text = "Main Temp";
            // 
            // mobo_text_biosVersion
            // 
            this.mobo_text_biosVersion.BackColor = System.Drawing.Color.Transparent;
            this.mobo_text_biosVersion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_text_biosVersion.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_text_biosVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_text_biosVersion.Location = new System.Drawing.Point(0, 391);
            this.mobo_text_biosVersion.Name = "mobo_text_biosVersion";
            this.mobo_text_biosVersion.Size = new System.Drawing.Size(158, 46);
            this.mobo_text_biosVersion.TabIndex = 11;
            this.mobo_text_biosVersion.Text = "BIOS VERSION:";
            this.mobo_text_biosVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mobo_info_biosVersion
            // 
            this.mobo_info_biosVersion.BackColor = System.Drawing.Color.Transparent;
            this.mobo_info_biosVersion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_info_biosVersion.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_info_biosVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_info_biosVersion.Location = new System.Drawing.Point(164, 391);
            this.mobo_info_biosVersion.Name = "mobo_info_biosVersion";
            this.mobo_info_biosVersion.Size = new System.Drawing.Size(627, 46);
            this.mobo_info_biosVersion.TabIndex = 10;
            this.mobo_info_biosVersion.Text = "9999";
            this.mobo_info_biosVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mobo_chipTemp_progress
            // 
            this.mobo_chipTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.mobo_chipTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.mobo_chipTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mobo_chipTemp_progress.Location = new System.Drawing.Point(411, 97);
            this.mobo_chipTemp_progress.Maximum = 100;
            this.mobo_chipTemp_progress.Name = "mobo_chipTemp_progress";
            this.mobo_chipTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.mobo_chipTemp_progress.RotationAngle = 255;
            this.mobo_chipTemp_progress.Size = new System.Drawing.Size(250, 228);
            this.mobo_chipTemp_progress.StartingAngle = 110;
            this.mobo_chipTemp_progress.TabIndex = 9;
            this.mobo_chipTemp_progress.Text = "logInRadialProgressBar1";
            this.mobo_chipTemp_progress.Value = 0;
            // 
            // mobo_mainTemp_progress
            // 
            this.mobo_mainTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.mobo_mainTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.mobo_mainTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mobo_mainTemp_progress.Location = new System.Drawing.Point(145, 97);
            this.mobo_mainTemp_progress.Maximum = 100;
            this.mobo_mainTemp_progress.Name = "mobo_mainTemp_progress";
            this.mobo_mainTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.mobo_mainTemp_progress.RotationAngle = 255;
            this.mobo_mainTemp_progress.Size = new System.Drawing.Size(250, 228);
            this.mobo_mainTemp_progress.StartingAngle = 110;
            this.mobo_mainTemp_progress.TabIndex = 8;
            this.mobo_mainTemp_progress.Text = "logInRadialProgressBar1";
            this.mobo_mainTemp_progress.Value = 0;
            // 
            // mobo_info_name
            // 
            this.mobo_info_name.BackColor = System.Drawing.Color.Transparent;
            this.mobo_info_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_info_name.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_info_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_info_name.Location = new System.Drawing.Point(0, 40);
            this.mobo_info_name.Name = "mobo_info_name";
            this.mobo_info_name.Size = new System.Drawing.Size(791, 46);
            this.mobo_info_name.TabIndex = 7;
            this.mobo_info_name.Text = "MAINBOARD NAME";
            this.mobo_info_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox_CPU
            // 
            this.GroupBox_CPU.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GroupBox_CPU.Controls.Add(this.cpu_usage_progress_value);
            this.GroupBox_CPU.Controls.Add(this.cpu_usage_progress);
            this.GroupBox_CPU.Controls.Add(this.cpu_text_usage);
            this.GroupBox_CPU.Controls.Add(this.cpu_info_name);
            this.GroupBox_CPU.Controls.Add(this.cpu_text_diodeTemp);
            this.GroupBox_CPU.Controls.Add(this.cpu_text_mainTemp);
            this.GroupBox_CPU.Controls.Add(this.cpu_celsius_diodeTemp);
            this.GroupBox_CPU.Controls.Add(this.cpu_celsius_mainTemp);
            this.GroupBox_CPU.Controls.Add(this.cpu_diodeTemp_progress);
            this.GroupBox_CPU.Controls.Add(this.cpu_mainTemp_progress);
            this.GroupBox_CPU.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GroupBox_CPU.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.GroupBox_CPU.Location = new System.Drawing.Point(1000, 34);
            this.GroupBox_CPU.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.GroupBox_CPU.Name = "GroupBox_CPU";
            this.GroupBox_CPU.Size = new System.Drawing.Size(794, 443);
            this.GroupBox_CPU.TabIndex = 0;
            this.GroupBox_CPU.Text = "CPU:";
            this.GroupBox_CPU.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cpu_usage_progress_value
            // 
            this.cpu_usage_progress_value.BackColor = System.Drawing.Color.Transparent;
            this.cpu_usage_progress_value.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_usage_progress_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_usage_progress_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_usage_progress_value.Location = new System.Drawing.Point(731, 400);
            this.cpu_usage_progress_value.Name = "cpu_usage_progress_value";
            this.cpu_usage_progress_value.Size = new System.Drawing.Size(63, 25);
            this.cpu_usage_progress_value.TabIndex = 9;
            this.cpu_usage_progress_value.Text = "0%";
            this.cpu_usage_progress_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpu_usage_progress
            // 
            this.cpu_usage_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpu_usage_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cpu_usage_progress.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cpu_usage_progress.Location = new System.Drawing.Point(105, 400);
            this.cpu_usage_progress.Maximum = 100;
            this.cpu_usage_progress.Name = "cpu_usage_progress";
            this.cpu_usage_progress.ProgressColour = System.Drawing.Color.White;
            this.cpu_usage_progress.SecondColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(184)))));
            this.cpu_usage_progress.Size = new System.Drawing.Size(620, 25);
            this.cpu_usage_progress.TabIndex = 8;
            this.cpu_usage_progress.Text = "logInProgressBar1";
            this.cpu_usage_progress.TwoColour = false;
            this.cpu_usage_progress.Value = 0;
            // 
            // cpu_text_usage
            // 
            this.cpu_text_usage.BackColor = System.Drawing.Color.Transparent;
            this.cpu_text_usage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_text_usage.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_text_usage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_text_usage.Location = new System.Drawing.Point(9, 400);
            this.cpu_text_usage.Name = "cpu_text_usage";
            this.cpu_text_usage.Size = new System.Drawing.Size(90, 25);
            this.cpu_text_usage.TabIndex = 7;
            this.cpu_text_usage.Text = "USAGE:";
            this.cpu_text_usage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpu_info_name
            // 
            this.cpu_info_name.BackColor = System.Drawing.Color.Transparent;
            this.cpu_info_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_info_name.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_info_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_info_name.Location = new System.Drawing.Point(0, 40);
            this.cpu_info_name.Name = "cpu_info_name";
            this.cpu_info_name.Size = new System.Drawing.Size(791, 46);
            this.cpu_info_name.TabIndex = 6;
            this.cpu_info_name.Text = "CPU NAME";
            this.cpu_info_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpu_text_diodeTemp
            // 
            this.cpu_text_diodeTemp.BackColor = System.Drawing.Color.Transparent;
            this.cpu_text_diodeTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_text_diodeTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_text_diodeTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_text_diodeTemp.Location = new System.Drawing.Point(504, 302);
            this.cpu_text_diodeTemp.Name = "cpu_text_diodeTemp";
            this.cpu_text_diodeTemp.Size = new System.Drawing.Size(124, 23);
            this.cpu_text_diodeTemp.TabIndex = 5;
            this.cpu_text_diodeTemp.Text = "Diode Temp";
            // 
            // cpu_text_mainTemp
            // 
            this.cpu_text_mainTemp.BackColor = System.Drawing.Color.Transparent;
            this.cpu_text_mainTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_text_mainTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_text_mainTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_text_mainTemp.Location = new System.Drawing.Point(239, 302);
            this.cpu_text_mainTemp.Name = "cpu_text_mainTemp";
            this.cpu_text_mainTemp.Size = new System.Drawing.Size(113, 23);
            this.cpu_text_mainTemp.TabIndex = 4;
            this.cpu_text_mainTemp.Text = "Main Temp";
            // 
            // cpu_celsius_diodeTemp
            // 
            this.cpu_celsius_diodeTemp.BackColor = System.Drawing.Color.Transparent;
            this.cpu_celsius_diodeTemp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_celsius_diodeTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_celsius_diodeTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_celsius_diodeTemp.Location = new System.Drawing.Point(623, 227);
            this.cpu_celsius_diodeTemp.Name = "cpu_celsius_diodeTemp";
            this.cpu_celsius_diodeTemp.Size = new System.Drawing.Size(38, 28);
            this.cpu_celsius_diodeTemp.TabIndex = 3;
            this.cpu_celsius_diodeTemp.Text = "C°";
            this.cpu_celsius_diodeTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpu_celsius_mainTemp
            // 
            this.cpu_celsius_mainTemp.BackColor = System.Drawing.Color.Transparent;
            this.cpu_celsius_mainTemp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_celsius_mainTemp.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_celsius_mainTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_celsius_mainTemp.Location = new System.Drawing.Point(357, 227);
            this.cpu_celsius_mainTemp.Name = "cpu_celsius_mainTemp";
            this.cpu_celsius_mainTemp.Size = new System.Drawing.Size(38, 28);
            this.cpu_celsius_mainTemp.TabIndex = 2;
            this.cpu_celsius_mainTemp.Text = "C°";
            this.cpu_celsius_mainTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpu_diodeTemp_progress
            // 
            this.cpu_diodeTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.cpu_diodeTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpu_diodeTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cpu_diodeTemp_progress.Location = new System.Drawing.Point(411, 97);
            this.cpu_diodeTemp_progress.Maximum = 100;
            this.cpu_diodeTemp_progress.Name = "cpu_diodeTemp_progress";
            this.cpu_diodeTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.cpu_diodeTemp_progress.RotationAngle = 255;
            this.cpu_diodeTemp_progress.Size = new System.Drawing.Size(250, 228);
            this.cpu_diodeTemp_progress.StartingAngle = 110;
            this.cpu_diodeTemp_progress.TabIndex = 1;
            this.cpu_diodeTemp_progress.Text = "logInRadialProgressBar2";
            this.cpu_diodeTemp_progress.Value = 0;
            // 
            // cpu_mainTemp_progress
            // 
            this.cpu_mainTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.cpu_mainTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpu_mainTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cpu_mainTemp_progress.Location = new System.Drawing.Point(145, 97);
            this.cpu_mainTemp_progress.Maximum = 100;
            this.cpu_mainTemp_progress.Name = "cpu_mainTemp_progress";
            this.cpu_mainTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.cpu_mainTemp_progress.RotationAngle = 255;
            this.cpu_mainTemp_progress.Size = new System.Drawing.Size(250, 228);
            this.cpu_mainTemp_progress.StartingAngle = 110;
            this.cpu_mainTemp_progress.TabIndex = 0;
            this.cpu_mainTemp_progress.Text = "logInRadialProgressBar1";
            this.cpu_mainTemp_progress.Value = 0;
            // 
            // intro_timer
            // 
            this.intro_timer.Interval = 1;
            this.intro_timer.Tick += new System.EventHandler(this.intro_timer_Tick);
            // 
            // nextScreen_Timer
            // 
            this.nextScreen_Timer.Interval = 2000;
            this.nextScreen_Timer.Tick += new System.EventHandler(this.nextScreen_Timer_Tick);
            // 
            // sensorUpdate_Timer
            // 
            this.sensorUpdate_Timer.Tick += new System.EventHandler(this.sensorUpdate_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mario\'s Senor Panel - Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.MainForm.ResumeLayout(false);
            this.GroupBox_Intro.ResumeLayout(false);
            this.GroupBox_GPU.ResumeLayout(false);
            this.GroupBox_MOBO.ResumeLayout(false);
            this.GroupBox_CPU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Hura_Theme.HuraForm MainForm;
        private Login_Theme.LogInGroupBox GroupBox_CPU;
        private Login_Theme.LogInRadialProgressBar cpu_mainTemp_progress;
        private Login_Theme.LogInRadialProgressBar cpu_diodeTemp_progress;
        private Login_Theme.LogInLabel cpu_info_name;
        private Login_Theme.LogInLabel cpu_text_diodeTemp;
        private Login_Theme.LogInLabel cpu_text_mainTemp;
        private Login_Theme.LogInLabel cpu_celsius_diodeTemp;
        private Login_Theme.LogInLabel cpu_celsius_mainTemp;
        private Login_Theme.LogInGroupBox GroupBox_MOBO;
        private Login_Theme.LogInLabel mobo_info_name;
        private Login_Theme.LogInRadialProgressBar mobo_chipTemp_progress;
        private Login_Theme.LogInRadialProgressBar mobo_mainTemp_progress;
        private Login_Theme.LogInLabel mobo_text_biosVersion;
        private Login_Theme.LogInLabel mobo_info_biosVersion;
        private Login_Theme.LogInLabel mobo_text_chipTemp;
        private Login_Theme.LogInLabel mobo_text_mainTemp;
        private Login_Theme.LogInLabel mobo_celsius_chipTemp;
        private Login_Theme.LogInLabel mobo_celsius_mainTemp;
        private Login_Theme.LogInGroupBox GroupBox_GPU;
        private Login_Theme.LogInLabel gpu_celsius_mainTemp;
        private Login_Theme.LogInLabel gpu_text_mainTemp;
        private Login_Theme.LogInRadialProgressBar gpu_mainTemp_progress;
        private Login_Theme.LogInLabel gpu_info_name;
        private Login_Theme.LogInProgressBar cpu_usage_progress;
        private Login_Theme.LogInLabel cpu_text_usage;
        private Login_Theme.LogInLabel cpu_usage_progress_value;
        private Login_Theme.LogInLabel gpu_text_usage;
        private Login_Theme.LogInLabel gpu_usage_progress_value;
        private Login_Theme.LogInProgressBar gpu_usage_progress;
        private Login_Theme.LogInGroupBox GroupBox_Intro;
        private Login_Theme.LogInProgressBar intro_progress;
        private Login_Theme.LogInLabel intro_title;
        private Login_Theme.LogInLabel intro_progress_value;
        private System.Windows.Forms.Timer intro_timer;
        private System.Windows.Forms.Timer nextScreen_Timer;
        private System.Windows.Forms.Timer sensorUpdate_Timer;
    }
}

