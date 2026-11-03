using Microsoft.AspNetCore.Mvc;

namespace WebApiExemplosPOOESW.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
