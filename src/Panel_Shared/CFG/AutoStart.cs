using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_Shared.CFG
{
    public class AutoStart
    {
        private const string AutoStartTaskName = "P!XSensorPanelAutoStartTask";

        public static void EnableAutoStart()
        {
        }

        public static void DisableAutoStart()
        {
            /////////////////////////TESTING/////////////////////////////////////////////
            using (TaskService tService = new TaskService())
            {
                if (tService.GetTask(AutoStartTaskName) != null)
                {
                    tService.RootFolder.DeleteTask(AutoStartTaskName);
                }
            }
            /////////////////////////TESTING/////////////////////////////////////////////
        }





    }
}
