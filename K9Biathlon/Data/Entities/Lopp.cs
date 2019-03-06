using System.Collections.Generic;

namespace K9Biathlon.Data.Entities
{
    public class Lopp
    {
        public int Id { get; set; }
        public string Distans { get; set; }
        public string Klass { get; set; }
        public virtual ICollection<Anmalan> Anmalningar { get; set; }
    }
}