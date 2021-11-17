using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Web.Models
{
    public class ResetPasswordViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Por favor, informe o email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Por favor, informe a senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Por favor, confirme a senha")]
        [Compare(nameof(Password), ErrorMessage = "As senhas não estão iguais")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        
        public string Code { get; set; }
    }
}
