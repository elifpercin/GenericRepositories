using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domains
{
    public class Personel : BaseEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int DepartmentId { get; set; } //personel ve departman arasında bire çok bir ilişki olduğu için aralarında foreingnkey olacak
        public Department Department { get; set; } // birde navigationpropertyi verecek her personel bir deparmana dahil
    }
}
