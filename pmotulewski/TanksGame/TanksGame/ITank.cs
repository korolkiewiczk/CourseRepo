using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanksGame
{
    interface ITank
    {
        void Move(Direction direction);
        void ChangeAngleAndPower(Direction power, Direction angle);
        void Fire();
        void Draw(Graphics g);
    }
}
