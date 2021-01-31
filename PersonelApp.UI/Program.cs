using PersonelApp.Dal;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            unitOfWork.DepartmentRepository.Add(new Department() { Name="Bilgi İşlem" ,
                Aktifmi =true , EklenmeTarihi=DateTime.Now });
            unitOfWork.Complete();
        }
    }
}
