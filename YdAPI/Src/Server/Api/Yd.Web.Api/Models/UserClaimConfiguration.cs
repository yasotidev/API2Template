using System.Data.Entity.ModelConfiguration;

namespace Yd.Web.Api.Models
{
    public class UserClaimConfiguration  : EntityTypeConfiguration<UserClaim>
    {
        public UserClaimConfiguration()
        {
            HasKey(o => o.Id);

            Property(o => o.Id)
                .HasMaxLength(128); 
        }
    }
}