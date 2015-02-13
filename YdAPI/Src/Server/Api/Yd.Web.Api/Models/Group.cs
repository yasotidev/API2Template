using System.Collections.Generic;
using System.Security.AccessControl;

namespace Yd.Web.Api.Models
{
    public class Group
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<RoleGroup> Groups { get; set; }
    }
}