using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Utility
{
    public class FireEventArgs: EventArgs
    {
        public int CurrentTemperature { get; set; }

        public int HighestTemperature { get; set; }
    }
}
