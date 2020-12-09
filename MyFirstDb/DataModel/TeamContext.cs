using System;
using System.Data.Entity;
using System.Linq;
using MyFirstDb.DataModel;

namespace MyFirstDb.DataModel
{
    public class TeamContext : DbContext
    {
        public TeamContext()
            : base("name=TeamContext")
        {
        }
        public DbSet<Team> Teams { get; set; }
    }

}