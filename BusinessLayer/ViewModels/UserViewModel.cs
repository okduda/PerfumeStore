namespace BusinessLayer.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleViewModel Role { get; set; }
        public Guid Id { get; set; }
    }
}
