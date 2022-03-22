using System.Collections.Generic;

namespace PanelViewer
{
    internal class Cycling
    {
        private List<Screen> Screens;
        public int CurrentScreen { get; private set; }


        public Cycling(List<Screen> screenList)
        {
            Screens = screenList;

            CurrentScreen = 0;
            UpdateCycle(CurrentScreen, 0);
        }


        public void NextScreen()
        {
            UpdateCycle(CurrentScreen, 1);
        }


        private void UpdateCycle(int oldScroller, int direction)
        {
            if(direction == 1)
            {
                CurrentScreen++;
                if (CurrentScreen > Screens.Count - 1)
                {
                    CurrentScreen = 0;
                }
            }
            else
            {
                CurrentScreen = oldScroller;
            }

            for(int i = 0; i < Screens.Count; i++)
            {
                if ((oldScroller == Screens.Count - 1) && (CurrentScreen == 0))
                {
                    if(i == Screens.Count - 1)
                    {
                        if (Screens[i].CurrentPosition != Screen.POSITIONS.LEFT)
                        {
                            Screens[i].MoveToAnimated(Screen.POSITIONS.LEFT);
                        }
                    }
                    else if(i == 0)
                    {
                        if (Screens[i].CurrentPosition != Screen.POSITIONS.MIDDLE)
                        {
                            Screens[i].MoveToAnimated(Screen.POSITIONS.MIDDLE);
                        }
                    }
                    else
                    {
                        Screens[i].MoveToDirect(Screen.POSITIONS.RIGHT);
                    }
                }
                else
                {
                    if (i == CurrentScreen - 1)
                    {
                        if (Screens[i].CurrentPosition != Screen.POSITIONS.LEFT)
                        {
                            Screens[i].MoveToAnimated(Screen.POSITIONS.LEFT);
                        }
                    }
                    else if (i == CurrentScreen)
                    {
                        if (Screens[i].CurrentPosition != Screen.POSITIONS.MIDDLE)
                        {
                            Screens[i].MoveToAnimated(Screen.POSITIONS.MIDDLE);
                        }
                    }
                    else if (i == CurrentScreen + 1)
                    {
                        Screens[i].MoveToDirect(Screen.POSITIONS.RIGHT);
                    }
                    else
                    {
                        Screens[i].MoveToDirect(Screen.POSITIONS.RIGHT);
                    }
                }

            }
        }


    }
}
