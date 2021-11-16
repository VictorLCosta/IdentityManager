using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Web.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Por favor, informe o email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Por favor, informe a senha")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
