using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglApi.Entities
{
    interface IEntity<T>
    {
        IEnumerable<T> Get();
        T Get(string id);
        T Update(T entity);
        T Create(T entity);
        bool Delete(T entity);
    }
}
