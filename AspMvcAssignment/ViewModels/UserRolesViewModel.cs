namespace AspMvcAssignment.ViewModels
{
    public class UserRolesViewModel
    {
        public string Name { get; set; }

        public string UserId { get; set; }

        public List<string> Roles { get; set; } = new List<string>();
    }
}
