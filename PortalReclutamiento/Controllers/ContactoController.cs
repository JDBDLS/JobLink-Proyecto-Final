using Microsoft.AspNetCore.Mvc;
using PortalReclutamiento.Data;
using PortalReclutamiento.Models;
using System.Threading.Tasks;

namespace PortalReclutamiento.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Enviar(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                contacto.FechaEnvio = DateTime.Now;
                _context.Add(contacto);
                await _context.SaveChangesAsync();
                TempData["Mensaje"] = "Mensaje enviado correctamente";
                return RedirectToAction("Contactanos", "Home");
            }
            return RedirectToAction("Contactanos", "Home");
        }
    }
}