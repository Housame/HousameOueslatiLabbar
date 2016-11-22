using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLabb2
{
    class Bird : Animal
    {
        public string CanFlyOrnot { get; set; }

        public override string Move()
        {
            return string.Format(base.Move(), "and {0}", CanFlyOrnot);
        }
    }
}
