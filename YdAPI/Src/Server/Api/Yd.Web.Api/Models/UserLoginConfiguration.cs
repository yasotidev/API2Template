using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Yd.Web.Api.Models
{
    public class UserLoginConfiguration  : EntityTypeConfiguration<UserLogin>
    {
        public UserLoginConfiguration()
        {
            HasKey(o => o.UserId);

        

            Property(o => o.UserId)
                .HasMaxLength(128); 
        }
    }
}