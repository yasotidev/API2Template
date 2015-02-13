namespace Yd.Web.Api.Models
{
    public class UserRole
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public string RoleId { get; set; }
    }
}