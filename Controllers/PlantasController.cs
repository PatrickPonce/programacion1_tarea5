using Microsoft.AspNetCore.Mvc;
using PROGRAMACION1_TAREA5.Models;
using System.Linq;

namespace PROGRAMACION1_TAREA5.Controllers
{
    public class PlantasController : Controller
    {
        private readonly AppDbContext _context;

        public PlantasController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var plantas = _context.Plantas.ToList();
            return View(plantas);
        }

        public IActionResult Detalle(int id)
        {
            var planta = _context.Plantas.FirstOrDefault(p => p.Id == id);
            if (planta == null) return NotFound();
            return View(planta);
        }
    }
}
