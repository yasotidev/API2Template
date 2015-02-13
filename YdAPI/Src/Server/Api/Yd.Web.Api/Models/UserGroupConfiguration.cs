using System.Data.Entity.ModelConfiguration;

namespace Yd.Web.Api.Models
{
    public class UserGroupConfiguration  : EntityTypeConfiguration<UserGroup>
    {
        public UserGroupConfiguration()
        {
            HasKey(o => new {UserId = o.UserId, GroupId = o.GroupId});
        }
    }
}