using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Yd.Web.Api.Models
{
    public class UserRoleConfiguration   : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            HasKey(o => o.UserId);     
            Property(o => o.UserId)
                .HasMaxLength(128); 
        }
    }
}