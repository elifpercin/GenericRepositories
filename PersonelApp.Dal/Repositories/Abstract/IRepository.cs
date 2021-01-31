using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Dal.Repositories.Abstract
{
     public interface IRepository<T> where T:class //Tkesinlikle bir class
    {
       T GetById( int id);
       IEnumerable<T> GetAll();
       void Add(T entity);
       void AddRange(IEnumerable<T> entities);
       void Remove(int id);
       void RemoveRange(IEnumerable<T> entities);
    }
}
