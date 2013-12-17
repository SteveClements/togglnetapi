using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Models
{
    public class Project : ITogglModel
    {
        public int id { get; set; }
        public int wid { get; set; }
        public int cid { get; set; }
        public string name { get; set; }
        public bool billable { get; set; }
        public bool is_private { get; set; }
        public bool active { get; set; }
        public bool template { get; set; }
        public string at { get; set; }
        public string created_at { get; set; }
        public string color { get; set; }
        public bool auto_estimates { get; set; }
        public string guid { get; set; }
    }
}
