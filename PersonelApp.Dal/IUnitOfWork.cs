using PersonelApp.Dal.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Dal
{
    public interface IUnitOfWork : IDisposable //işlemi bittiği zaman kendisi otomatik olarak silinsin
    {
        IDepartmentRepository DepartmentRepository { get;  }
        IPersonelRepository PersonelRepository { get; }

        int Complete();
    }
}
