namespace SensorPanelWinForms
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
            this.ram_info_box = new Login_Theme.LogInGroupBox();
            this.ram_info_freeMem_value = new Login_Theme.LogInLabel();
            this.ram_info_usedMem_value = new Login_Theme.LogInLabel();
            this.ram_info_totalMem_value = new Login_Theme.LogInLabel();
            this.ram_info_usage_progress_value = new Login_Theme.LogInLabel();
            this.ram_info_usage_progress = new Login_Theme.LogInProgressBar();
            this.logInLabel15 = new Login_Theme.LogInLabel();
            this.logInLabel14 = new Login_Theme.LogInLabel();
            this.logInLabel8 = new Login_Theme.LogInLabel();
            this.logInLabel7 = new Login_Theme.LogInLabel();
            this.logInLabel5 = new Login_Theme.LogInLabel();
            this.gpu_info_box = new Login_Theme.LogInGroupBox();
            this.gpu_info_usage_progress = new Login_Theme.LogInProgressBar();
            this.logInLabel16 = new Login_Theme.LogInLabel();
            this.gpu_info_usage_progress_value = new Login_Theme.LogInLabel();
            this.logInLabel17 = new Login_Theme.LogInLabel();
            this.logInLabel19 = new Login_Theme.LogInLabel();
            this.gpu_info_mainTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.gpu_info_name = new Login_Theme.LogInLabel();
            this.cpu_info_box = new Login_Theme.LogInGroupBox();
            this.cpu_info_usage_progress = new Login_Theme.LogInProgressBar();
            this.cpu_info_usage_progress_value = new Login_Theme.LogInLabel();
            this.logInLabel13 = new Login_Theme.LogInLabel();
            this.logInLabel12 = new Login_Theme.LogInLabel();
            this.logInLabel11 = new Login_Theme.LogInLabel();
            this.logInLabel10 = new Login_Theme.LogInLabel();
            this.cpu_info_diodeTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.logInLabel9 = new Login_Theme.LogInLabel();
            this.cpu_info_mainTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.cpu_info_name = new Login_Theme.LogInLabel();
            this.mobo_info_box = new Login_Theme.LogInGroupBox();
            this.mobo_info_biosversion = new Login_Theme.LogInLabel();
            this.logInLabel6 = new Login_Theme.LogInLabel();
            this.mobo_info_name = new Login_Theme.LogInLabel();
            this.logInLabel4 = new Login_Theme.LogInLabel();
            this.logInLabel2 = new Login_Theme.LogInLabel();
            this.logInLabel1 = new Login_Theme.LogInLabel();
            this.logInLabel3 = new Login_Theme.LogInLabel();
            this.mobo_info_mainTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.mobo_info_chipsetTemp_progress = new Login_Theme.LogInRadialProgressBar();
            this.intro_progress_value = new Login_Theme.LogInLabel();
            this.intro_progressbar = new Hura_Theme.HuraProgressBar();
            this.intro_title_label = new Login_Theme.LogInLabel();
            this.mobo_info_update_timer = new System.Windows.Forms.Timer(this.components);
            this.cpu_info_update_timer = new System.Windows.Forms.Timer(this.components);
            this.gpu_info_update_timer = new System.Windows.Forms.Timer(this.components);
            this.ram_info_update_timer = new System.Windows.Forms.Timer(this.components);
            this.app_move_timer = new System.Windows.Forms.Timer(this.components);
            this.intro_timer = new System.Windows.Forms.Timer(this.components);
            this.MainForm.SuspendLayout();
            this.ram_info_box.SuspendLayout();
            this.gpu_info_box.SuspendLayout();
            this.cpu_info_box.SuspendLayout();
            this.mobo_info_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.MainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainForm.ColorScheme = Hura_Theme.HuraForm.ColorSchemes.Dark;
            this.MainForm.Controls.Add(this.ram_info_box);
            this.MainForm.Controls.Add(this.logInLabel5);
            this.MainForm.Controls.Add(this.gpu_info_box);
            this.MainForm.Controls.Add(this.cpu_info_box);
            this.MainForm.Controls.Add(this.mobo_info_box);
            this.MainForm.Controls.Add(this.intro_progress_value);
            this.MainForm.Controls.Add(this.intro_progressbar);
            this.MainForm.Controls.Add(this.intro_title_label);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MainForm.ForeColor = System.Drawing.Color.White;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(800, 480);
            this.MainForm.TabIndex = 0;
            this.MainForm.Text = "USER:";
            // 
            // ram_info_box
            // 
            this.ram_info_box.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ram_info_box.Controls.Add(this.ram_info_freeMem_value);
            this.ram_info_box.Controls.Add(this.ram_info_usedMem_value);
            this.ram_info_box.Controls.Add(this.ram_info_totalMem_value);
            this.ram_info_box.Controls.Add(this.ram_info_usage_progress_value);
            this.ram_info_box.Controls.Add(this.ram_info_usage_progress);
            this.ram_info_box.Controls.Add(this.logInLabel15);
            this.ram_info_box.Controls.Add(this.logInLabel14);
            this.ram_info_box.Controls.Add(this.logInLabel8);
            this.ram_info_box.Controls.Add(this.logInLabel7);
            this.ram_info_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ram_info_box.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ram_info_box.Location = new System.Drawing.Point(12, 289);
            this.ram_info_box.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ram_info_box.Name = "ram_info_box";
            this.ram_info_box.Size = new System.Drawing.Size(374, 179);
            this.ram_info_box.TabIndex = 4;
            this.ram_info_box.Text = "RAM:";
            this.ram_info_box.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // ram_info_freeMem_value
            // 
            this.ram_info_freeMem_value.BackColor = System.Drawing.Color.Transparent;
            this.ram_info_freeMem_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_info_freeMem_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ram_info_freeMem_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ram_info_freeMem_value.Location = new System.Drawing.Point(148, 96);
            this.ram_info_freeMem_value.Name = "ram_info_freeMem_value";
            this.ram_info_freeMem_value.Size = new System.Drawing.Size(110, 33);
            this.ram_info_freeMem_value.TabIndex = 19;
            this.ram_info_freeMem_value.Text = "0";
            this.ram_info_freeMem_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ram_info_usedMem_value
            // 
            this.ram_info_usedMem_value.BackColor = System.Drawing.Color.Transparent;
            this.ram_info_usedMem_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_info_usedMem_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ram_info_usedMem_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ram_info_usedMem_value.Location = new System.Drawing.Point(148, 63);
            this.ram_info_usedMem_value.Name = "ram_info_usedMem_value";
            this.ram_info_usedMem_value.Size = new System.Drawing.Size(110, 33);
            this.ram_info_usedMem_value.TabIndex = 18;
            this.ram_info_usedMem_value.Text = "0";
            this.ram_info_usedMem_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ram_info_totalMem_value
            // 
            this.ram_info_totalMem_value.BackColor = System.Drawing.Color.Transparent;
            this.ram_info_totalMem_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_info_totalMem_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ram_info_totalMem_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ram_info_totalMem_value.Location = new System.Drawing.Point(148, 30);
            this.ram_info_totalMem_value.Name = "ram_info_totalMem_value";
            this.ram_info_totalMem_value.Size = new System.Drawing.Size(110, 33);
            this.ram_info_totalMem_value.TabIndex = 17;
            this.ram_info_totalMem_value.Text = "0";
            this.ram_info_totalMem_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ram_info_usage_progress_value
            // 
            this.ram_info_usage_progress_value.BackColor = System.Drawing.Color.Transparent;
            this.ram_info_usage_progress_value.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_info_usage_progress_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ram_info_usage_progress_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ram_info_usage_progress_value.Location = new System.Drawing.Point(329, 129);
            this.ram_info_usage_progress_value.Name = "ram_info_usage_progress_value";
            this.ram_info_usage_progress_value.Size = new System.Drawing.Size(42, 28);
            this.ram_info_usage_progress_value.TabIndex = 16;
            this.ram_info_usage_progress_value.Text = "0%";
            this.ram_info_usage_progress_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ram_info_usage_progress
            // 
            this.ram_info_usage_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ram_info_usage_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ram_info_usage_progress.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ram_info_usage_progress.Location = new System.Drawing.Point(56, 132);
            this.ram_info_usage_progress.Maximum = 100;
            this.ram_info_usage_progress.Name = "ram_info_usage_progress";
            this.ram_info_usage_progress.ProgressColour = System.Drawing.Color.White;
            this.ram_info_usage_progress.SecondColour = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ram_info_usage_progress.Size = new System.Drawing.Size(267, 25);
            this.ram_info_usage_progress.TabIndex = 14;
            this.ram_info_usage_progress.Text = "logInProgressBar1";
            this.ram_info_usage_progress.TwoColour = false;
            this.ram_info_usage_progress.Value = 0;
            // 
            // logInLabel15
            // 
            this.logInLabel15.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel15.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel15.Location = new System.Drawing.Point(3, 129);
            this.logInLabel15.Name = "logInLabel15";
            this.logInLabel15.Size = new System.Drawing.Size(47, 33);
            this.logInLabel15.TabIndex = 10;
            this.logInLabel15.Text = "Usage:";
            this.logInLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logInLabel14
            // 
            this.logInLabel14.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel14.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel14.Location = new System.Drawing.Point(3, 96);
            this.logInLabel14.Name = "logInLabel14";
            this.logInLabel14.Size = new System.Drawing.Size(110, 33);
            this.logInLabel14.TabIndex = 9;
            this.logInLabel14.Text = "Free Memory:";
            this.logInLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logInLabel8
            // 
            this.logInLabel8.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel8.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel8.Location = new System.Drawing.Point(3, 63);
            this.logInLabel8.Name = "logInLabel8";
            this.logInLabel8.Size = new System.Drawing.Size(110, 33);
            this.logInLabel8.TabIndex = 8;
            this.logInLabel8.Text = "Used Memory:";
            this.logInLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logInLabel7
            // 
            this.logInLabel7.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel7.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel7.Location = new System.Drawing.Point(3, 30);
            this.logInLabel7.Name = "logInLabel7";
            this.logInLabel7.Size = new System.Drawing.Size(110, 33);
            this.logInLabel7.TabIndex = 7;
            this.logInLabel7.Text = "Total Memory:";
            this.logInLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logInLabel5
            // 
            this.logInLabel5.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel5.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel5.Location = new System.Drawing.Point(579, 0);
            this.logInLabel5.Name = "logInLabel5";
            this.logInLabel5.Size = new System.Drawing.Size(218, 33);
            this.logInLabel5.TabIndex = 3;
            this.logInLabel5.Text = "Version: TEST";
            this.logInLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpu_info_box
            // 
            this.gpu_info_box.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gpu_info_box.Controls.Add(this.gpu_info_usage_progress);
            this.gpu_info_box.Controls.Add(this.logInLabel16);
            this.gpu_info_box.Controls.Add(this.gpu_info_usage_progress_value);
            this.gpu_info_box.Controls.Add(this.logInLabel17);
            this.gpu_info_box.Controls.Add(this.logInLabel19);
            this.gpu_info_box.Controls.Add(this.gpu_info_mainTemp_progress);
            this.gpu_info_box.Controls.Add(this.gpu_info_name);
            this.gpu_info_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gpu_info_box.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gpu_info_box.Location = new System.Drawing.Point(487, 36);
            this.gpu_info_box.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.gpu_info_box.Name = "gpu_info_box";
            this.gpu_info_box.Size = new System.Drawing.Size(301, 244);
            this.gpu_info_box.TabIndex = 2;
            this.gpu_info_box.Text = "GPU:";
            this.gpu_info_box.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // gpu_info_usage_progress
            // 
            this.gpu_info_usage_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gpu_info_usage_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gpu_info_usage_progress.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gpu_info_usage_progress.Location = new System.Drawing.Point(54, 216);
            this.gpu_info_usage_progress.Maximum = 100;
            this.gpu_info_usage_progress.Name = "gpu_info_usage_progress";
            this.gpu_info_usage_progress.ProgressColour = System.Drawing.Color.White;
            this.gpu_info_usage_progress.SecondColour = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gpu_info_usage_progress.Size = new System.Drawing.Size(206, 25);
            this.gpu_info_usage_progress.TabIndex = 14;
            this.gpu_info_usage_progress.Text = "logInProgressBar2";
            this.gpu_info_usage_progress.TwoColour = false;
            this.gpu_info_usage_progress.Value = 0;
            // 
            // logInLabel16
            // 
            this.logInLabel16.AutoSize = true;
            this.logInLabel16.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel16.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel16.Location = new System.Drawing.Point(183, 149);
            this.logInLabel16.Name = "logInLabel16";
            this.logInLabel16.Size = new System.Drawing.Size(20, 15);
            this.logInLabel16.TabIndex = 5;
            this.logInLabel16.Text = "°C";
            // 
            // gpu_info_usage_progress_value
            // 
            this.gpu_info_usage_progress_value.BackColor = System.Drawing.Color.Transparent;
            this.gpu_info_usage_progress_value.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_info_usage_progress_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_info_usage_progress_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_info_usage_progress_value.Location = new System.Drawing.Point(259, 216);
            this.gpu_info_usage_progress_value.Name = "gpu_info_usage_progress_value";
            this.gpu_info_usage_progress_value.Size = new System.Drawing.Size(42, 28);
            this.gpu_info_usage_progress_value.TabIndex = 15;
            this.gpu_info_usage_progress_value.Text = "0%";
            this.gpu_info_usage_progress_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logInLabel17
            // 
            this.logInLabel17.AutoSize = true;
            this.logInLabel17.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel17.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel17.Location = new System.Drawing.Point(137, 175);
            this.logInLabel17.Name = "logInLabel17";
            this.logInLabel17.Size = new System.Drawing.Size(66, 15);
            this.logInLabel17.TabIndex = 11;
            this.logInLabel17.Text = "Main Temp";
            // 
            // logInLabel19
            // 
            this.logInLabel19.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel19.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel19.Location = new System.Drawing.Point(3, 216);
            this.logInLabel19.Name = "logInLabel19";
            this.logInLabel19.Size = new System.Drawing.Size(70, 28);
            this.logInLabel19.TabIndex = 13;
            this.logInLabel19.Text = "USAGE:";
            this.logInLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpu_info_mainTemp_progress
            // 
            this.gpu_info_mainTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.gpu_info_mainTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gpu_info_mainTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gpu_info_mainTemp_progress.Location = new System.Drawing.Point(102, 91);
            this.gpu_info_mainTemp_progress.Maximum = 100;
            this.gpu_info_mainTemp_progress.Name = "gpu_info_mainTemp_progress";
            this.gpu_info_mainTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.gpu_info_mainTemp_progress.RotationAngle = 255;
            this.gpu_info_mainTemp_progress.Size = new System.Drawing.Size(101, 99);
            this.gpu_info_mainTemp_progress.StartingAngle = 110;
            this.gpu_info_mainTemp_progress.TabIndex = 8;
            this.gpu_info_mainTemp_progress.Text = "logInRadialProgressBar5";
            this.gpu_info_mainTemp_progress.Value = 0;
            // 
            // gpu_info_name
            // 
            this.gpu_info_name.BackColor = System.Drawing.Color.Transparent;
            this.gpu_info_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_info_name.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_info_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpu_info_name.Location = new System.Drawing.Point(3, 31);
            this.gpu_info_name.Name = "gpu_info_name";
            this.gpu_info_name.Size = new System.Drawing.Size(295, 57);
            this.gpu_info_name.TabIndex = 7;
            this.gpu_info_name.Text = "GPU NAME";
            this.gpu_info_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpu_info_box
            // 
            this.cpu_info_box.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cpu_info_box.Controls.Add(this.cpu_info_usage_progress);
            this.cpu_info_box.Controls.Add(this.cpu_info_usage_progress_value);
            this.cpu_info_box.Controls.Add(this.logInLabel13);
            this.cpu_info_box.Controls.Add(this.logInLabel12);
            this.cpu_info_box.Controls.Add(this.logInLabel11);
            this.cpu_info_box.Controls.Add(this.logInLabel10);
            this.cpu_info_box.Controls.Add(this.cpu_info_diodeTemp_progress);
            this.cpu_info_box.Controls.Add(this.logInLabel9);
            this.cpu_info_box.Controls.Add(this.cpu_info_mainTemp_progress);
            this.cpu_info_box.Controls.Add(this.cpu_info_name);
            this.cpu_info_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cpu_info_box.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpu_info_box.Location = new System.Drawing.Point(251, 36);
            this.cpu_info_box.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cpu_info_box.Name = "cpu_info_box";
            this.cpu_info_box.Size = new System.Drawing.Size(233, 247);
            this.cpu_info_box.TabIndex = 1;
            this.cpu_info_box.Text = "CPU:";
            this.cpu_info_box.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // cpu_info_usage_progress
            // 
            this.cpu_info_usage_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpu_info_usage_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cpu_info_usage_progress.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cpu_info_usage_progress.Location = new System.Drawing.Point(54, 219);
            this.cpu_info_usage_progress.Maximum = 100;
            this.cpu_info_usage_progress.Name = "cpu_info_usage_progress";
            this.cpu_info_usage_progress.ProgressColour = System.Drawing.Color.White;
            this.cpu_info_usage_progress.SecondColour = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cpu_info_usage_progress.Size = new System.Drawing.Size(136, 25);
            this.cpu_info_usage_progress.TabIndex = 13;
            this.cpu_info_usage_progress.Text = "logInProgressBar1";
            this.cpu_info_usage_progress.TwoColour = false;
            this.cpu_info_usage_progress.Value = 0;
            // 
            // cpu_info_usage_progress_value
            // 
            this.cpu_info_usage_progress_value.BackColor = System.Drawing.Color.Transparent;
            this.cpu_info_usage_progress_value.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_info_usage_progress_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_info_usage_progress_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_info_usage_progress_value.Location = new System.Drawing.Point(191, 219);
            this.cpu_info_usage_progress_value.Name = "cpu_info_usage_progress_value";
            this.cpu_info_usage_progress_value.Size = new System.Drawing.Size(42, 28);
            this.cpu_info_usage_progress_value.TabIndex = 13;
            this.cpu_info_usage_progress_value.Text = "0%";
            this.cpu_info_usage_progress_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logInLabel13
            // 
            this.logInLabel13.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel13.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel13.Location = new System.Drawing.Point(3, 219);
            this.logInLabel13.Name = "logInLabel13";
            this.logInLabel13.Size = new System.Drawing.Size(70, 28);
            this.logInLabel13.TabIndex = 12;
            this.logInLabel13.Text = "USAGE:";
            this.logInLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logInLabel12
            // 
            this.logInLabel12.AutoSize = true;
            this.logInLabel12.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel12.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel12.Location = new System.Drawing.Point(87, 149);
            this.logInLabel12.Name = "logInLabel12";
            this.logInLabel12.Size = new System.Drawing.Size(20, 15);
            this.logInLabel12.TabIndex = 3;
            this.logInLabel12.Text = "°C";
            // 
            // logInLabel11
            // 
            this.logInLabel11.AutoSize = true;
            this.logInLabel11.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel11.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel11.Location = new System.Drawing.Point(194, 149);
            this.logInLabel11.Name = "logInLabel11";
            this.logInLabel11.Size = new System.Drawing.Size(20, 15);
            this.logInLabel11.TabIndex = 11;
            this.logInLabel11.Text = "°C";
            // 
            // logInLabel10
            // 
            this.logInLabel10.AutoSize = true;
            this.logInLabel10.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel10.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel10.Location = new System.Drawing.Point(151, 175);
            this.logInLabel10.Name = "logInLabel10";
            this.logInLabel10.Size = new System.Drawing.Size(70, 15);
            this.logInLabel10.TabIndex = 10;
            this.logInLabel10.Text = "Diode Temp";
            // 
            // cpu_info_diodeTemp_progress
            // 
            this.cpu_info_diodeTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.cpu_info_diodeTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpu_info_diodeTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cpu_info_diodeTemp_progress.Location = new System.Drawing.Point(113, 91);
            this.cpu_info_diodeTemp_progress.Maximum = 100;
            this.cpu_info_diodeTemp_progress.Name = "cpu_info_diodeTemp_progress";
            this.cpu_info_diodeTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.cpu_info_diodeTemp_progress.RotationAngle = 255;
            this.cpu_info_diodeTemp_progress.Size = new System.Drawing.Size(101, 99);
            this.cpu_info_diodeTemp_progress.StartingAngle = 110;
            this.cpu_info_diodeTemp_progress.TabIndex = 9;
            this.cpu_info_diodeTemp_progress.Text = "logInRadialProgressBar4";
            this.cpu_info_diodeTemp_progress.Value = 0;
            // 
            // logInLabel9
            // 
            this.logInLabel9.AutoSize = true;
            this.logInLabel9.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel9.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel9.Location = new System.Drawing.Point(41, 175);
            this.logInLabel9.Name = "logInLabel9";
            this.logInLabel9.Size = new System.Drawing.Size(66, 15);
            this.logInLabel9.TabIndex = 8;
            this.logInLabel9.Text = "Main Temp";
            // 
            // cpu_info_mainTemp_progress
            // 
            this.cpu_info_mainTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.cpu_info_mainTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.cpu_info_mainTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cpu_info_mainTemp_progress.Location = new System.Drawing.Point(6, 91);
            this.cpu_info_mainTemp_progress.Maximum = 100;
            this.cpu_info_mainTemp_progress.Name = "cpu_info_mainTemp_progress";
            this.cpu_info_mainTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.cpu_info_mainTemp_progress.RotationAngle = 255;
            this.cpu_info_mainTemp_progress.Size = new System.Drawing.Size(101, 99);
            this.cpu_info_mainTemp_progress.StartingAngle = 110;
            this.cpu_info_mainTemp_progress.TabIndex = 7;
            this.cpu_info_mainTemp_progress.Text = "logInRadialProgressBar3";
            this.cpu_info_mainTemp_progress.Value = 0;
            // 
            // cpu_info_name
            // 
            this.cpu_info_name.BackColor = System.Drawing.Color.Transparent;
            this.cpu_info_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_info_name.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_info_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpu_info_name.Location = new System.Drawing.Point(3, 31);
            this.cpu_info_name.Name = "cpu_info_name";
            this.cpu_info_name.Size = new System.Drawing.Size(227, 57);
            this.cpu_info_name.TabIndex = 6;
            this.cpu_info_name.Text = "CPU NAME";
            this.cpu_info_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobo_info_box
            // 
            this.mobo_info_box.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mobo_info_box.Controls.Add(this.mobo_info_biosversion);
            this.mobo_info_box.Controls.Add(this.logInLabel6);
            this.mobo_info_box.Controls.Add(this.mobo_info_name);
            this.mobo_info_box.Controls.Add(this.logInLabel4);
            this.mobo_info_box.Controls.Add(this.logInLabel2);
            this.mobo_info_box.Controls.Add(this.logInLabel1);
            this.mobo_info_box.Controls.Add(this.logInLabel3);
            this.mobo_info_box.Controls.Add(this.mobo_info_mainTemp_progress);
            this.mobo_info_box.Controls.Add(this.mobo_info_chipsetTemp_progress);
            this.mobo_info_box.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mobo_info_box.HeaderColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.mobo_info_box.Location = new System.Drawing.Point(12, 36);
            this.mobo_info_box.MainColour = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.mobo_info_box.Name = "mobo_info_box";
            this.mobo_info_box.Size = new System.Drawing.Size(233, 247);
            this.mobo_info_box.TabIndex = 0;
            this.mobo_info_box.Text = "MAINBOARD:";
            this.mobo_info_box.TextColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // mobo_info_biosversion
            // 
            this.mobo_info_biosversion.BackColor = System.Drawing.Color.Transparent;
            this.mobo_info_biosversion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_info_biosversion.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_info_biosversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_info_biosversion.Location = new System.Drawing.Point(114, 206);
            this.mobo_info_biosversion.Name = "mobo_info_biosversion";
            this.mobo_info_biosversion.Size = new System.Drawing.Size(97, 41);
            this.mobo_info_biosversion.TabIndex = 7;
            this.mobo_info_biosversion.Text = "00000";
            this.mobo_info_biosversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logInLabel6
            // 
            this.logInLabel6.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel6.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel6.Location = new System.Drawing.Point(3, 206);
            this.logInLabel6.Name = "logInLabel6";
            this.logInLabel6.Size = new System.Drawing.Size(130, 41);
            this.logInLabel6.TabIndex = 6;
            this.logInLabel6.Text = "BIOS VERSION:";
            this.logInLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobo_info_name
            // 
            this.mobo_info_name.BackColor = System.Drawing.Color.Transparent;
            this.mobo_info_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobo_info_name.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_info_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mobo_info_name.Location = new System.Drawing.Point(3, 31);
            this.mobo_info_name.Name = "mobo_info_name";
            this.mobo_info_name.Size = new System.Drawing.Size(224, 57);
            this.mobo_info_name.TabIndex = 5;
            this.mobo_info_name.Text = "MOBO NAME";
            this.mobo_info_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logInLabel4
            // 
            this.logInLabel4.AutoSize = true;
            this.logInLabel4.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel4.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel4.Location = new System.Drawing.Point(191, 149);
            this.logInLabel4.Name = "logInLabel4";
            this.logInLabel4.Size = new System.Drawing.Size(20, 15);
            this.logInLabel4.TabIndex = 2;
            this.logInLabel4.Text = "°C";
            // 
            // logInLabel2
            // 
            this.logInLabel2.AutoSize = true;
            this.logInLabel2.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel2.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel2.Location = new System.Drawing.Point(38, 175);
            this.logInLabel2.Name = "logInLabel2";
            this.logInLabel2.Size = new System.Drawing.Size(66, 15);
            this.logInLabel2.TabIndex = 2;
            this.logInLabel2.Text = "Main Temp";
            // 
            // logInLabel1
            // 
            this.logInLabel1.AutoSize = true;
            this.logInLabel1.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel1.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel1.Location = new System.Drawing.Point(84, 149);
            this.logInLabel1.Name = "logInLabel1";
            this.logInLabel1.Size = new System.Drawing.Size(20, 15);
            this.logInLabel1.TabIndex = 1;
            this.logInLabel1.Text = "°C";
            // 
            // logInLabel3
            // 
            this.logInLabel3.AutoSize = true;
            this.logInLabel3.BackColor = System.Drawing.Color.Transparent;
            this.logInLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logInLabel3.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logInLabel3.Location = new System.Drawing.Point(148, 175);
            this.logInLabel3.Name = "logInLabel3";
            this.logInLabel3.Size = new System.Drawing.Size(79, 15);
            this.logInLabel3.TabIndex = 4;
            this.logInLabel3.Text = "Chipset Temp";
            // 
            // mobo_info_mainTemp_progress
            // 
            this.mobo_info_mainTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.mobo_info_mainTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.mobo_info_mainTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mobo_info_mainTemp_progress.Location = new System.Drawing.Point(3, 91);
            this.mobo_info_mainTemp_progress.Maximum = 100;
            this.mobo_info_mainTemp_progress.Name = "mobo_info_mainTemp_progress";
            this.mobo_info_mainTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.mobo_info_mainTemp_progress.RotationAngle = 255;
            this.mobo_info_mainTemp_progress.Size = new System.Drawing.Size(101, 99);
            this.mobo_info_mainTemp_progress.StartingAngle = 110;
            this.mobo_info_mainTemp_progress.TabIndex = 0;
            this.mobo_info_mainTemp_progress.Text = "logInRadialProgressBar1";
            this.mobo_info_mainTemp_progress.Value = 0;
            // 
            // mobo_info_chipsetTemp_progress
            // 
            this.mobo_info_chipsetTemp_progress.BackColor = System.Drawing.Color.Transparent;
            this.mobo_info_chipsetTemp_progress.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.mobo_info_chipsetTemp_progress.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mobo_info_chipsetTemp_progress.Location = new System.Drawing.Point(110, 91);
            this.mobo_info_chipsetTemp_progress.Maximum = 100;
            this.mobo_info_chipsetTemp_progress.Name = "mobo_info_chipsetTemp_progress";
            this.mobo_info_chipsetTemp_progress.ProgressColour = System.Drawing.Color.White;
            this.mobo_info_chipsetTemp_progress.RotationAngle = 255;
            this.mobo_info_chipsetTemp_progress.Size = new System.Drawing.Size(101, 99);
            this.mobo_info_chipsetTemp_progress.StartingAngle = 110;
            this.mobo_info_chipsetTemp_progress.TabIndex = 3;
            this.mobo_info_chipsetTemp_progress.Text = "logInRadialProgressBar2";
            this.mobo_info_chipsetTemp_progress.Value = 0;
            // 
            // intro_progress_value
            // 
            this.intro_progress_value.BackColor = System.Drawing.Color.Transparent;
            this.intro_progress_value.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro_progress_value.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intro_progress_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intro_progress_value.Location = new System.Drawing.Point(482, 337);
            this.intro_progress_value.Name = "intro_progress_value";
            this.intro_progress_value.Size = new System.Drawing.Size(218, 33);
            this.intro_progress_value.TabIndex = 7;
            this.intro_progress_value.Text = "0%";
            this.intro_progress_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intro_progressbar
            // 
            this.intro_progressbar.Location = new System.Drawing.Point(448, 371);
            this.intro_progressbar.Maximum = 100;
            this.intro_progressbar.Minimum = 0;
            this.intro_progressbar.Name = "intro_progressbar";
            this.intro_progressbar.Size = new System.Drawing.Size(281, 47);
            this.intro_progressbar.TabIndex = 5;
            this.intro_progressbar.Text = "huraProgressBar1";
            this.intro_progressbar.Value = 50;
            // 
            // intro_title_label
            // 
            this.intro_title_label.BackColor = System.Drawing.Color.Transparent;
            this.intro_title_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro_title_label.FontColour = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intro_title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intro_title_label.Location = new System.Drawing.Point(482, 304);
            this.intro_title_label.Name = "intro_title_label";
            this.intro_title_label.Size = new System.Drawing.Size(218, 33);
            this.intro_title_label.TabIndex = 6;
            this.intro_title_label.Text = "Mario\'s Sensor Panel";
            this.intro_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobo_info_update_timer
            // 
            this.mobo_info_update_timer.Interval = 1000;
            this.mobo_info_update_timer.Tick += new System.EventHandler(this.mobo_info_update_timer_Tick);
            // 
            // cpu_info_update_timer
            // 
            this.cpu_info_update_timer.Interval = 1000;
            this.cpu_info_update_timer.Tick += new System.EventHandler(this.cpu_info_update_timer_Tick);
            // 
            // gpu_info_update_timer
            // 
            this.gpu_info_update_timer.Interval = 1000;
            this.gpu_info_update_timer.Tick += new System.EventHandler(this.gpu_info_update_timer_Tick);
            // 
            // ram_info_update_timer
            // 
            this.ram_info_update_timer.Interval = 1000;
            this.ram_info_update_timer.Tick += new System.EventHandler(this.ram_info_update_timer_Tick);
            // 
            // app_move_timer
            // 
            this.app_move_timer.Interval = 1;
            this.app_move_timer.Tick += new System.EventHandler(this.app_move_timer_Tick);
            // 
            // intro_timer
            // 
            this.intro_timer.Interval = 50;
            this.intro_timer.Tick += new System.EventHandler(this.intro_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sensor Panel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.MainForm.ResumeLayout(false);
            this.ram_info_box.ResumeLayout(false);
            this.gpu_info_box.ResumeLayout(false);
            this.gpu_info_box.PerformLayout();
            this.cpu_info_box.ResumeLayout(false);
            this.cpu_info_box.PerformLayout();
            this.mobo_info_box.ResumeLayout(false);
            this.mobo_info_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Hura_Theme.HuraForm MainForm;
        private Login_Theme.LogInGroupBox mobo_info_box;
        private Login_Theme.LogInLabel logInLabel1;
        private Login_Theme.LogInRadialProgressBar mobo_info_mainTemp_progress;
        private Login_Theme.LogInLabel logInLabel2;
        private Login_Theme.LogInLabel logInLabel4;
        private Login_Theme.LogInLabel logInLabel3;
        private Login_Theme.LogInRadialProgressBar mobo_info_chipsetTemp_progress;
        private Login_Theme.LogInLabel mobo_info_name;
        private Login_Theme.LogInLabel mobo_info_biosversion;
        private Login_Theme.LogInLabel logInLabel6;
        private Login_Theme.LogInGroupBox cpu_info_box;
        private Login_Theme.LogInLabel logInLabel12;
        private Login_Theme.LogInLabel logInLabel11;
        private Login_Theme.LogInLabel logInLabel10;
        private Login_Theme.LogInRadialProgressBar cpu_info_diodeTemp_progress;
        private Login_Theme.LogInLabel logInLabel9;
        private Login_Theme.LogInRadialProgressBar cpu_info_mainTemp_progress;
        private Login_Theme.LogInLabel cpu_info_name;
        private Login_Theme.LogInProgressBar cpu_info_usage_progress;
        private Login_Theme.LogInLabel logInLabel13;
        private Login_Theme.LogInGroupBox gpu_info_box;
        private Login_Theme.LogInProgressBar gpu_info_usage_progress;
        private Login_Theme.LogInLabel logInLabel19;
        private Login_Theme.LogInLabel logInLabel17;
        private Login_Theme.LogInLabel logInLabel16;
        private Login_Theme.LogInRadialProgressBar gpu_info_mainTemp_progress;
        private Login_Theme.LogInLabel gpu_info_name;
        private Login_Theme.LogInLabel gpu_info_usage_progress_value;
        private Login_Theme.LogInLabel cpu_info_usage_progress_value;
        private System.Windows.Forms.Timer mobo_info_update_timer;
        private System.Windows.Forms.Timer cpu_info_update_timer;
        private System.Windows.Forms.Timer gpu_info_update_timer;
        private Login_Theme.LogInLabel logInLabel5;
        private Login_Theme.LogInGroupBox ram_info_box;
        private Login_Theme.LogInLabel logInLabel7;
        private Login_Theme.LogInLabel logInLabel15;
        private Login_Theme.LogInLabel logInLabel14;
        private Login_Theme.LogInLabel logInLabel8;
        private Login_Theme.LogInLabel ram_info_usage_progress_value;
        private Login_Theme.LogInProgressBar ram_info_usage_progress;
        private Login_Theme.LogInLabel ram_info_freeMem_value;
        private Login_Theme.LogInLabel ram_info_usedMem_value;
        private Login_Theme.LogInLabel ram_info_totalMem_value;
        private System.Windows.Forms.Timer ram_info_update_timer;
        private System.Windows.Forms.Timer app_move_timer;
        private Login_Theme.LogInLabel intro_progress_value;
        private Login_Theme.LogInLabel intro_title_label;
        private Hura_Theme.HuraProgressBar intro_progressbar;
        private System.Windows.Forms.Timer intro_timer;
    }
}

