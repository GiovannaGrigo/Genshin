using Genshin.Models;

namespace Genshin.ViewModels;

public class DetailVM
{
    public Personagem Anterior { get; set; }
    public Personagem Atual { get; set; }
    public Personagem Proximo { get; set; }
}
