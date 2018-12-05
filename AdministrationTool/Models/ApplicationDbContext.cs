using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AdministrationTool.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<DomainModel> Domains { get; set; }
        public DbSet<HostingModel> Hosting { get; set; }
        public DbSet<BillModel> Bills { get; set; }
        public DbSet<BillItemModel> BillItems { get; set; }
    }
}