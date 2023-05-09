using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o nome de utilizador")]
        [Display(Name = "Utilizador")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Informe a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
