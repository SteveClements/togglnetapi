using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Models
{
    public class Client : ITogglModel
    {
        public int id { get; set; }
        public int wid { get; set; }
        public string name { get; set; }
        public string at { get; set; }
        public string server_deleted_at { get; set; }
    }
}
