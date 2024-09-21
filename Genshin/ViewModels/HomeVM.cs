using Genshin.Models;

namespace Genshin.ViewModels;

public class HomeVM
{
    public List<Arma> Armas { get; set; }
    public List<Elemento> Elementos { get; set; }
    public List<Personagem> Personagens { get; set; }
}
