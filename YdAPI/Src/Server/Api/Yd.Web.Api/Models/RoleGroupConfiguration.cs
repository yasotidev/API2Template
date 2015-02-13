using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Yd.Web.Api.Models
{
    public class RoleGroupConfiguration   : EntityTypeConfiguration<RoleGroup>
    {
        public RoleGroupConfiguration()
        {
            HasKey(o => new {o.RoleId, o.GroupId});

            Property(o => o.GroupId);
            Property(o => o.RoleId);

        }
    }
}