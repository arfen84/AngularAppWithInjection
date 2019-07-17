using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;
using Restauracje.Models;

namespace Restaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Restauracja> Restauracje { get; set; }
        public DbSet<Hotel> Hotele { get; set; }
        public DbSet<DomWeselny> DomyWeselne { get; set; }
        public DbSet<Klub> Kluby { get; set; }
        public DbSet<Karczma> Karczmy { get; set; }
        public DbSet<Kawiarnia> Kawiarnie { get; set; }
        public DbSet<Pub> Puby { get; set; }
        public DbSet<SalaBankietowa> SaleBankietowe { get; set; }
        public DbSet<SPA> SPA { get; set; }
        public DbSet<Agroturystyczne> Agroturystyczne { get; set; }
        public DbSet<DomkiLetniskowe> DomkiLetniskowe { get; set; }
        public DbSet<Apartament> Apartamenty { get; set; }
        public DbSet<CentrumEventowe> CentraEventowe { get; set; }
        public DbSet<EscapeRoom> EscapeRoomy { get; set; }
        public DbSet<SalaZabaw> SaleZabaw { get; set; }
        public DbSet<SciankaWspinaczkowa> SciankiWspinaczkowe { get; set; }
        public DbSet<Mieszkanie> Mieszkania { get; set; }
        public DbSet<CentrumRekreacji> CentraRekreacji { get; set; }


    }
}
