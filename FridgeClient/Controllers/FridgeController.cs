
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;
using FridgeClient.Interfaces;
using Microsoft.Extensions.Logging;
using RestEase;

namespace FridgeClient.Controllers
{

    public class FridgeController : Controller
    {
        

        private readonly IFridgeServer _fridgeServer;

        public FridgeController(ILogger<FridgeController> logger)
        {
           
            _fridgeServer = RestClient.For<IFridgeServer>("https://localhost:5001/");
        }
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public async Task<IActionResult> Fridges()
        {
            var result = await _fridgeServer.GetFridges();

            return View(result);
        }
    }
}