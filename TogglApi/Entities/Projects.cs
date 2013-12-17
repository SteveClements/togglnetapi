using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TogglApi.Models;

namespace TogglApi.Entities
{
    public class Projects : IEntity<Project>
    {
        #region Constructor
        
        TogglAuthRequest _auth;

        public Projects(TogglAuthRequest togglAuth)
        {
            if (togglAuth == null || !togglAuth.IsValid())
                throw new ArgumentNullException("togglAuth", "Cannot be null");
            _auth = togglAuth;
        }

        #endregion

        public IEnumerable<Project> Get()
        {
            throw new NotImplementedException();
        }

        public Project Update(Project entity)
        {
            throw new NotImplementedException();
        }

        public Project Create(Project entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public Project Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
