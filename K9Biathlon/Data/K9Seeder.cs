using K9Biathlon.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Data
{
    public class K9Seeder
    {
        private readonly K9Context _ctx;
        private readonly IHostingEnvironment hosting;

        public K9Seeder(K9Context ctx, IHostingEnvironment hosting)
        {

            _ctx = ctx;
            this.hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated(); // Kolla så att databasen finns.

            if(!_ctx.Tavlingar.Any())
            {
                // Need to create sample data

                var lopp = new Lopp()
                {
                    Distans = "8",
                    Klass = "Tävling",
                };

                _ctx.Lopp.AddRange(lopp);

                var tavling = new Tavling()
                {
                    Ar = DateTime.Now.Year,
                    Adress = "SEGERSJÖ 647, 715 93 Odensbacken",
                    Lopp = new List<Lopp>()                 
                };

                tavling.Lopp.Add(lopp);
                _ctx.Tavlingar.AddRange(tavling);


                var deltagare = new Deltagare()
                {
                    FNamn = "Johan",
                    ENamn = "Öhberg",
                    Alder = 25,
                    Kon = "Man"
                };

                _ctx.Deltagare.AddRange(deltagare);

                var hund = new Hund()
                {
                    DeltagareId = deltagare.Id,
                    Namn = "Stella",
                    Alder = 6,
                    Ras = "Soft Coated Wheaten Terrier"

                };

                _ctx.Hundar.AddRange(hund);

                var anmalan = new Anmalan()
                {

                    AnmalningsDatum = DateTime.Now,
                    LoppId = lopp.Id,
                    DeltagareId = deltagare.Id
                    
                };

                _ctx.Anmalningar.AddRange(anmalan);

                // Utför ändringarna mot databasen
                _ctx.SaveChanges();

            }
        }
    }
}
