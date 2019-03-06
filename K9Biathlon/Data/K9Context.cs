using K9Biathlon.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9Biathlon.Data
{
    public class K9Context : DbContext
    {
        public K9Context(DbContextOptions<K9Context> options): base(options)
        {

        }
        // Här behövs endast de klasser/tabeller du ska göra uppslag mot direkt specifieras.
        // De Klasser/tabeller som du kan komma åt via en relation behöver alltså inte ståp med här
        public DbSet<Anmalan> Anmalningar { get; set; }
        public DbSet<Deltagare> Deltagare { get; set; }
        public DbSet<Hund> Hundar { get; set; }
        public DbSet<Lopp> Lopp { get; set; }
        public DbSet<Tavling> Tavlingar { get; set; }
    }
}
