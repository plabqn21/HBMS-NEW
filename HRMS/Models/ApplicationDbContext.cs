using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace HRMS.Models
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





        public System.Data.Entity.DbSet<HRMS.Models.House> Houses { get; set; }
        public DbSet<SecurityCode> SecurityCodes { get; set; }


        public DbSet<Renter> Renters { get; set; }


    }
}