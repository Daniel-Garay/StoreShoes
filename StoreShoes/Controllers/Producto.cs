using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace StoreShoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Producto : ControllerBase
    {
        /// <summary>
        /// Método para consultar el listado de productos
        /// </summary>
        /// <returns></returns>
        [Route("ConsultarProductos")]
        [HttpGet]
        public IActionResult ConsultarProductos()
        {
            List<dynamic> listProduct = new List<dynamic>();
            var product1 = new { Id = 1, Branch = "Puma" , Color = "Azul"};
            var product2 = new { Id = 2, Branch = "Nike", Color = "Naranja" };

            listProduct.Add(product1);
            listProduct.Add(product2);

            return Ok(listProduct);
        }
        /// <summary>
        /// Metodo para consultar un producto
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        [Route("ConsultarProducto/{idProducto}")]
        [HttpGet]
        public IActionResult ConsultarProducto(int idProducto)
        {
            var product1 = new { Id = idProducto, Branch = "Puma", Color = "Azul" };        
            return Ok(product1);
        }
    }
}
