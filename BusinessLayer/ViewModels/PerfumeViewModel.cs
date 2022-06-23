using DAL.Entities;
using static DAL.Entities.Perfume;

namespace BusinessLayer.ViewModels
{
    public class PerfumeViewModel
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public float Price { get; set; }
        public Volume Volume { get; set; }
        
        public List<OrderItem> OrderItems { get; set; }
        public List<CategoryItem> CategoryItems { get; set; }

    }
}
