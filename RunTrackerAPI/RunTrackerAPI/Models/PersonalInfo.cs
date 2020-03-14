using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunTrackerAPI.Models
{
    public class PersonalInfo
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime birthdate { get; set; }

        public int height { get; set; }

        public int weight { get; set; }
    }
}
