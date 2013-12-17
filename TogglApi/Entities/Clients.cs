using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogglApi.Models;

namespace TogglApi.Entities
{
    public class Clients : IEntity<Client>
    {
        #region Constructor
        
        TogglAuthRequest _auth;

        public Clients(TogglAuthRequest togglAuth)
        {
            if (togglAuth == null || !togglAuth.IsValid())
                throw new ArgumentNullException("togglAuth", "Cannot be null");
            _auth = togglAuth;
        }

        #endregion

        public IEnumerable<Client> Get()
        {
            var client = new RestClient(Constants.Urls.ME_CLIENTS);
            var request = new RestRequest(Method.GET);
            request.AddTogglAuth(_auth);

            var resp = client.Execute<List<Client>>(request);

            var content = resp.Content;

            return resp.Data;
        }

        public Client Get(string id)
        {
            var client = new RestClient(Constants.Urls.ME_CLIENTS + "/{clientId}");
            var request = new RestRequest(Method.GET);
            request.AddTogglAuth(_auth);
            request.AddUrlSegment("clientId", id);

            var resp = client.Execute<ClientResponse>(request);

            var content = resp.Content;

            return resp.Data.data;
        }

        public Client Update(Client entity)
        {
            throw new NotImplementedException();
        }

        public Client Create(Client entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Client entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
