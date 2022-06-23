using System.Collections.Generic;

namespace DAL.Entities
{
    public class Brand : BaseEntity
    {
        public Brand() : base()
        {
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public List<Perfume> Perfumes { get; set; }
    }
}
