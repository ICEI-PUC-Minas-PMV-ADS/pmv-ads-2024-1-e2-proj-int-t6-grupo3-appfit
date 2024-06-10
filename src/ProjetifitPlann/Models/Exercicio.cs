using System.ComponentModel.DataAnnotations;

namespace ProjetifitPlann.Models
{
    public class Exercicio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string GrupoMuscular { get; set; }
        public bool Concluido { get; set; } // Flag to mark exercise as completed
    }

}
