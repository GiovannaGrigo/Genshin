using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Genshin.Models;

[Table("Elemento")]
public class Elemento
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }

    [Required]
    [StringLength(30)]
    public string Cor { get; set; }
}