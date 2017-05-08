using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanksGame
{
    interface TankInterface
    {
        void move(Direction direction);
        void fire();
        void draw(PaintEventArgs e);
    }
}
