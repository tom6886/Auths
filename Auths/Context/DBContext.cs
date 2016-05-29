using Auths.Models;
using System.Data.Entity;

namespace Auths.Context
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("Name=DBContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
            base.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<IUser> IUser { get; set; }

        public DbSet<IRole> IRole { get; set; }
    }
}
