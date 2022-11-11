using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyFirstApp.Models
{
  public class Categoria
  {
    public int Id { get; set; }
    [Display(Name = "Filme:")]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Descricao { get; set; }
  }
}
