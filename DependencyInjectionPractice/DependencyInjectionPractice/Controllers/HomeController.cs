using DependencyInjectionPractice.Interfaces;
using DependencyInjectionPractice.Models;
using DependencyInjectionPractice.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;

        public HomeController(IOperationTransient transientOperation,
           IOperationScoped scopedOperation,
           IOperationSingleton singletonOperation, ILogger<HomeController> logger)
        { 
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Transient = _transientOperation.GuidId;
            ViewBag.Scoped = _scopedOperation.GuidId;
            ViewBag.Singleton = _singletonOperation.GuidId;   
            return View();
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
}