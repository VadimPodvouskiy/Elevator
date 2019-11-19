using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lift.Models
{
    public class StartupConfigurations
    {
        public bool ModelWorkSystem { get; set; }
        public int Lifts { get; set; }
        public int Floors { get; set; }
        public int PeopleInLift { get; set; }
        public double SpeedOfLift { get; set; }
        public double AccelerationOfLift { get; set; }
    }
}
