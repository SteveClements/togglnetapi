using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Models
{
    public class TimeEntry : ITogglModel
    {
        public int id { get; set; }
        public string guid { get; set; }
        public int wid { get; set; }
        public int pid { get; set; }
        public bool billable { get; set; }
        public string start { get; set; }
        public string stop { get; set; }
        public int duration { get; set; }
        public List<string> tags { get; set; }
        public bool duronly { get; set; }
        public string at { get; set; }
        public string description { get; set; }
    }
}
