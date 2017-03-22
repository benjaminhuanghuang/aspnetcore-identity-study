using Microsoft.EntityFrameworkCore;    //DbContext
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; //IdentityDbContext

using aspnetcore_identity_study.Models;  

namespace aspnetcore_identity_study.Database
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}
    }
}