using System.ComponentModel.DataAnnotations;

namespace CriaçãoDeCadastros.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatório.")]
        [Phone(ErrorMessage = "Digite um Numero valido")]
        public string Numero { get; set; }
    }
}
