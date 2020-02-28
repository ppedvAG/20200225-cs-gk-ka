using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace DEntityFrCore
{
    public class KundenDbContext : DbContext
    {
        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Anschrift> Anschriften { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=KundenDb.db");

        //bei Oracle
        //https://docs.oracle.com/database/121/ODPNT/entityOverview.htm#ODPNT8274
        //Für ältere Versionen mit ADO-Framework
    }

    public class Kunde
    {
        [Key]
        public int KundenId { get; set; }
        public String KundenName { get; set; }
        public List<Anschrift> Anschriften { get; } = new List<Anschrift>();

    }

    public class Anschrift
    {
        public int AnschriftID { get; set; }
        public string Adresszeile { get; set; }
        public int PLZ { get; set; }
        public int KundenID { get; set; }
        public Kunde KundeInAnschrift { get; set; }

    }


}
