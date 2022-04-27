using System.ComponentModel.DataAnnotations;

namespace RotaLoginMVC.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string Password { get; set; }    

    }
}
