using DAL.Configure;
using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(PerfumeContext context) : base(context)
        {
        }
    }
}
