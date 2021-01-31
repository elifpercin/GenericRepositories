using PersonelApp.Dal.Repositories.Abstract;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Dal.Repositories.Concrete
{
    public class DepartmentsRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentsRepository(PersonelContext context):base(context)
        {
                
        }
        public IEnumerable<Department> GetDepartmentsWithPersonel()
        {
            return PersonelContext.Departments.Include("Personels").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonelContext.Departments.Take(count);
        }

        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
