using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domains
{
    public class Department : BaseEntity
    {
        public Department() // Nullreferenceexception hatası almamak için departmanın constructora geliyoruz ve oluşturuyoruz 
        {
            Personeller = new List<Personel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Personel>  Personeller { get; set; }
    }
}
