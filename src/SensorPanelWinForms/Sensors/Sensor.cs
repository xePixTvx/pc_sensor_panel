using System;

//Mobo infos without Aida64 = Registry HKEY_LOCAl_MACHINE\\HARDWARE\\DESCRIPTION\\System\\Bios
//CPU Name = Registry HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0 --- ProcessorNameString

namespace SensorPanelWinForms.Sensors
{
    public class Sensor
    {
        private const string RegistryPathAida64 = "HKEY_CURRENT_USER\\SOFTWARE\\FinalWire\\AIDA64\\SensorValues";
        private const string RegistryPathCPUInfo = "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0";



        public static string GetSensorValue(SensorTypes SensorType)
        {
            if(SensorType == SensorTypes.CPU_NAME)
            {
                return Utils.WinRegistry.ReadRegistry(RegistryPathCPUInfo, GetRegKeyBySensorType(SensorType), "UNKNOWN");
            }
            return Utils.WinRegistry.ReadRegistry(RegistryPathAida64, GetRegKeyBySensorType(SensorType), "UNKNOWN");
        }



        private static string GetRegKeyBySensorType(SensorTypes SensorType)
        {
            switch (SensorType.ToString())
            {
                //MOBO
                case "MOBONAME":
                    return "Value.SMOBONAME";

                case "BIOSVERSION":
                    return "Value.SBIOSVER";

                case "TEMP_MOBO":
                    return "Value.TMOBO";

                case "TEMP_MOBO_CHIP":
                    return "Value.TCHIP";



                //CPU
                case "CPU_NAME":
                    return "ProcessorNameString";

                case "TEMP_CPU":
                    return "Value.TCPU";

                case "TEMP_CPU_DIODE":
                    return "Value.TCPUDIO";

                case "CPU_USAGE":
                    return "Value.SCPUUTI";



                //GPU
                case "TEMP_GPU":
                    return "Value.TGPU1DIO";

                case "GPU_USAGE":
                    return "Value.SGPU1UTI";



                //RAM
                case "RAM_USAGE":
                    return "Value.SMEMUTI";

                case "RAM_USED":
                    return "Value.SUSEDMEM";

                case "RAM_FREE":
                    return "Value.SFREEMEM";







                default:
                    return "UNKNOWN";
            }
        }





    }
}
