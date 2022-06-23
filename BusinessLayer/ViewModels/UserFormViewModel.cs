using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class UserFormViewModel
    {
        public UserViewModel User { get; set; }
        public List<RoleViewModel> UserRoleList { get; set; }
    }
}
