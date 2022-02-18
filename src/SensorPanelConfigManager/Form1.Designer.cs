namespace SensorPanelConfigManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Interval_MOBO = new System.Windows.Forms.ComboBox();
            this.comboBox_Interval_CPU = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Interval_GPU = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Interval_RAM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_saveSettings = new System.Windows.Forms.Button();
            this.button_restartPanel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Info_CurrentPos_X = new System.Windows.Forms.TextBox();
            this.textBox_Info_CurrentPos_Y = new System.Windows.Forms.TextBox();
            this.button_useCurPos = new System.Windows.Forms.Button();
            this.current_window_pos_update_timer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown_Setting_WinPos_X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Setting_WinPos_Y = new System.Windows.Forms.NumericUpDown();
            this.button_close_panel = new System.Windows.Forms.Button();
            this.checkBox_panel_autostart = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Setting_WinPos_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Setting_WinPos_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Interval(Ms): MOBO";
            // 
            // comboBox_Interval_MOBO
            // 
            this.comboBox_Interval_MOBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Interval_MOBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Interval_MOBO.FormattingEnabled = true;
            this.comboBox_Interval_MOBO.Location = new System.Drawing.Point(270, 6);
            this.comboBox_Interval_MOBO.Name = "comboBox_Interval_MOBO";
            this.comboBox_Interval_MOBO.Size = new System.Drawing.Size(351, 28);
            this.comboBox_Interval_MOBO.TabIndex = 1;
            this.comboBox_Interval_MOBO.SelectedIndexChanged += new System.EventHandler(this.comboBox_Interval_MOBO_SelectedIndexChanged);
            // 
            // comboBox_Interval_CPU
            // 
            this.comboBox_Interval_CPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Interval_CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Interval_CPU.FormattingEnabled = true;
            this.comboBox_Interval_CPU.Location = new System.Drawing.Point(270, 40);
            this.comboBox_Interval_CPU.Name = "comboBox_Interval_CPU";
            this.comboBox_Interval_CPU.Size = new System.Drawing.Size(351, 28);
            this.comboBox_Interval_CPU.TabIndex = 3;
            this.comboBox_Interval_CPU.SelectedIndexChanged += new System.EventHandler(this.comboBox_Interval_CPU_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update Interval(Ms): CPU";
            // 
            // comboBox_Interval_GPU
            // 
            this.comboBox_Interval_GPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Interval_GPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Interval_GPU.FormattingEnabled = true;
            this.comboBox_Interval_GPU.Location = new System.Drawing.Point(270, 74);
            this.comboBox_Interval_GPU.Name = "comboBox_Interval_GPU";
            this.comboBox_Interval_GPU.Size = new System.Drawing.Size(351, 28);
            this.comboBox_Interval_GPU.TabIndex = 5;
            this.comboBox_Interval_GPU.SelectedIndexChanged += new System.EventHandler(this.comboBox_Interval_GPU_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Update Interval(Ms): GPU";
            // 
            // comboBox_Interval_RAM
            // 
            this.comboBox_Interval_RAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Interval_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Interval_RAM.FormattingEnabled = true;
            this.comboBox_Interval_RAM.Location = new System.Drawing.Point(270, 108);
            this.comboBox_Interval_RAM.Name = "comboBox_Interval_RAM";
            this.comboBox_Interval_RAM.Size = new System.Drawing.Size(351, 28);
            this.comboBox_Interval_RAM.TabIndex = 7;
            this.comboBox_Interval_RAM.SelectedIndexChanged += new System.EventHandler(this.comboBox_Interval_RAM_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Update Interval(Ms): RAM";
            // 
            // button_saveSettings
            // 
            this.button_saveSettings.Location = new System.Drawing.Point(12, 397);
            this.button_saveSettings.Name = "button_saveSettings";
            this.button_saveSettings.Size = new System.Drawing.Size(179, 41);
            this.button_saveSettings.TabIndex = 8;
            this.button_saveSettings.Text = "Save";
            this.button_saveSettings.UseVisualStyleBackColor = true;
            this.button_saveSettings.Click += new System.EventHandler(this.button_saveSettings_Click);
            // 
            // button_restartPanel
            // 
            this.button_restartPanel.Location = new System.Drawing.Point(197, 397);
            this.button_restartPanel.Name = "button_restartPanel";
            this.button_restartPanel.Size = new System.Drawing.Size(179, 41);
            this.button_restartPanel.TabIndex = 9;
            this.button_restartPanel.Text = "Start/Restart Sensor Panel";
            this.button_restartPanel.UseVisualStyleBackColor = true;
            this.button_restartPanel.Click += new System.EventHandler(this.button_restartPanel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Window Position:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Current Position:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "X:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(343, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 27);
            this.label10.TabIndex = 11;
            this.label10.Text = "Y:";
            // 
            // textBox_Info_CurrentPos_X
            // 
            this.textBox_Info_CurrentPos_X.Location = new System.Drawing.Point(232, 202);
            this.textBox_Info_CurrentPos_X.MaxLength = 4;
            this.textBox_Info_CurrentPos_X.Name = "textBox_Info_CurrentPos_X";
            this.textBox_Info_CurrentPos_X.ReadOnly = true;
            this.textBox_Info_CurrentPos_X.Size = new System.Drawing.Size(62, 20);
            this.textBox_Info_CurrentPos_X.TabIndex = 12;
            // 
            // textBox_Info_CurrentPos_Y
            // 
            this.textBox_Info_CurrentPos_Y.Location = new System.Drawing.Point(382, 204);
            this.textBox_Info_CurrentPos_Y.MaxLength = 4;
            this.textBox_Info_CurrentPos_Y.Name = "textBox_Info_CurrentPos_Y";
            this.textBox_Info_CurrentPos_Y.ReadOnly = true;
            this.textBox_Info_CurrentPos_Y.Size = new System.Drawing.Size(62, 20);
            this.textBox_Info_CurrentPos_Y.TabIndex = 12;
            // 
            // button_useCurPos
            // 
            this.button_useCurPos.Location = new System.Drawing.Point(487, 175);
            this.button_useCurPos.Name = "button_useCurPos";
            this.button_useCurPos.Size = new System.Drawing.Size(161, 22);
            this.button_useCurPos.TabIndex = 13;
            this.button_useCurPos.Text = "Use Current Position";
            this.button_useCurPos.UseVisualStyleBackColor = true;
            this.button_useCurPos.Click += new System.EventHandler(this.button_useCurPos_Click);
            // 
            // current_window_pos_update_timer
            // 
            this.current_window_pos_update_timer.Enabled = true;
            this.current_window_pos_update_timer.Interval = 1;
            this.current_window_pos_update_timer.Tick += new System.EventHandler(this.current_window_pos_update_timer_Tick);
            // 
            // numericUpDown_Setting_WinPos_X
            // 
            this.numericUpDown_Setting_WinPos_X.Location = new System.Drawing.Point(232, 175);
            this.numericUpDown_Setting_WinPos_X.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_Setting_WinPos_X.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown_Setting_WinPos_X.Name = "numericUpDown_Setting_WinPos_X";
            this.numericUpDown_Setting_WinPos_X.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown_Setting_WinPos_X.TabIndex = 14;
            this.numericUpDown_Setting_WinPos_X.ValueChanged += new System.EventHandler(this.numericUpDown_Setting_WinPos_X_ValueChanged);
            // 
            // numericUpDown_Setting_WinPos_Y
            // 
            this.numericUpDown_Setting_WinPos_Y.Location = new System.Drawing.Point(382, 175);
            this.numericUpDown_Setting_WinPos_Y.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_Setting_WinPos_Y.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown_Setting_WinPos_Y.Name = "numericUpDown_Setting_WinPos_Y";
            this.numericUpDown_Setting_WinPos_Y.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown_Setting_WinPos_Y.TabIndex = 15;
            this.numericUpDown_Setting_WinPos_Y.ValueChanged += new System.EventHandler(this.numericUpDown_Setting_WinPos_Y_ValueChanged);
            // 
            // button_close_panel
            // 
            this.button_close_panel.Location = new System.Drawing.Point(382, 397);
            this.button_close_panel.Name = "button_close_panel";
            this.button_close_panel.Size = new System.Drawing.Size(179, 41);
            this.button_close_panel.TabIndex = 16;
            this.button_close_panel.Text = "Close Sensor Panel";
            this.button_close_panel.UseVisualStyleBackColor = true;
            this.button_close_panel.Click += new System.EventHandler(this.button_close_panel_Click);
            // 
            // checkBox_panel_autostart
            // 
            this.checkBox_panel_autostart.AutoSize = true;
            this.checkBox_panel_autostart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_panel_autostart.Location = new System.Drawing.Point(12, 259);
            this.checkBox_panel_autostart.Name = "checkBox_panel_autostart";
            this.checkBox_panel_autostart.Size = new System.Drawing.Size(161, 24);
            this.checkBox_panel_autostart.TabIndex = 18;
            this.checkBox_panel_autostart.Text = "Panel Auto Start";
            this.checkBox_panel_autostart.UseVisualStyleBackColor = true;
            this.checkBox_panel_autostart.CheckedChanged += new System.EventHandler(this.checkBox_panel_autostart_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_panel_autostart);
            this.Controls.Add(this.button_close_panel);
            this.Controls.Add(this.numericUpDown_Setting_WinPos_Y);
            this.Controls.Add(this.numericUpDown_Setting_WinPos_X);
            this.Controls.Add(this.button_useCurPos);
            this.Controls.Add(this.textBox_Info_CurrentPos_Y);
            this.Controls.Add(this.textBox_Info_CurrentPos_X);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_restartPanel);
            this.Controls.Add(this.button_saveSettings);
            this.Controls.Add(this.comboBox_Interval_RAM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Interval_GPU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Interval_CPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Interval_MOBO);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sensor Panel Config Manager";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Setting_WinPos_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Setting_WinPos_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Interval_MOBO;
        private System.Windows.Forms.ComboBox comboBox_Interval_CPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Interval_GPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Interval_RAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_saveSettings;
        private System.Windows.Forms.Button button_restartPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Info_CurrentPos_X;
        private System.Windows.Forms.TextBox textBox_Info_CurrentPos_Y;
        private System.Windows.Forms.Button button_useCurPos;
        private System.Windows.Forms.Timer current_window_pos_update_timer;
        private System.Windows.Forms.NumericUpDown numericUpDown_Setting_WinPos_X;
        private System.Windows.Forms.NumericUpDown numericUpDown_Setting_WinPos_Y;
        private System.Windows.Forms.Button button_close_panel;
        private System.Windows.Forms.CheckBox checkBox_panel_autostart;
    }
}

