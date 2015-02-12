using System.Data.Entity.ModelConfiguration;

namespace Yd.Web.Api.Models
{
    public class UserLClaimConfiguration  : EntityTypeConfiguration<UserClaim>
    {
        public UserLClaimConfiguration()
        {
            HasKey(o => o.Id);

        

            Property(o => o.Id)
                .HasMaxLength(128); 
        }
    }
}