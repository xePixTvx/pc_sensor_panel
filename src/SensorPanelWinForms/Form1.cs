using System;
using System.Windows.Forms;

using SensorPanelWinForms.Sensors;
using SensorPanelWinForms.CFG;

namespace SensorPanelWinForms
{
    public partial class Form1 : Form
    {
        private int IntroProgressValue = 0;


        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;/////false for Release

            Config.CheckConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get Window Pos From Registry
            string[] win_pos = Config.GetSetting(SettingTypes.WIN_POS).Split(';');
            Form1.ActiveForm.Location = new System.Drawing.Point(Int32.Parse(win_pos[0]), Int32.Parse(win_pos[1]));

            //Get MOBO Info Update Interval from Registry
            mobo_info_update_timer.Interval = Int32.Parse(Config.GetSetting(SettingTypes.INFO_UPDATE_INTERVAL_MOBO));

            //Get CPU Info Update Interval from Registry
            mobo_info_update_timer.Interval = Int32.Parse(Config.GetSetting(SettingTypes.INFO_UPDATE_INTERVAL_CPU));

            //Get GPU Info Update Interval from Registry
            mobo_info_update_timer.Interval = Int32.Parse(Config.GetSetting(SettingTypes.INFO_UPDATE_INTERVAL_GPU));

            //Get RAM Info Update Interval from Registry
            ram_info_update_timer.Interval = Int32.Parse(Config.GetSetting(SettingTypes.INFO_UPDATE_INTERVAL_RAM));

            UpdateOneTimeInfos();

            //Needed Locations for info boxes
            //mobo box location = 12;36
            //cpu box location = 251;36
            //gpu box loaction = 487;36
            //ram box location = 12;289

            //set to out of screen locations
            mobo_info_box.Location = new System.Drawing.Point(-1000, 36);
            cpu_info_box.Location = new System.Drawing.Point(251, -1000);
            gpu_info_box.Location = new System.Drawing.Point(1500, 36);
            ram_info_box.Location = new System.Drawing.Point(-1000, 289);

            intro_timer.Enabled = true;
        }



        #region Update Infos
        private void UpdateOneTimeInfos()
        {
            //COMMON
            MainForm.Text = "USER: " + Environment.UserName;

            //MOBO
            mobo_info_name.Text = Sensor.GetSensorValue(SensorTypes.MOBONAME);
            mobo_info_biosversion.Text = Sensor.GetSensorValue(SensorTypes.BIOSVERSION);

            //CPU
            cpu_info_name.Text = Sensor.GetSensorValue(SensorTypes.CPU_NAME);

            //GPU
            gpu_info_name.Text = "NVIDIA GeForce RTX 2060"; //Hardcoded :(
        }

        //MOBO Infos Update Timer
        private void mobo_info_update_timer_Tick(object sender, EventArgs e)
        {
            //Get Info From Sensor
            string tmp_mobo_main_temp = Sensor.GetSensorValue(SensorTypes.TEMP_MOBO);
            string tmp_mobo_chip_temp = Sensor.GetSensorValue(SensorTypes.TEMP_MOBO_CHIP);

            //Update WinForms
            mobo_info_mainTemp_progress.Value = (tmp_mobo_main_temp != "UNKNOWN") ? Int32.Parse(tmp_mobo_main_temp) : 0;
            mobo_info_chipsetTemp_progress.Value = (tmp_mobo_chip_temp != "UNKNOWN") ? Int32.Parse(tmp_mobo_chip_temp) : 0;
        }

        //CPU Infos Update Timer
        private void cpu_info_update_timer_Tick(object sender, EventArgs e)
        {
            //Get Info From Sensor
            string tmp_cpu_main_temp = Sensor.GetSensorValue(SensorTypes.TEMP_CPU);
            string tmp_cpu_diode_temp = Sensor.GetSensorValue(SensorTypes.TEMP_CPU_DIODE);
            string tmp_cpu_usage = Sensor.GetSensorValue(SensorTypes.CPU_USAGE);

            //Update WinForms
            cpu_info_mainTemp_progress.Value = (tmp_cpu_main_temp != "UNKNOWN") ? Int32.Parse(tmp_cpu_main_temp) : 0;
            cpu_info_diodeTemp_progress.Value = (tmp_cpu_main_temp != "UNKNOWN") ? Int32.Parse(tmp_cpu_diode_temp) : 0;
            cpu_info_usage_progress.Value = (tmp_cpu_usage != "UNKNOWN") ? Int32.Parse(tmp_cpu_usage) : 0;
            cpu_info_usage_progress_value.Text = tmp_cpu_usage + "%";
        }

        //GPU Infos Update Timer
        private void gpu_info_update_timer_Tick(object sender, EventArgs e)
        {
            //Get Info From Sensor
            string tmp_gpu_temp = Sensor.GetSensorValue(SensorTypes.TEMP_GPU);
            string tmp_gpu_usage = Sensor.GetSensorValue(SensorTypes.GPU_USAGE);

            //Update WinForms
            gpu_info_mainTemp_progress.Value = (tmp_gpu_temp != "UNKNOWN") ? Int32.Parse(tmp_gpu_temp) : 0;
            gpu_info_usage_progress.Value = (tmp_gpu_usage != "UNKNOWN") ? Int32.Parse(tmp_gpu_usage) : 0;
            gpu_info_usage_progress_value.Text = tmp_gpu_usage + "%";
        }

        //RAM Infos Update Timer
        private void ram_info_update_timer_Tick(object sender, EventArgs e)
        {
            //Get Info From Sensor
            string tmp_ram_usage = Sensor.GetSensorValue(SensorTypes.RAM_USAGE);
            string tmp_ram_usedMem = Sensor.GetSensorValue(SensorTypes.RAM_USED);
            string tmp_ram_freeMem = Sensor.GetSensorValue(SensorTypes.RAM_FREE);

            //Update WinForms
            ram_info_usage_progress.Value = (tmp_ram_usage != "UNKNOWN") ? Int32.Parse(tmp_ram_usage) : 0;
            ram_info_usage_progress_value.Text = tmp_ram_usage + "%";

            ram_info_usedMem_value.Text = tmp_ram_usedMem;
            ram_info_freeMem_value.Text = tmp_ram_freeMem;

            int freeMemVal = (tmp_ram_freeMem != "UNKNOWN") ? Int32.Parse(tmp_ram_freeMem) : 0;
            int usedMemVal = (tmp_ram_usedMem != "UNKNOWN") ? Int32.Parse(tmp_ram_usedMem) : 0;
            ram_info_totalMem_value.Text = (freeMemVal + usedMemVal).ToString();
        }

        #endregion Update Infos

        #region Intro Stuff
        private void intro_timer_Tick(object sender, EventArgs e)
        {
            if(IntroProgressValue < 100)
            {
                IntroProgressValue++;
                intro_progressbar.Value = IntroProgressValue;
                intro_progress_value.Text = IntroProgressValue + "%";
            }
            else 
            {
                intro_title_label.Visible = false;
                intro_progress_value.Visible = false;
                intro_progressbar.Visible = false;
                app_move_timer.Enabled = true;
                intro_timer.Enabled = false;
            }
        }

        private void app_move_timer_Tick(object sender, EventArgs e)
        {
            if(mobo_info_box.Location.X < 12)
            {
                mobo_info_box.Location = new System.Drawing.Point(mobo_info_box.Location.X + 10, mobo_info_box.Location.Y);
            }
            else
            {
                mobo_info_box.Location = new System.Drawing.Point(12, 36);
            }
            if(cpu_info_box.Location.Y < 36)
            {
                cpu_info_box.Location = new System.Drawing.Point(cpu_info_box.Location.X, cpu_info_box.Location.Y + 10);
            }
            else
            {
                cpu_info_box.Location = new System.Drawing.Point(251, 36);
            }
            if(gpu_info_box.Location.X > 487)
            {
                gpu_info_box.Location = new System.Drawing.Point(gpu_info_box.Location.X - 10, gpu_info_box.Location.Y);
            }
            else
            {
                gpu_info_box.Location = new System.Drawing.Point(487, 36);
            }
            if(ram_info_box.Location.X < 12)
            {
                ram_info_box.Location = new System.Drawing.Point(ram_info_box.Location.X + 10, ram_info_box.Location.Y);
            }
            else
            {
                ram_info_box.Location = new System.Drawing.Point(12, 289);
            }


            if((mobo_info_box.Location.X == 12) && (cpu_info_box.Location.Y == 36) && (gpu_info_box.Location.X == 487) && (ram_info_box.Location.X == 12))
            {
                mobo_info_update_timer.Enabled = true;
                cpu_info_update_timer.Enabled = true;
                gpu_info_update_timer.Enabled = true;
                ram_info_update_timer.Enabled = true;
                app_move_timer.Enabled = false;
            }
        }

        #endregion Intro Stuff

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Config.WriteSetting(SettingTypes.CUR_WIN_POS, Location.X + ";" + Location.Y);
        }
    }
}
