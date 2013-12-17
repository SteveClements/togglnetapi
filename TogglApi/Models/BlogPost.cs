using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Models
{
    public class BlogPost : ITogglModel
    {
        public string title { get; set; }
        public string url { get; set; }
        public string category { get; set; }
        public string pub_date { get; set; }
    }
}
