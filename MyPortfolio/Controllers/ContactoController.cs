using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;


namespace MyPortfolio.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Index()
        {
            var contacto = new ContactoDTO();
            return View(contacto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public IActionResult Index(ContactoDTO contacto)
        {
            TempData["Correcto"] = "Mensaje enviado correctamente";
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}
