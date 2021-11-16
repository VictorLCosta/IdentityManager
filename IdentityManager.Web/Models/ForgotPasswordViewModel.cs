using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Web.Models
{
    public class ForgotPasswordViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Por favor, informe o email")]
        public string Email { get; set; }
    }
}
