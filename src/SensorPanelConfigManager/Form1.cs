using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using SensorPanelConfigManager.CFG;

namespace SensorPanelConfigManager
{
    public partial class Form1 : Form
    {
        private int[] Intervals = new int[] { 100, 300, 500, 800, 1000, 1500, 2000 };

        private int Setting_Interval_MOBO;
        private int Setting_Interval_CPU;
        private int Setting_Interval_GPU;
        private int Setting_Interval_RAM;
        private string Setting_Window_Position;


        public Form1()
        {
            InitializeComponent();

            //Add Intervals to ComboBoxes
            for(int i = 0; i < Intervals.Length; i++)
            {
                comboBox_Interval_MOBO.Items.Add(Intervals[i]);
                comboBox_Interval_CPU.Items.Add(Intervals[i]);
                comboBox_Interval_GPU.Items.Add(Intervals[i]);
                comboBox_Interval_RAM.Items.Add(Intervals[i]);
            }


            //Check Config
            Config.CheckConfig();


            //Load Current Settings

            //Interval Mobo
            Setting_Interval_MOBO = Int32.Parse(Config.GetSetting(SettingTypes.INFO_UPDATE_INTERVAL_MOBO));
            comboBox_Interval_MOBO.SelectedItem = Setting_Interval_MOBO;

            //Interval CPU
            Setting_Interval_CPU = Int32.Parse(Config.GetSetting(SettingTypes.INFO_UPDATE_INTERVAL_CPU));
            comboBox_Interval_CPU.SelectedItem = Setting_Interval_CPU;

            //Interval GPU
            Setting_Interval_GPU = Int32.Parse(Config.GetSetting(SettingTypes.INFO_UPDATE_INTERVAL_GPU));
            comboBox_Interval_GPU.SelectedItem = Setting_Interval_GPU;

            //Interval RAM
            Setting_Interval_RAM = Int32.Parse(Config.GetSetting(SettingTypes.INFO_UPDATE_INTERVAL_RAM));
            comboBox_Interval_RAM.SelectedItem = Setting_Interval_RAM;

            //Window Position
            Setting_Window_Position = Config.GetSetting(SettingTypes.WIN_POS);
            string[] tmp_winPos = Setting_Window_Position.Split(';');
            numericUpDown_Setting_WinPos_X.Value = Int32.Parse(tmp_winPos[0]);
            numericUpDown_Setting_WinPos_Y.Value = Int32.Parse(tmp_winPos[1]);
            
            //Current Window Position
            string[] cur_win_pos = Config.GetSetting(SettingTypes.CUR_WIN_POS).Split(';');
            textBox_Info_CurrentPos_X.Text = cur_win_pos[0];
            textBox_Info_CurrentPos_Y.Text = cur_win_pos[1];

        }

        #region ComboBoxes Selection
        private void comboBox_Interval_MOBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setting_Interval_MOBO = Intervals[comboBox_Interval_MOBO.SelectedIndex];
        }

        private void comboBox_Interval_CPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setting_Interval_CPU = Intervals[comboBox_Interval_CPU.SelectedIndex];
        }

        private void comboBox_Interval_GPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setting_Interval_GPU = Intervals[comboBox_Interval_GPU.SelectedIndex];
        }

        private void comboBox_Interval_RAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setting_Interval_RAM = Intervals[comboBox_Interval_RAM.SelectedIndex];
        }


        #endregion ComboBoxes Selection

        #region Window Position Stuff
        private void current_window_pos_update_timer_Tick(object sender, EventArgs e)
        {
            string[] win_pos = Config.GetSetting(SettingTypes.CUR_WIN_POS).Split(';');
            textBox_Info_CurrentPos_X.Text = win_pos[0];
            textBox_Info_CurrentPos_Y.Text = win_pos[1];
        }

        private void numericUpDown_Setting_WinPos_X_ValueChanged(object sender, EventArgs e)
        {
            Setting_Window_Position = numericUpDown_Setting_WinPos_X.Value + ";" + numericUpDown_Setting_WinPos_Y.Value;
        }

        private void numericUpDown_Setting_WinPos_Y_ValueChanged(object sender, EventArgs e)
        {
            Setting_Window_Position = numericUpDown_Setting_WinPos_X.Value + ";" + numericUpDown_Setting_WinPos_Y.Value;
        }
        #endregion Window Position Stuff

        #region CheckBoxes
        private void checkBox_panel_autostart_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("UNFINISHED", "UNFINISHED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion CheckBoxes

        #region Buttons
        private void button_saveSettings_Click(object sender, EventArgs e)
        {
            Config.WriteSetting(SettingTypes.INFO_UPDATE_INTERVAL_MOBO, Setting_Interval_MOBO.ToString());
            Config.WriteSetting(SettingTypes.INFO_UPDATE_INTERVAL_CPU, Setting_Interval_CPU.ToString());
            Config.WriteSetting(SettingTypes.INFO_UPDATE_INTERVAL_GPU, Setting_Interval_GPU.ToString());
            Config.WriteSetting(SettingTypes.INFO_UPDATE_INTERVAL_RAM, Setting_Interval_RAM.ToString());
            Config.WriteSetting(SettingTypes.WIN_POS, Setting_Window_Position);

            MessageBox.Show("Settings Saved!", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_restartPanel_Click(object sender, EventArgs e)
        {
            string taskname = "SensorPanelWinForms";
            string processName = taskname;
            string fixstring = taskname.Replace(".exe", "");
            if (taskname.Contains(".exe"))
            {
                foreach (Process process in Process.GetProcessesByName(fixstring))
                {
                    process.Kill();
                    process.WaitForExit();
                }
            }
            else if (!taskname.Contains(".exe"))
            {
                foreach (Process process in Process.GetProcessesByName(processName))
                {
                    process.Kill();
                    process.WaitForExit();
                }
            }
            Process.Start(Path.Combine(Environment.CurrentDirectory, "SensorPanelWinForms.exe"));
        }

        private void button_close_panel_Click(object sender, EventArgs e)
        {
            string taskname = "SensorPanelWinForms";
            string processName = taskname;
            string fixstring = taskname.Replace(".exe", "");
            if (taskname.Contains(".exe"))
            {
                foreach (Process process in Process.GetProcessesByName(fixstring))
                {
                    process.Kill();
                    process.WaitForExit();
                }
            }
            else if (!taskname.Contains(".exe"))
            {
                foreach (Process process in Process.GetProcessesByName(processName))
                {
                    process.Kill();
                    process.WaitForExit();
                }
            }
        }

        private void button_useCurPos_Click(object sender, EventArgs e)
        {
            string[] win_pos = Config.GetSetting(SettingTypes.CUR_WIN_POS).Split(';');
            numericUpDown_Setting_WinPos_X.Value = Convert.ToDecimal(win_pos[0]);
            numericUpDown_Setting_WinPos_Y.Value = Convert.ToDecimal(win_pos[1]);
        }
        #endregion Buttons
    }
}
