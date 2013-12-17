using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Models
{
    public class TogglAuthRequest
    {
        public string ApiToken { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
