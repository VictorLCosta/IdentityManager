using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityManager.Web.Entities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
