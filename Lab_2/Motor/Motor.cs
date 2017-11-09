using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Motor : IMotor
    {
        private int _currentSpeed;
        private WayOfRotation wayOfRotation;

        public Motor()
        {
            _currentSpeed = 0;
            wayOfRotation = WayOfRotation.Stopped;
        }

        public int Speed
        {
            get { return _currentSpeed; }
            set { _currentSpeed = value; }
        }

        public WayOfRotation CurrentDirection
        {
            get { return wayOfRotation; }
            set { wayOfRotation = value; }
        }

        public void Start(WayOfRotation senseOfRotation)
        {
            if (senseOfRotation == WayOfRotation.Left)
            {
                throw new InvalidOperationException();
            }
            else if (senseOfRotation == WayOfRotation.Right)
            {
                Stop();
            }

            wayOfRotation = senseOfRotation;
            _currentSpeed = 1;
        }

        public void Stop()
        {
            Speed = 0;
            CurrentDirection = WayOfRotation.Stopped;
        }

        public void SpeedUp(int increment)
        {
            if (increment == 10)
            {
                Speed = 10;
            }
            else if (increment == 1)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Speed += increment;
            }
        }

        public void SpeedDown(int increment)
        {
            if (increment == 10)
            {
                Stop();
            }
            else
            {
                Speed -= increment;
            }
        }
    }
}
