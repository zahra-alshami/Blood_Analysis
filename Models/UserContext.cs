using Blood_Analysis.Models;
using System.Data.Entity;

namespace Blood_Analysis.Data
{
    public class UserContext : DbContext
    {
        public UserContext() : base("conn")
        {
        }
        public DbSet<User> users { get; set; }
    }
}