using System.Data.Entity.Spatial;

namespace Yd.Web.Api.Models
{
    public class UserClaim
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }

    }
}