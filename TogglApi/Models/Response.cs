using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Models
{
    public abstract class TogglResponse<T> where T : ITogglModel
    {
        public int since { get; set; }
        public abstract T data { get; set; }
    }

    public class UserResponse : TogglResponse<User>
    {
        public override User data { get; set; }
    }

    public class ClientResponse : TogglResponse<Client>
    {
        public override Client data { get; set; }
    }
}
