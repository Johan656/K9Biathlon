using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Data.Entities
{
    public class Anmalan
    {
        public int Id { get; set; }
        public DateTime AnmalningsDatum { get; set; }
        public int DeltagareId { get; set; }
        public int LoppId { get; set; }

        public virtual Lopp Lopp { get; set; }
        public virtual Deltagare Deltagare { get; set; }
    }
}
