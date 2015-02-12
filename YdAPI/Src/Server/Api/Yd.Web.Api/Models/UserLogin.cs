using System.Data.Entity.Spatial;

namespace Yd.Web.Api.Models
{
    public class UserLogin
    {
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}