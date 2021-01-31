using PersonelApp.Dal.Repositories.Abstract;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Dal.Repositories.Concrete
{
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {

        public PersonelRepository(PersonelContext context):base(context)
        {

        }
        public IEnumerable<Personel> GetPersonelWihtDepartments()
        {
            return PersonelContext.Personels.Include("Departments").ToList();
        }
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
