using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Genshin.Models;

[Table("Personagem")]
public class Personagem
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }

    [Required]
    [StringLength(500)]
    public string Descricao { get; set; }

    [Required]
    [StringLength(300)]
    public string Imagem { get; set; }

    [Required]
    public int ElementoId { get; set; }
    [ForeignKey("ElementoId")]
    public Elemento Elemento { get; set; }

    [Required]
    public int ArmaId { get; set; }
    [ForeignKey("ArmaId")]
    public Arma Arma { get; set; }
}