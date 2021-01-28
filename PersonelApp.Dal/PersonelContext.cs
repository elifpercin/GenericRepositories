using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Dal
{
    public class PersonelContext : DbContext
    {
        public PersonelContext():base("PersonelContext") //personelcontext nesnesi hangi veritabanına yazıcağını bilemiyor o yüzden connectionstring de vermemiz gerekiyor . Base classına conneitonstringi göndericez 
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
