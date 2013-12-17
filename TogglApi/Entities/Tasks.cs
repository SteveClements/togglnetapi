using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogglApi.Models;

namespace TogglApi.Entities
{
    public class Tasks : IEntity<Task>
    {
        #region Constructor 

        TogglAuthRequest _auth;

        public Tasks(TogglAuthRequest togglAuth)
        {
            if (togglAuth == null || !togglAuth.IsValid())
                throw new ArgumentNullException("togglAuth", "Cannot be null");
            _auth = togglAuth;
        }

        #endregion

        public IEnumerable<Task> Get()
        {
            throw new NotImplementedException();
        }

        public Task Update(Task entity)
        {
            throw new NotImplementedException();
        }

        public Task Create(Task entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Task entity)
        {
            throw new NotImplementedException();
        }

        public Task Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
