﻿using System;
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
            HasKey(o => new { o.UserId, o.RoleId});

         
        }

           
    }
}