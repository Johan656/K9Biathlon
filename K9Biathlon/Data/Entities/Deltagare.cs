using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Data.Entities
{
    public class Deltagare
    {
        public int Id { get; set; }
        public string FNamn { get; set; }
        public string ENamn { get; set; }
        public int Alder { get; set; }
        public string Kon { get; set; }


        public virtual Hund Hund { get; set; }
    }
}
