
using Microsoft.EntityFrameworkCore;

namespace ISWorkerAdmin.Dao {
    public class AppConnection : DbContext {
        public AppConnection(DbContextOptions<AppConnection> options) : base (options) { }
        //public DbSet<EntityName> EntityNames { get; set; }
    }
}
