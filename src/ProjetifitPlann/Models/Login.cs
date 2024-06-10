using System.ComponentModel.DataAnnotations;

namespace ProjetifitPlann.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Obrigatório informar o email")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Lembrar-me ")]
        public bool LembrarMe { get; set; }
    }

}

