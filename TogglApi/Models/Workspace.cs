using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Models
{
    public class Workspace : ITogglModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool premium { get; set; }
        public bool admin { get; set; }
        public int default_hourly_rate { get; set; }
        public string default_currency { get; set; }
        public bool only_admins_may_create_projects { get; set; }
        public bool only_admins_see_billable_rates { get; set; }
        public int rounding { get; set; }
        public int rounding_minutes { get; set; }
        public string at { get; set; }
        public string logo_url { get; set; }
    }
}
