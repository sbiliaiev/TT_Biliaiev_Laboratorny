using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public interface IMotor
    {
        int Speed { get; }
        WayOfRotation CurrentDirection { get; }
        void Start(WayOfRotation senseOfRotation);
        void Stop();
        void SpeedUp(int increment);
        void SpeedDown(int increment);
    }
}
