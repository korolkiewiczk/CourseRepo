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
        public string Fuel { get; }

        public TankStatus(double angle, double power, int fuel, double maxPower, int maxFuel)
        {
            Angle = (angle*180.0/Math.PI).ToString();
            Power = MakePercent(power, maxPower);
            Fuel = MakePercent(fuel, maxFuel);
        }

        private static string MakePercent(double val, double max)
        {
            return Math.Round(100 * val / max) + "%";
        }

        public override string ToString()
        {
            return "Angle: " + Angle + "   Power: " + Power + "   Fuel: " + Fuel;
        }
    }
}
