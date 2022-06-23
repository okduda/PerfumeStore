using DAL.Configure;
using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public class OrderItemRepository : BaseRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(PerfumeContext context) : base(context)
        {
        }
    }
}
