using Azure.Data.Tables;
using Azure.Storage.Queues;
using IceTask1cldv.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IceTask1cldv.Controllers
{
    public class HomeController : Controller
    {
        // add this 
        private readonly ILogger<HomeController> _logger;
        private readonly TableServiceClient _tableServiceClient;
        private readonly QueueServiceClient _queueServiceClient;
        public HomeController(ILogger<HomeController> logger, TableServiceClient tableServiceClient, QueueServiceClient queueServiceClient)
        {
            _logger = logger;
            _tableServiceClient = tableServiceClient;
            _queueServiceClient = queueServiceClient;
        }



        public IActionResult Index()
        {
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
