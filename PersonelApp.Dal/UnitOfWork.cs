using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelApp.Dal.Repositories.Abstract;
using PersonelApp.Dal.Repositories.Concrete;

namespace PersonelApp.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonelContext _personelContext;
        public UnitOfWork(PersonelContext context)
        {
            _personelContext = context;
            DepartmentRepository = new DepartmentsRepository(_personelContext);
            PersonelRepository = new PersonelRepository(_personelContext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonelRepository PersonelRepository { get; private set; }

        public int Complete()
        {
            return _personelContext.SaveChanges();
        }

        public void Dispose()
        {

        }
    }
}
