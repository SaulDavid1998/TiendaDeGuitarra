namespace TiendaDeGuitarra.Models
{
    public class Productos
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }= string.Empty;
        public decimal Precio {  get; set; }

        public static List<Productos> GetProductos()
        {
            List<Productos> productos = new List<Productos>();
            productos.Add(new Productos { Id = 1, Nombre = "Fender Stratocaster", Precio = 700000.00m });
            productos.Add(new Productos { Id = 2, Nombre = "Gibson Les Paul", Precio = 1000000.00m });
            productos.Add(new Productos { Id = 3, Nombre = "Gibson SG", Precio = 2000000.00m });
            productos.Add(new Productos { Id = 4, Nombre = "Fender Precision", Precio = 800000.00m });
            productos.Add(new Productos { Id = 5, Nombre = "Hofner Icon", Precio = 500000.00m });

            return productos;
        }

        public static Productos GetProducto(int id)
        {
            List<Productos> productos = Productos.GetProductos();
            foreach (var producto in productos)
            {
                if (producto.Id == id)
                {
                    return producto;
                }
                
            }

            return new Productos();
        }

    }
}
