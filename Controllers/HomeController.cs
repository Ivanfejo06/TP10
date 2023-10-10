using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.Series();
        return View();
    }

    public Actores VerDetalleActoresAjax(int idserie){
        ViewBag.Actores = BD.InfoActores(idserie);
        return ViewBag.Actores;
    }
    public Actores VerDetalleSeriesAjax(int idserie){
        ViewBag.Series = BD.InfoSerie(idserie);
        return ViewBag.Series;
    }
    public Actores VerDetalleTemporadasAjax(int idserie){
        ViewBag.Temporadas = BD.InfoTemporadas(idserie);
        return ViewBag.Temporadas;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
