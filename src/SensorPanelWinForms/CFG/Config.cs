using System;
using SensorPanelWinForms.Utils;

namespace SensorPanelWinForms.CFG
{
    public class Config
    {
        private const string RegistryConfigPath = "HKEY_CURRENT_USER\\SOFTWARE\\P!X_Softwares\\SensorPanel";

        public static void CheckConfig()
        {
            //Test
            if(WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.TEST.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.TEST.ToString(), "Registry Read Test");
            }

            //Window Position
            if(WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.WIN_POS.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.WIN_POS.ToString(), "0;0");//Test Monitor TOPLEFT x = 1920  y = 981
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.CUR_WIN_POS.ToString(), "0;0");
            }

            //Update Interval Mobo
            if (WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.INFO_UPDATE_INTERVAL_MOBO.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.INFO_UPDATE_INTERVAL_MOBO.ToString(), "1000");
            }

            //Update Interval Cpu
            if (WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.INFO_UPDATE_INTERVAL_CPU.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.INFO_UPDATE_INTERVAL_CPU.ToString(), "1000");
            }

            //Update Interval Gpu
            if (WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.INFO_UPDATE_INTERVAL_GPU.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.INFO_UPDATE_INTERVAL_GPU.ToString(), "1000");
            }

            //Update Interval Ram
            if (WinRegistry.ReadRegistry(RegistryConfigPath, SettingTypes.INFO_UPDATE_INTERVAL_RAM.ToString(), "UNKNOWN") == "UNKNOWN")
            {
                WinRegistry.WriteRegistry(RegistryConfigPath, SettingTypes.INFO_UPDATE_INTERVAL_RAM.ToString(), "1000");
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
