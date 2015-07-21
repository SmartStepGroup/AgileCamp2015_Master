#region Usings

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

#endregion

namespace WebApplication.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public ApplicationDbContext() : base("DefaultConnection", false) {}

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<HabitModel> Habits { get; set; }

        IEnumerable<User> IDbContext.Users
        {
            get { return this.Users.Select(ToUser); }
        }

        IQueryable<HabitModel> IDbContext.Habits {
            get { return Habits; }
        }

        private User ToUser(ApplicationUser applicationUser)
        {
            return new User(applicationUser.UserName, applicationUser.Email, Habits.Where(_ => _.UserEmail == applicationUser.Email));
        }

    }

    public interface IDbContext
    {
        IQueryable<HabitModel> Habits { get; }
        IEnumerable<User> Users { get; }
    }
}