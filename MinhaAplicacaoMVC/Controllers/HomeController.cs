/* Aqui é onde acontece a interação entre a Model(dados) e a View(html) */

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhaAplicacaoMVC.Models;

namespace MinhaAplicacaoMVC.Controllers;

public class HomeController : Controller //é uma classe que herda do Controller
{

    public IActionResult Index() //Método index - página principal da home
    {
        HomeModel home = new HomeModel();

        home.Nome = "Ana Borges";
        home.Email = "bgs.ana08@gmail.com";

        return View(home);
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
