using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Yd.Web.Api.Models
{
    public class UserConfiguration  : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {

            HasKey(o => o.Id);

            Property(o => o.Id)
                .HasMaxLength(128);
           
            Property(o => o.UserName)
              .HasMaxLength(256);

            Property(o => o.PasswordHash);

            Property(o => o.SecurityStamp);

            Property(o => o.TwoFactorEnabled);
        }
    }
}