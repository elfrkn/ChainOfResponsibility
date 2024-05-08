using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ChainOfResProject.DAL
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI; initial Catalog=DbChain1; integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
