using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Events
{

    public delegate void ChimeEventHandler(object sender, ClockTowerEventArgs args);
    class ClockTower
    {
        public event ChimeEventHandler Chime;

        public void ChimeFivePM()
        {
            Chime(this, new ClockTowerEventArgs {Time = 17 });
        }

        public void ChimeSixPM()
        {
            Chime(this, new ClockTowerEventArgs { Time = 6 });
        }
    }
}
