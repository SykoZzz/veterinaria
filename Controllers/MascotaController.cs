using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using System.Collections.Generic;

namespace Veterinaria.Controllers
{
    public class MascotaController : Controller
    {
        private static List<Mascota> listaMascotas = new();

        public IActionResult Index()
        {
            return View(listaMascotas);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Mascota mascota)
        {
            mascota.Id = listaMascotas.Count + 1;
            listaMascotas.Add(mascota);
            return RedirectToAction("Index");
        }
    }
}