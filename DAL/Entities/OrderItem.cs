using System;

namespace DAL.Entities
{
    public class OrderItem: BaseEntity
    {
        public OrderItem() : base()
        {
        }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid PerfumeId { get; set; }
        public Perfume Perfume { get; set; }
        public int Quantity { get; set; }
    }
}
