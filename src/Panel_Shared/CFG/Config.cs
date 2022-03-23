using System;
using Panel_Shared.Utils;

namespace Panel_Shared.CFG
{
    public class Config
    {
        private const string RegistryConfigPath = "HKEY_CURRENT_USER\\SOFTWARE\\P!X_Softwares\\SensorPanel";

        public static void CheckConfig()
        {
            //Test
            if (WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.TEST.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.TEST.ToString(), "Registry Read Test");
            }

            //Window Position
            if (WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.WIN_POS.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.WIN_POS.ToString(), "0;0");//Test Monitor TOPLEFT x = 1920  y = 981
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.CUR_WIN_POS.ToString(), "0;0");
            }

            //Screen Time
            if(WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.SCREEN_TIME.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.SCREEN_TIME.ToString(), "10000");
            }

            //Sensor Update Interval
            if (WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.SENSOR_UPDATE_INTERVAL.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.SENSOR_UPDATE_INTERVAL.ToString(), "1000");
            }

            //Accent Color
            if (WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.ACCENT_COLOR.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.ACCENT_COLOR.ToString(), "255;255;255");
            }
        }

        public static string GetSetting(SettingTypes type)
        {
            return WinRegistry.ReadRegistry(RegistryConfigPath, type.ToString(), "UNKNOWN");
        }

        public static void WriteSetting(SettingTypes type, string value)
        {
            WinRegistry.WriteRegistry(RegistryConfigPath, type.ToString(), value);
        }
    }
}
