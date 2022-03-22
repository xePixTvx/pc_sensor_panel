using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Panel_Shared.CFG;
using Panel_Shared.Sensors;

//Screens/Boxes:
//MOBO
//CPU
//GPU

namespace PanelViewer
{
    public partial class Form1 : Form
    {
        //Debug Stuff
        const bool DEBUG_QUICK_INTRO = false;//false for release


        //Intro Stuff
        private bool Intro_Progress_Loaded = false;
        private int Intro_MoveOutTicks = 0;

        //Screens Stuff
        private List<Screen> ScreenList = new List<Screen>();
        private Cycling Cycler;


        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;//false for release
            TopMost = true;

            Config.CheckConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get Window Pos From Registry
            string[] win_pos = Config.GetSetting(SettingTypes.WIN_POS).Split(';');
            Location = new System.Drawing.Point(Int32.Parse(win_pos[0]), Int32.Parse(win_pos[1]));//new System.Drawing.Point(0, 0);

            //Get Time between screen changes
            int screenTime = Int32.Parse(Config.GetSetting(SettingTypes.SCREEN_TIME));
            nextScreen_Timer.Interval = screenTime;

            //Get Sensor Update Interval
            int updateInterval = Int32.Parse(Config.GetSetting(SettingTypes.SENSOR_UPDATE_INTERVAL));
            sensorUpdate_Timer.Interval = updateInterval;


            //Start Intro
            StartIntro();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            //Update Current Location in Registry
            Config.WriteSetting(SettingTypes.CUR_WIN_POS, Location.X + ";" + Location.Y);
        }

        #region Intro
        private void StartIntro()
        {
            intro_timer.Start();
        }
        private void intro_timer_Tick(object sender, EventArgs e)
        {
            int minus_x = (!DEBUG_QUICK_INTRO) ? 20 : 50;
            if(!Intro_Progress_Loaded)
            {
                if (GroupBox_Intro.Location.X > 3)
                {
                    GroupBox_Intro.Location = new System.Drawing.Point(GroupBox_Intro.Location.X - minus_x, GroupBox_Intro.Location.Y);
                }
                else
                {
                    GroupBox_Intro.Location = new System.Drawing.Point(3, 34);
                    if(!DEBUG_QUICK_INTRO)
                    {
                        intro_timer.Interval = 50;
                    }
                    else
                    {
                        intro_timer.Interval = 1;
                    }
                    if (intro_progress.Value < 100)
                    {
                        intro_progress.Value++;
                        intro_progress_value.Text = intro_progress.Value + "%";
                    }
                    else
                    {
                        intro_progress.Value = 100;
                        Intro_Progress_Loaded = true;
                    }
                }
            }
            else
            {
                intro_timer.Interval = 1;
                Intro_MoveOutTicks++;
                int neededTicks = (!DEBUG_QUICK_INTRO) ? 120 : 20;
                if(Intro_MoveOutTicks > neededTicks)
                {
                    if (GroupBox_Intro.Location.X > -1000)
                    {
                        GroupBox_Intro.Location = new System.Drawing.Point(GroupBox_Intro.Location.X - minus_x, GroupBox_Intro.Location.Y);
                    }
                    else
                    {
                        GroupBox_Intro.Location = new System.Drawing.Point(-1000, 34);
                        StartPanelStuff();
                        intro_timer.Stop();
                    }
                }
            }
        }
        #endregion Intro

        #region Panel Stuff
        private void StartPanelStuff()
        {
            //Common
            MainForm.Text = "USER: " + Environment.UserName;

            //MOBO
            mobo_info_name.Text = Sensor.GetSensorValue(SensorTypes.MOBONAME);
            mobo_info_biosVersion.Text = Sensor.GetSensorValue(SensorTypes.BIOSVERSION);

            //CPU
            cpu_info_name.Text = Sensor.GetSensorValue(SensorTypes.CPU_NAME);

            //GPU
            gpu_info_name.Text = "NVIDIA GeForce RTX 2060(6GB) Asus OC Version";//Hardcoded atm

            //Add Screens
            ScreenList.Add(new Screen(0, "MOBO", GroupBox_MOBO, Screen.POSITIONS.RIGHT, Update_Infos_Mobo));
            ScreenList.Add(new Screen(1, "CPU", GroupBox_CPU, Screen.POSITIONS.RIGHT, Update_Infos_Cpu));
            ScreenList.Add(new Screen(2, "GPU", GroupBox_GPU, Screen.POSITIONS.RIGHT, Update_Infos_Gpu));

            //Start Sensor Updating
            sensorUpdate_Timer.Start();

            //Create Cycler
            Cycler = new Cycling(ScreenList);
            nextScreen_Timer.Start();
        }


        //Screen Change Timer Tick
        private void nextScreen_Timer_Tick(object sender, EventArgs e)
        {
            Cycler.NextScreen();
        }

        //Sensor Update Timer Tick
        private void sensorUpdate_Timer_Tick(object sender, EventArgs e)
        {
            foreach(Screen screen in ScreenList)
            {
                if(screen.CycleIndex == Cycler.CurrentScreen)
                {
                    if(screen.UpdateFunction != null)
                    {
                        screen.UpdateFunction();
                    }
                }
            }
        }



        private void Update_Infos_Mobo()
        {
            //Get Info From Sensor
            string tmp_mobo_main_temp = Sensor.GetSensorValue(SensorTypes.TEMP_MOBO);
            string tmp_mobo_chip_temp = Sensor.GetSensorValue(SensorTypes.TEMP_MOBO_CHIP);

            mobo_mainTemp_progress.Value = (tmp_mobo_main_temp != "UNKNOWN") ? Int32.Parse(tmp_mobo_main_temp) : 0;
            mobo_chipTemp_progress.Value = (tmp_mobo_chip_temp != "UNKNOWN") ? Int32.Parse(tmp_mobo_chip_temp) : 0;
        }

        private void Update_Infos_Cpu()
        {
            //Get Info From Sensor
            string tmp_cpu_main_temp = Sensor.GetSensorValue(SensorTypes.TEMP_CPU);
            string tmp_cpu_diode_temp = Sensor.GetSensorValue(SensorTypes.TEMP_CPU_DIODE);
            string tmp_cpu_usage = Sensor.GetSensorValue(SensorTypes.CPU_USAGE);

            cpu_mainTemp_progress.Value = (tmp_cpu_main_temp != "UNKNOWN") ? Int32.Parse(tmp_cpu_main_temp) : 0;
            cpu_diodeTemp_progress.Value = (tmp_cpu_main_temp != "UNKNOWN") ? Int32.Parse(tmp_cpu_diode_temp) : 0;
            cpu_usage_progress.Value = (tmp_cpu_usage != "UNKNOWN") ? Int32.Parse(tmp_cpu_usage) : 0;
            cpu_usage_progress_value.Text = tmp_cpu_usage + "%";
        }

        private void Update_Infos_Gpu()
        {
            //Get Info From Sensor
            string tmp_gpu_temp = Sensor.GetSensorValue(SensorTypes.TEMP_GPU);
            string tmp_gpu_usage = Sensor.GetSensorValue(SensorTypes.GPU_USAGE);

            gpu_mainTemp_progress.Value = (tmp_gpu_temp != "UNKNOWN") ? Int32.Parse(tmp_gpu_temp) : 0;
            gpu_usage_progress.Value = (tmp_gpu_usage != "UNKNOWN") ? Int32.Parse(tmp_gpu_usage) : 0;
            gpu_usage_progress_value.Text = tmp_gpu_usage + "%";
        }


        #endregion Panel Stuff
    }
}
