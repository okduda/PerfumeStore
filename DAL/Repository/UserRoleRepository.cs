using DAL.Configure;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Interfaces
{
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(PerfumeContext context) : base(context)
        {
        }

        public UserRole GetByUserId(Guid id)
        {
            return DbSet.Where(ur => ur.UserId == id).Include(ur => ur.Role).FirstOrDefault();
        }
    }
}
