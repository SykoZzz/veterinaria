using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using System.Collections.Generic;

namespace Veterinaria.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> listaProductos = new()
        {
            new Producto { Id = 1, Nombre = "Collar", Categoria = "Accesorios", Precio = 15.50m, Stock = 20 },
            new Producto { Id = 2, Nombre = "Comida para Perro", Categoria = "Alimentos", Precio = 50.00m, Stock = 10 }
        };

        public IActionResult Index()
        {
            return View(listaProductos);
        }
    }
}