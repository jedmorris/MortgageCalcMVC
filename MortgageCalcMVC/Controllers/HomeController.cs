using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MortgageCalcMVC.Models;

namespace MortgageCalcMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult App()
    {
       // create an instance of the model 
        MortgageCalc model = new MortgageCalc();

        // set default loan amount
        model.LoanPrincipal = 15000;
        // set default loan terms
        model.LoanTerm = 60;
        // set default loan interest rate
        model.InterestRate = 3.5; 
        return View();
    }
   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}