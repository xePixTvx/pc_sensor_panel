using Microsoft.Win32.TaskScheduler;
using System;
using System.IO;

namespace Panel_Shared.CFG
{
    public class AutoStart
    {
        private const string AutoStartTaskName = "P!XSensorPanelAutoStartTask";

        public static void Enable(double autoStartDelayTimeValue = 2, AutoStartDelayTypes autoStartDelayType = AutoStartDelayTypes.MIN)
        {
            using (TaskService tService = new TaskService())
            {
                if (!TaskExists(tService, AutoStartTaskName))
                {
                    CreateAutoStartTask(tService, AutoStartTaskName, autoStartDelayTimeValue, autoStartDelayType);
                }
                else
                {
                    DestroyAutoStartTask(tService, AutoStartTaskName);
                    CreateAutoStartTask(tService, AutoStartTaskName, autoStartDelayTimeValue, autoStartDelayType);
                }
            }
        }

        public static void Disable()
        {
            using (TaskService tService = new TaskService())
            {
                if (TaskExists(tService, AutoStartTaskName))
                {
                    DestroyAutoStartTask(tService, AutoStartTaskName);
                }
            }
        }




        //Create Task
        private static void CreateAutoStartTask(TaskService tServ, string taskName, double autoStartDelayTimeValue, AutoStartDelayTypes autoStartDelayType)
        {
            //Create Task
            TaskDefinition task = tServ.NewTask();
            task.RegistrationInfo.Author = "Mario's Senor Panel - Config Manager";

            //Task Action
            task.Actions.Add(new ExecAction(Path.Combine(Environment.CurrentDirectory, "Mario's Senor Panel - Viewer.exe"), null, null));

            //Task Trigger(on Windows Login -- optional with delay)
            if(autoStartDelayType == AutoStartDelayTypes.MIN)
            {
                task.Triggers.Add(new LogonTrigger { Delay = TimeSpan.FromMinutes(autoStartDelayTimeValue) });
                task.RegistrationInfo.Description = "Start Delay = " + autoStartDelayTimeValue + " Minutes";
            }
            else
            {
                task.Triggers.Add(new LogonTrigger { Delay = TimeSpan.FromSeconds(autoStartDelayTimeValue) });
                task.RegistrationInfo.Description = "Start Delay = " + autoStartDelayTimeValue + " Seconds";
            }


            //Add task to taskservice
            tServ.RootFolder.RegisterTaskDefinition(taskName, task);
        }


        //Remove/Delete/Destroy Task
        private static void DestroyAutoStartTask(TaskService tServ, string taskName)
        {
            tServ.RootFolder.DeleteTask(taskName);
        }


        //Check if task exists
        private static bool TaskExists(TaskService service, string taskName)
        {
            if (service.GetTask(taskName) != null)
            {
                return true;
            }
            return false;
        }


    }
}
