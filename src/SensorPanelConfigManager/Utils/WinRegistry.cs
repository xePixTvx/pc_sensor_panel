using System;
using Microsoft.Win32;

namespace SensorPanelConfigManager.Utils
{
    public class WinRegistry
    {

        //Simple Read from WinRegistry
        public static string ReadRegistry(string path, string key, string def)
        {
            string value = "UNKNOWN";
            var reg_out = Registry.GetValue(path, key, def);
            if (reg_out != null)
            {
                value = (string)reg_out;
            }
            return value;
        }


        //Simple Write to WinRegistry
        public static void WriteRegistry(string path, string key, string value)
        {
            Registry.SetValue(path, key, value);
        }


    }
}
