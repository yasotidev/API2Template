using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

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