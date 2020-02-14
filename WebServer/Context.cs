using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer.Models;

namespace WebServer
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<PageContent> PageContents { get; set; }
        public DbSet<TariffContent> TariffContents { get; set; }
		public DbSet<BusinessCallback> BusinessCallback { get; set; }
        public DbSet<Complaints> Complaints { get; set; }
        public DbSet<SalesReps> SalesReps { get; set; }
        public DbSet<MovingHomeKeypad> MovingHomeKeypad { get; set; }
        public DbSet<MovingHomeBillPay> MovingHomeBillPay { get; set; }
        public DbSet<Switching> Switching { get; set; }
        public DbSet<LeagueModel> LeagueModel { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Fixtures> Fixtures { get; set; }
        public DbSet<Results> Results { get; set; }

    }
}
