using DAL.Configure;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Interfaces
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(PerfumeContext context) : base(context)
        {
        }

        public new User GetById(Guid id)
        {
            return DbSet.Where(u => u.Id == id).Include(u => u.Role).FirstOrDefault();
        }
    }
}
