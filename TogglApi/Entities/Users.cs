using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogglApi.Models;

namespace TogglApi.Entities
{
    public class Users : IEntity<User>
    {
        #region Constructor
        
        TogglAuthRequest _auth;

        public Users(TogglAuthRequest togglAuth)
        {
            if (togglAuth == null || !togglAuth.IsValid())
                throw new ArgumentNullException("togglAuth", "Cannot be null");
            _auth = togglAuth;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public User GetCurrent()
        {
            var client = new RestClient(Constants.Urls.ME);
            var request = new RestRequest(Method.GET);
            request.AddTogglAuth(_auth);

            var resp = client.Execute<UserResponse>(request);

            var content = resp.Content;
            
            return resp.Data.data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public User GetCurrentDetailed()
        {
            var client = new RestClient(Constants.Urls.ME_DETAILED);
            var request = new RestRequest(Method.GET);
            request.AddTogglAuth(_auth);

            var resp = client.Execute<UserResponse>(request);

            var content = resp.Content;

            return resp.Data.data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public User Update(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public User Create(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }
    }
}
