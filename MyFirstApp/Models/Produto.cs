using System.ComponentModel.DataAnnotations;

namespace MyFirstApp.Models
{
  public class Produto
  {
    public int Id { get; set; }
    [Display(Name = "Personagem:")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Descricao { get; set; }
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }

  }
}
