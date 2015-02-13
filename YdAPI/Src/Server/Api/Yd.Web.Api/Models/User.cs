using System.Collections.Generic;
using System.Diagnostics;

namespace Yd.Web.Api.Models
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public bool TwoFactorEnabled { get; set; }

        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}