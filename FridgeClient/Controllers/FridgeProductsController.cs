using FridgeClient.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestEase;
using System;
using System.Threading.Tasks;

namespace FridgeClient.Controllers
{
    public class FridgeProductsController : Controller
    {

        private readonly IFridgeProductServer _fridgeProductServer;
        

        public FridgeProductsController(ILogger<FridgeProductsController> logger)
        {
             
            _fridgeProductServer = RestClient.For<IFridgeProductServer>("https://localhost:5001/");
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> ProductsFromFridge (Guid id)
        {
            //Guid fridgeId = id;
            var result = await _fridgeProductServer.GetProductsForFridge(id);

            return View(result);
        }
    }


}
