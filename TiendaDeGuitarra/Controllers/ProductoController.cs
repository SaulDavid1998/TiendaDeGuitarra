using Microsoft.AspNetCore.Mvc;
using TiendaDeGuitarra.Models;

namespace TiendaDeGuitarra.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Detalle(int id)
        {
            Productos producto= Productos.GetProducto(id);
            //ViewBag.producto= producto;
            //ViewBag.id = producto.Id;
            //ViewBag.nombre=producto.Nombre;
            //ViewBag.precio=producto.Precio;
            return View(producto);
        }

        public IActionResult Lista()
        {
            List<Productos> lst= Productos.GetProductos();
            return View(lst);
        }
    }
}
