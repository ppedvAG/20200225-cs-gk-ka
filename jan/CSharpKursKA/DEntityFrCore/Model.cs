using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace DEntityFrCore
{
    public class KundenDbContext : DbContext
    {
        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Anschrift> Anschriften { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source= KundenDb.db");
        // bei Oracle:
        // Provider von Oracle zu Entity Framework
        // https://docs.oracle.com/database/121/ODPNT/entityOverview.htm#ODPNT8274
    }

    public class Kunde
    {
        // prop tab tab
        [Key]
        public int KundenId { get; set; }
        public string KundenName { get; set; }
        public List<Anschrift> Anschriften { get; } = new List<Anschrift>();
    }

    public class Anschrift
    {
        [Key]
        public int AnschriftId { get; set; }
        public string Stadt { get; set; }
        public string Adresszeile { get; set; }
        public int PLZ { get; set; }
        public int KundenId { get; set; }
        public Kunde KundeInA { get; set; }
    }
    
}
