using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Data.Entities
{
    public class Tavling
    {
        public int Id { get; set; }
        public int Ar { get; set; } // Upplaga
        public string Adress { get; set; }
        public virtual ICollection<Lopp> Lopp { get; set; }
    }
}
