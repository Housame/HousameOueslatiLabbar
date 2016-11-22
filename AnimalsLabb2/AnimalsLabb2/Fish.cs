using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLabb2
{
    class Fish : Animal
    {
        public string Environement { get; set; }

        public string SwimWalkFlyBurrow { get; set; }

        public override string Move()
        {
            return string.Format(base.Move(), " and {0}.", SwimWalkFlyBurrow);
        }
    }
}
