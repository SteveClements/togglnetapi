using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogglApi.Entities;
using TogglApi.Models;

namespace TogglApi
{
    public class TogglApi
    {
        Users _users;
        Clients _clients;

        TogglAuthRequest _authRequest;
        public TogglApi(TogglAuthRequest authRequest)
        {
            _authRequest = authRequest;
        }

        public Users Users
        {
            get { if (_users == null) _users = new Users(_authRequest); return _users; }
        }

        public Clients Clients
        {
            get { if (_clients == null) _clients = new Clients(_authRequest); return _clients; }
        }

    }
}
