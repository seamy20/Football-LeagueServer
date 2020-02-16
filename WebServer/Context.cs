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
        public DbSet<LeagueModel> LeagueModel { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Fixtures> Fixtures { get; set; }
        public DbSet<Results> Results { get; set; }
        public DbSet<Players> Players { get; set; }

    }
}
