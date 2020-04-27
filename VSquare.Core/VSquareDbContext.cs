using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VSquare.Core.Models;

namespace VSquare.Core
{
    public class VSquareDbContext : IdentityDbContext<VSquareUser, VSquareRole, string>
    {
        public VSquareDbContext(DbContextOptions<VSquareDbContext> options)
             : base(options)
        {
        }
    }
}
