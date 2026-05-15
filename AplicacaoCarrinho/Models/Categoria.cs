using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace AplicacaoCarrinho.Models
{
    public class Categoria
    {
        [DisplayName("Id da Categoria")]
        [Required]
        public int Id { get; set; }

        [DisplayName("Nome da Categoria")]
        [Required]
        public string Nome { get; set; }
    }
}
