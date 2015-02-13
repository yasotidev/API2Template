using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yd.Web.Api.Models
{
    public class RoleGroup
    {
        public string RoleId { get; set; }
        public virtual Role Role { get; set; }
        public string GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}