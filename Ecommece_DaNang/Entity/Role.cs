namespace Ecommece_DaNang.Entity
{
    public class Role
    {
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public ICollection<Users> user { get; set; }
    }
}
