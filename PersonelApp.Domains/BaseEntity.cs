using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domains
{
     public class BaseEntity
    {
        public DateTime? EklenmeTarihi { get; set; }
        public DateTime? GüncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public bool Aktifmi { get; set; }
    }
}
