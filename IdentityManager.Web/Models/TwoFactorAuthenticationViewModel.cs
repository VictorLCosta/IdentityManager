using System;

namespace IdentityManager.Web.Models
{
    public class TwoFactorAuthenticationViewModel
    {
        public string Code { get; set; }
        public string Token { get; set; }
    }
}
