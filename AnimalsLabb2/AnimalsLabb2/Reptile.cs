using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLabb2
{
    class Reptile : Animal
    {
        public int NumberOfLegs { get; set; }

        public string SlitherWalkSwim { get; set; }

        public override string Move()
        {
            return string.Format(base.Move(), "and moves arround by {0}", SlitherWalkSwim);
        }
    }
}
