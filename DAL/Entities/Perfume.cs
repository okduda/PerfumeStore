namespace DAL.Entities
{
    public class Perfume : BaseEntity
    {
        public Perfume() : base()
        {
        }

        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public float Price { get; set; }
        public enum Volume
        {
            volume15 = 0,
            volume35 = 1,
            volume50 = 2,
            volume100 = 3
        }
        public List<OrderItem> OrderItems { get; set; }
        public List<CategoryItem> CategoryItems { get; set; }
    }
}
