using System;
using System.Windows.Forms;


/*
 * Location Middle: 3; 34
 * Location Left: -1000; 34
 * Location Right 1000; 34
 */


namespace PanelViewer
{
    internal class Screen
    {
        public int CycleIndex { get; private set; }
        public string Name { get; private set; }
        private Login_Theme.LogInGroupBox Box;
        private Timer MoveTimer;

        public Action UpdateFunction { get; private set; }


        public enum POSITIONS
        {
            MIDDLE,
            LEFT,
            RIGHT
        };

        public bool IsMoving { get; private set; }
        public POSITIONS CurrentPosition { get; private set; }
        private int MoveDirection;

        public Screen(int cycleIndex, string name, Login_Theme.LogInGroupBox box, POSITIONS startPos = POSITIONS.RIGHT, Action updateFunc = null)
        {
            CycleIndex = cycleIndex;
            Name = name;
            UpdateFunction = updateFunc;

            Box = box;
            Box.Location = GetLocationCords(startPos);

            CurrentPosition = startPos;
            IsMoving = false;
            MoveDirection = -1;

            MoveTimer = new Timer();
            MoveTimer.Interval = 1;
            MoveTimer.Tick += onMoveTimerTick;
            MoveTimer.Stop();
        }

        public void MoveToDirect(POSITIONS pos)
        {
            CurrentPosition = pos;
            IsMoving = false;
            MoveTimer.Stop();
            Box.Location = GetLocationCords(CurrentPosition);
        }

        public void MoveToAnimated(POSITIONS pos)
        {
            if (!IsMoving && (CurrentPosition != pos))
            {
                CurrentPosition = pos;

                if (Box.Location.X < GetLocationCords(CurrentPosition).X)
                {
                    MoveDirection = 1;
                }
                else
                {
                    MoveDirection = -1;
                }

                IsMoving = true;
                MoveTimer.Start();
            }
        }

        private void onMoveTimerTick(object sender, EventArgs e)
        {
            if(IsMoving)
            {
                if((Box.Location.X > GetLocationCords(CurrentPosition).X) && (MoveDirection == -1))
                {
                    Box.Location = new System.Drawing.Point(Box.Location.X - 20, 34);
                }
                else if((Box.Location.X < GetLocationCords(CurrentPosition).X) && (MoveDirection == 1))
                {
                    Box.Location = new System.Drawing.Point(Box.Location.X + 20, 34);
                }
                else
                {
                    IsMoving = false;
                    Box.Location = GetLocationCords(CurrentPosition);
                    MoveTimer.Stop();
                    //Console.WriteLine("MOVEMENT DONE!");
                }
            }
        }

        private System.Drawing.Point GetLocationCords(POSITIONS pos)
        {
            if(pos == POSITIONS.MIDDLE)
            {
                return new System.Drawing.Point(3, 34);
            }
            else if(pos == POSITIONS.LEFT)
            {
                return new System.Drawing.Point(-1000, 34);
            }
            else
            {
                return new System.Drawing.Point(1000, 34);
            }
        }
    }
}
