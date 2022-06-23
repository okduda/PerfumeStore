using System.Collections.Generic;

namespace DAL.Entities
{
    public class Role : BaseEntity
    {
        public Role() : base()
        {
        }

        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
