using System.Collections.Generic;

namespace DAL.Entities
{
    public class User: BaseEntity
    {
        public User(): base()
        {
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<UserRole> Role { get; set; }
    }
}
