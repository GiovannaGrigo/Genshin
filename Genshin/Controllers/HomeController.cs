using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Genshin.Models;
using Genshin.Data;
using Genshin.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Genshin.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;


    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Personagens = _context.Personagens
            .Include(p => p.Arma)
            .Include(p => p.Elemento)
            .ToList(),
            Elementos = _context.Elementos.ToList(),
            Armas = _context.Armas.ToList()
        };

        return View(home);
    }

    public IActionResult Details(int id)
    {
        Personagem personagem = _context.Personagens
                        .Where(p => p.Id == id)
                        .Include(p => p.Arma)
                        .Include(p => p.Elemento)
                        .SingleOrDefault();



        DetailVM detailVM = new()
        {
            Atual = personagem,
            Anterior = _context.Personagens
                .OrderByDescending(p => p.Id)
                .FirstOrDefault(p => p.Id < id),
            Proximo = _context.Personagens
                .OrderBy(p => p.Id)
                .FirstOrDefault(p => p.Id > id)
        };

        return View(detailVM);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
