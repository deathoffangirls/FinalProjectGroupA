using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroupA.Models;

namespace FinalProjectGroupA.Data
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Coach> Coaches { get; set; }
    }
}
