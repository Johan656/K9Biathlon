using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Data.Entities
{
    public class Hund
    {
        public int Id { get; set; }
        public int DeltagareId { get; set; }
        public string Namn { get; set; }
        public int Alder { get; set; }
        public string Ras { get; set; }

        public virtual Deltagare Deltagare { get; set; }
    }
}
