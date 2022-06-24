namespace DeliveryTestApi.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdRestaurante { get; set; }
        public int Precio { get; set; }
    }
}
