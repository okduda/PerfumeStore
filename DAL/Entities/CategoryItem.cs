using System;

namespace DAL.Entities
{
    public class CategoryItem : BaseEntity
    {
        public CategoryItem() : base()
        {
        }

        public Guid PerfumeId { get; set; }
        public Perfume Perfume { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
