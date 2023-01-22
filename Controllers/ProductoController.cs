using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Enumeracion.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Enumeracion.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Crear()
        {
            ViewBag.Categorias = ObtenerCategorias();
            return View();
        }

        private List<SelectListItem> ObtenerCategorias()
        {
            var optiones = new List<SelectListItem>();
            foreach (CategoriasProducto categorias in Enum.GetValues(typeof(CategoriasProducto)))
            {
                var item = new SelectListItem
                {
                    Value = ((int)categorias).ToString(),
                    Text = categorias.ObtenerDescripcion()
                };
                optiones.Add(item);
            }
            return optiones;
        }
    }
}