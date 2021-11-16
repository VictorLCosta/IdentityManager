using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Web.Models
{
    public class UserViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha")]
        [StringLength(100, ErrorMessage = "A senha deve ter entre {0} e {2} caracteres", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "As senhas não estão iguais")]
        [DataType(DataType.Password)]
        public int ConfirmPassword { get; set; }
    }
}
