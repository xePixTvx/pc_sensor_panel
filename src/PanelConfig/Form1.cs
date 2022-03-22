using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using Panel_Shared.CFG;


//LAST WORKED ON: Position Tab


namespace PanelConfig
{
    public partial class Form1 : Form
    {
        private int[] Setting_WinPos;
        private int Setting_ScreenTime;
        private int Setting_SensorUpdateInterval;


        public Form1()
        {
            InitializeComponent();

            //Check Config
            Config.CheckConfig();

            //Get Position Setting
            string[] tmp_winPos = Config.GetSetting(SettingTypes.WIN_POS).Split(';');
            Setting_WinPos = new int[] { Int32.Parse(tmp_winPos[0]), Int32.Parse(tmp_winPos[1]) };
            PositionX_Numeric.Value = Setting_WinPos[0];
            PositionY_Numeric.Value = Setting_WinPos[1];

            //Get Screen Time Setting
            Setting_ScreenTime = Int32.Parse(Config.GetSetting(SettingTypes.SCREEN_TIME));
            ScreenTime_Numeric.Value = Setting_ScreenTime / 1000;

            //Get Sensor Update Interval Setting
            Setting_SensorUpdateInterval = Int32.Parse(Config.GetSetting(SettingTypes.SENSOR_UPDATE_INTERVAL));
            SensorUpdateInterval_Numeric.Value = Setting_SensorUpdateInterval / 1000;
        }

        //Exit App
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Update Current Window Position
        private void updateCurrentWinPos_Timer_Tick(object sender, EventArgs e)
        {
            string[] tmp_curWinPos = Config.GetSetting(SettingTypes.CUR_WIN_POS).Split(';');
            PanelCurrent_PosX.Text = tmp_curWinPos[0];
            PanelCurrent_PosY.Text = tmp_curWinPos[1];
        }


        #region Main Tab

        //Close Panel Button
        private void Button_ClosePanel_Click(object sender, EventArgs e)
        {
            string taskname = "Mario's Senor Panel - Viewer";
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

        //Start/restart Panel Button
        private void Button_StartRestartPanel_Click(object sender, EventArgs e)
        {
            string taskname = "Mario's Senor Panel - Viewer";
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
            Process.Start(Path.Combine(Environment.CurrentDirectory, taskname + ".exe"));
        }

        //Sensor Update Interval Update
        private void SensorUpdateInterval_Numeric_Click(object sender, EventArgs e)
        {
            Setting_SensorUpdateInterval = (int)SensorUpdateInterval_Numeric.Value * 1000;
        }

        //Screen Time Update
        private void ScreenTime_Numeric_Click(object sender, EventArgs e)
        {
            Setting_ScreenTime = (int)ScreenTime_Numeric.Value * 1000;
        }




        //Save Button
        private void Button_Save_Click(object sender, EventArgs e)
        {
            //Win Pos
            Config.WriteSetting(SettingTypes.WIN_POS, Setting_WinPos[0].ToString() + ";" + Setting_WinPos[1].ToString());

            //Sensor Update Interval
            Config.WriteSetting(SettingTypes.SENSOR_UPDATE_INTERVAL, Setting_SensorUpdateInterval.ToString());

            //Screen Time
            Config.WriteSetting(SettingTypes.SCREEN_TIME, Setting_ScreenTime.ToString());


            MessageBox.Show("Settings Saved!", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        #endregion Main Tab


        #region Position Tab

        //X
        private void PositionX_Numeric_Click(object sender, EventArgs e)
        {
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }
        private void PositionX_plus5_Click(object sender, EventArgs e)
        {
            PositionX_Numeric.Value += 5;
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }
        private void PositionX_plus10_Click(object sender, EventArgs e)
        {
            PositionX_Numeric.Value += 10;
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }
        private void PositionX_plus50_Click(object sender, EventArgs e)
        {
            PositionX_Numeric.Value += 50;
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }
        private void PositionX_plus100_Click(object sender, EventArgs e)
        {
            PositionX_Numeric.Value += 100;
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }
        private void PositionX_minus5_Click(object sender, EventArgs e)
        {
            PositionX_Numeric.Value -= 5;
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }
        private void PositionX_minus10_Click(object sender, EventArgs e)
        {
            PositionX_Numeric.Value -= 10;
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }
        private void PositionX_minus50_Click(object sender, EventArgs e)
        {
            PositionX_Numeric.Value -= 50;
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }
        private void PositionX_minus100_Click(object sender, EventArgs e)
        {
            PositionX_Numeric.Value -= 100;
            Setting_WinPos[0] = (int)PositionX_Numeric.Value;
        }

        //Y
        private void PositionY_Numeric_Click(object sender, EventArgs e)
        {
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }
        private void PositionY_plus5_Click(object sender, EventArgs e)
        {
            PositionY_Numeric.Value += 5;
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }
        private void PositionY_plus10_Click(object sender, EventArgs e)
        {
            PositionY_Numeric.Value += 10;
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }
        private void PositionY_plus50_Click(object sender, EventArgs e)
        {
            PositionY_Numeric.Value += 50;
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }
        private void PositionY_plus100_Click(object sender, EventArgs e)
        {
            PositionY_Numeric.Value += 100;
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }
        private void PositionY_minus5_Click(object sender, EventArgs e)
        {
            PositionY_Numeric.Value -= 5;
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }
        private void PositionY_minus10_Click(object sender, EventArgs e)
        {
            PositionY_Numeric.Value -= 10;
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }
        private void PositionY_minus50_Click(object sender, EventArgs e)
        {
            PositionY_Numeric.Value -= 50;
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }
        private void PositionY_minus100_Click(object sender, EventArgs e)
        {
            PositionY_Numeric.Value -= 100;
            Setting_WinPos[1] = (int)PositionY_Numeric.Value;
        }


        //Use CurrentPos Button
        private void Button_UseCurrentPosition_Click(object sender, EventArgs e)
        {
            string[] tmp_curWinPos = Config.GetSetting(SettingTypes.CUR_WIN_POS).Split(';');
            PositionX_Numeric.Value = Int32.Parse(tmp_curWinPos[0]);
            PositionY_Numeric.Value = Int32.Parse(tmp_curWinPos[1]);
        }



        #endregion Position Tab
    }
}
