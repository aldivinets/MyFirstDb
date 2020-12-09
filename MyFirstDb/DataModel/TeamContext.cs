using System;
using System.Data.Entity;
using System.Linq;

namespace MyFirstDb.DataModel
{
    public class TeamContext : DbContext
    {
        public TeamContext()
            : base("name=TeamContext")
        {
        }
    }

}