using Google.Apis.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GoogleApiTest.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task Index(string idtoken)
        {
            var validPayload = await GoogleJsonWebSignature.ValidateAsync(idtoken);
        }
    }
}