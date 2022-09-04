using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Events
{

    class Person
    {
        private string _name;
        private ClockTower _tower;

        public Person(string name, ClockTower tower)
        {
            _name = name;
            _tower = tower;

            _tower.Chime += (object sender, ClockTowerEventArgs args) =>
            {
                Console.WriteLine(" {0} heard the clock chime.", _name);

                switch (args.Time)
                {
                    case 6: Console.WriteLine(" {0} is waking up.", _name);
                        break;
                    case 17: Console.WriteLine(" {0} is going home.", _name);
                        break;
                }

            };
        }
    }
}
