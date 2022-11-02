using FridgeClient.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestEase;
using System.Threading.Tasks;

namespace FridgeClient.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductServer _productServer;

        public ProductController(ILogger<ProductController> logger)
        {

            _productServer = RestClient.For<IProductServer>("https://localhost:5001/");
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Products()
        {
            var result = await _productServer.GetProducts();

            return View(result);
        }
    }
}

