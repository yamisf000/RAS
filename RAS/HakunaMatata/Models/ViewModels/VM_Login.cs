using System.ComponentModel.DataAnnotations;

namespace HakunaMatata.Models.ViewModels
{
    public class VM_Login
    {
        [Required(ErrorMessage = "LoginName is required.")]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        public bool IsRememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
