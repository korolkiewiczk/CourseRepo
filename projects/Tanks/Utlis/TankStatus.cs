using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Utlis
{
    class TankStatus
    {
        public string Angle { get; }
        public string Power { get; }

        public TankStatus(double angle, double power, double maxPower)
        {
            Angle = (angle*180.0/Math.PI).ToString();
            Power = Math.Round(100 * power / maxPower) + "%";
        }

        public override string ToString()
        {
            return "Angle: " + Angle + "   Power: " + Power;
        }
    }
}
