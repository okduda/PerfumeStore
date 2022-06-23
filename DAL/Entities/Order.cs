using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Order : BaseEntity
    {
        public Order() : base()
        {
        }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public enum Status
        {
            New,
            Processed,
            Accepted,
            Completed,
            Sent,
            Done,
            Canceled
        }
        public List<OrderItem> OrderItems { get; set; }
    }
}
