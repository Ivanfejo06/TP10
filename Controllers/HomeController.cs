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
        ViewBag.Series = BD.InfoSeries();
        return View();
    }

    public Actores VerDetalleActoresAjax(int idactor){
        ViewBag.Actores = BD.
        return ViewBag.Actores;
    }
    public Actores VerDetalleSeriesAjax(int idserie){
        ViewBag.Series = BD.
        return ViewBag.Series;
    }
    public Actores VerDetalleTemporadasAjax(int idtemporada){
        ViewBag.Temporadas = BD.
        return ViewBag.Temporadas;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
