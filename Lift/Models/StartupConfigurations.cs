using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lift.Models
{
    public class StartupConfigurations
    {
        public bool ModelWorkSystem { get; set; } = false;
        public int Lifts { get; set; } = 3;
        public int PeopleInLift { get; set; } = 5;
        public double SpeedOfLift { get; set; } = 0;
        public double AccelerationOfLift { get; set; } = 0;
    }
}
