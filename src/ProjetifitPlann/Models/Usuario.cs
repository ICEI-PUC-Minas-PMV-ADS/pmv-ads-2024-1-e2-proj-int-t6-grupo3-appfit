using System.ComponentModel.DataAnnotations;

namespace ProjetifitPlann.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório confirmar a senha")]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem")]
        [Display(Name = "Confirmar senha")]
        public string ConfirmarSenha { get; set; }
    }
}
